using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Threading;
using System.Collections;

namespace 客户端
{
    public partial class Changeproductinfo : Form
    {
        const string IP = "59.66.135.77";//默认的服务器IP
        public static string connstring = String.Format("Data Source={0};Initial Catalog=ProductManagement;User ID=Rhodes;Password=123456", IP);//默认的连接字符串
        private Point offset;
        int temp = 0,temp1=0,temp2=0;

        //检验输入的季度是合理的
        public bool checkseason()
        {
            if (newreason.Text == "1" || newreason.Text == "2" || newreason.Text == "3" || newreason.Text == "4")
                return true;
            else
                return false;
        }

        public Changeproductinfo()
        {
            InitializeComponent();
        }

        //检验某字符串是否只含有数字
        public bool isnumber(string temp)
        {
            foreach (char character in temp)
            {
                if (character < 0x30 || character > 0x39)
                    return false;
            }
            return true;
        }

        //此函数用于根据文本框所填的内容生成SQL的语句
        public string searchcommannd()
        {
            string command="";
            if (firstclass.Text != "")
                command = command + "firstclass=\'" + firstclass.Text + "\' and ";
            if (secondclass.Text != "")
                command = command + "secondclass=\'" + secondclass.Text + "\' and ";
            if (id.Text != "")
                command = command + "id=" + id.Text + " and ";
            if (name.Text != "")
                command = command + "name=\'" + name.Text + "\' and ";
            if (state.Text != "")
                command = command + "state=\'" + state.Text + "\' and ";
            if (dateTimePicker1.Text != " ")
                command = command + "date=\'" + dateTimePicker1.Text + "\' and ";
            if(command!="")
            {
                command = command.Remove(command.LastIndexOf("and"), 3);
            }
            return command;
        }

        //此函数用于把现在各个输入框都清空
        public void clc()
        {
            firstclass.Text = "";
            secondclass.Text = "";
            id.Text = "";
            name.Text = "";
            state.Text = "";
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.CustomFormat = " ";
        }

        //此函数用于删除数据库内指定id的数据
        public void delete(string id)
        {
            SqlConnection sqlconn1 = new SqlConnection(connstring);
            sqlconn1.Open();
            String SearchComm = string.Format("DELETE FROM productinfo WHERE id='{0}'",id);
            //String SearchComm = string.Format("DELETE FROM productinfo WHERE id=\'"+id+"\'");
            SqlCommand comm = new SqlCommand(SearchComm, sqlconn1);
            if (comm.ExecuteNonQuery()!=0)
            {
                Message msg = new Message("");
                msg.setmessage("删除成功");
            }
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            if(isnumber(id.Text)==false)
            {
                Message msg = new Message("");
                msg.setmessage("商品条码为数字！");
            }
            if(searchcommannd() !="")
            {
                dataGridView1.Rows.Clear();
                SqlConnection sqlconn1 = new SqlConnection(connstring);
                sqlconn1.Open();
                String SearchComm = string.Format("SELECT * FROM productinfo WHERE " + searchcommannd());
                SqlCommand comm = new SqlCommand(SearchComm, sqlconn1);
                SqlDataReader sdr = comm.ExecuteReader();
                if(sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        int index = this.dataGridView1.Rows.Add();
                        for (int i = 0; i < 12; i++)
                        {
                            this.dataGridView1.Rows[index].Cells[i].Value = sdr[i];
                        }
                    }
                    
                }
                else
                {
                    Message msg = new Message("");
                    msg.setmessage("该商品不存在!");
                }
                clc();
            }
        }

        //用于实现选择第一分类自动生成第二分类
        private void firstclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstclass.Text == "电器")
            {
                secondclass.Items.Clear();
                secondclass.Items.Add("电脑");
                secondclass.Items.Add("家用电器");
                secondclass.Items.Add("移动电子商品");
                secondclass.Items.Add("");
            }
            else if (firstclass.Text == "百货")
            {
                secondclass.Items.Clear();
                secondclass.Items.Add("日用品");
                secondclass.Items.Add("玩具");
                secondclass.Items.Add("其他");
                secondclass.Items.Add("");
            }
            else if (firstclass.Text == "食品")
            {
                secondclass.Items.Clear();
                secondclass.Items.Add("生鲜食品");
                secondclass.Items.Add("果蔬食品");
                secondclass.Items.Add("干货食品");
                secondclass.Items.Add("");
            }
            else if (firstclass.Text == "书籍")
            {
                secondclass.Items.Clear();
                secondclass.Items.Add("育儿");
                secondclass.Items.Add("美容");
                secondclass.Items.Add("文学");
                secondclass.Items.Add("历史");
                secondclass.Items.Add("");
            }
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            int num = dataGridView1.SelectedRows.Count;
            string temp;
            for (int i = 0; i < num;i++ )
            {
                temp=this.dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[2].Value.ToString();
                delete(temp);
            }
            foreach(DataGridViewRow deleterow in dataGridView1.SelectedRows)
                dataGridView1.Rows.Remove(deleterow);
        }

        private void Searchproductinfo_Load(object sender, EventArgs e)
        {
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom; 
            this.dateTimePicker1.CustomFormat = " ";
            this.Opacity = 0;
            timer1.Enabled = true;
        }

        private void changebutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                timer3.Enabled = true;
                timer4.Enabled = true;
                firstclass.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                secondclass.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                name.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                id.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                state.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
                this.dateTimePicker1.CustomFormat = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                if (temp1 == 0)
                {
                    changebutton.BackgroundImage = Properties.Resources.button3;
                    changebutton.Text = "Cancel";
                    temp1 = 1;
                }

                else
                {
                    clc();
                    changebutton.BackgroundImage = Properties.Resources.button;
                    changebutton.Text = "Change";
                    temp1 = 0;
                }
            }
            else if (dataGridView1.SelectedRows.Count == 0)
            {
                Message msg = new Message("");
                msg.setmessage("请先选择要修改的商品！");
            }
            else
            {
                Message msg = new Message("");
                msg.setmessage("对不起,仅支持单条信息修改");
            }
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            string id = this.dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[2].Value.ToString();
            SqlConnection sqlconn1 = new SqlConnection(connstring);
            sqlconn1.Open();
            String UpdateComm="";
            if(newstate.Text=="退回")
                UpdateComm = string.Format("UPDATE productinfo set state='{0}',reason='{1}',season=NULL,account='{2}' WHERE id='{3}'",newstate.Text,newreason.Text,Login.id,id);
                //UpdateComm = string.Format("UPDATE productinfo set state=\'" + newstate.Text + "\',reason=\'"+newreason.Text + "\',season=NULL"+ ",account=\'"+Login.id+"\' WHERE id=\'" + id + "\'");
            else if(newstate.Text=="售出")
            {
                if(checkseason()==true)
                    UpdateComm = string.Format("UPDATE productinfo set state='{0}',season='{1}',reason=NULL,account='{2}' WHERE id='{3}'",newstate.Text,newreason.Text,Login.id,id);
                    //UpdateComm = string.Format("UPDATE productinfo set state=\'" + newstate.Text + "\',season=\'" + newreason.Text + "\',reason=NULL" + ",account=\'" + Login.id + "\' WHERE id=\'" + id + "\'");
                else
                {
                    Message msg = new Message("");
                    msg.setmessage("输入的季度不合规范");
                }
            }
            else if(newstate.Text=="")
            {
                Message msg = new Message("");
                msg.setmessage("请选择改变的状态");
            }
            else
                UpdateComm = string.Format("UPDATE productinfo set state='{0}',reason=NULL,season=NULL,account='{1}' WHERE id='{2}'",newstate.Text,Login.id,id);
                //UpdateComm = string.Format("UPDATE productinfo set state=\'" + newstate.Text + "\',reason=NULL,season=NULL,account=\'" + Login.id + "\' WHERE id=\'" + id + "\'");
            if(UpdateComm!="")
            {
                SqlCommand comm = new SqlCommand(UpdateComm, sqlconn1);
                if (comm.ExecuteNonQuery() != 0)
                {
                    Message msg = new Message("");
                    msg.setmessage("修改成功");
                    dataGridView1.Rows.Clear();
                    timer3.Enabled = true;
                    timer4.Enabled = true;
                    clc();
                }
            }
        }

        private void newstate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (newstate.Text == "退回")
            {
                label8.Text = "退回原因";
                newreason.Visible = true;
            }
            else if(newstate.Text=="售出")
            {
                label8.Text = "售出季度";
                newreason.Visible = true;
            }
            else
            {
                label8.Text = "（选填）";
                newreason.Visible = false;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePicker1.Format = DateTimePickerFormat.Short; 
            this.dateTimePicker1.CustomFormat = null;
        }





        ///以下为UI代码，与动画效果有关
        //以下四段函数实现窗口拖动
        private void Searchproductinfo_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;
            Point cur = this.PointToScreen(e.Location);
            offset = new Point(cur.X - this.Left, cur.Y - this.Top);
        }
        private void Searchproductinfo_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;
            Point cur = MousePosition;
            this.Location = new Point(cur.X - offset.X, cur.Y - offset.Y);
        }
        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;

            Point cur = this.PointToScreen(e.Location);
            offset = new Point(cur.X - this.Left, cur.Y - this.Top);
        }
        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;
            Point cur = MousePosition;
            this.Location = new Point(cur.X - offset.X, cur.Y - offset.Y);
        }
        //此时间控件实现窗口加载动画
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity + 0.03;
            if (this.Opacity == 1)
                timer1.Enabled = false;
        }
        //此时间控件实现窗口消失动画
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
                this.Opacity = this.Opacity - 0.03;
            else
            {
                timer2.Enabled = false;
                this.Close();
            }
        }
        //此时间控件实现数据显示框的动态加载消失效果
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (temp == 0)
            {
                if (pictureBox6.Location.Y < 500)
                {
                    pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y + 15);
                    dataGridView1.Location = new Point(dataGridView1.Location.X, dataGridView1.Location.Y + 15);
                }
                else
                {
                    timer3.Enabled = false;
                    temp = 1;

                }
            }
            else
            {
                if (pictureBox6.Location.Y > 244)
                {
                    pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y - 15);
                    dataGridView1.Location = new Point(dataGridView1.Location.X, dataGridView1.Location.Y - 15);
                }
                else
                {
                    timer3.Enabled = false;
                    temp = 0;
                }
            }
        }
        //此时间控件实现更改状态框的动态加载与消失效果
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (temp2 == 0)
            {
                if (pictureBox8.Location.X < 403)
                {
                    pictureBox8.Location = new Point(pictureBox8.Location.X + 30, pictureBox8.Location.Y);
                    label6.Location = new Point(label6.Location.X + 30, label6.Location.Y);
                    newstate.Location = new Point(newstate.Location.X + 30, newstate.Location.Y);
                    pictureBox9.Location = new Point(pictureBox9.Location.X - 31, pictureBox9.Location.Y);
                    label8.Location = new Point(label8.Location.X - 31, label8.Location.Y);
                    newreason.Location = new Point(newreason.Location.X - 31, newreason.Location.Y);
                }
                else
                {
                    timer4.Enabled = false;
                    temp2 = 1;
                }
            }
            else
            {
                if (pictureBox8.Location.X > -241)
                {
                    pictureBox8.Location = new Point(pictureBox8.Location.X - 30, pictureBox8.Location.Y);
                    label6.Location = new Point(label6.Location.X - 30, label6.Location.Y);
                    newstate.Location = new Point(newstate.Location.X - 30, newstate.Location.Y);
                    pictureBox9.Location = new Point(pictureBox9.Location.X + 31, pictureBox9.Location.Y);
                    label8.Location = new Point(label8.Location.X + 31, label8.Location.Y);
                    newreason.Location = new Point(newreason.Location.X + 31, newreason.Location.Y);
                }
                else
                {
                    timer4.Enabled = false;
                    temp2 = 0;
                }
            }

        }
        //以下六段实现鼠标悬停时的动画效果
        private void changebutton_MouseEnter(object sender, EventArgs e)
        {
            if (temp1 == 1)
                changebutton.BackgroundImage = Properties.Resources.button3;
        }
        private void changebutton_MouseLeave(object sender, EventArgs e)
        {
            if (temp1 == 1)
                changebutton.BackgroundImage = Properties.Resources.button2;
        }
        private void cancelbutton_MouseEnter(object sender, EventArgs e)
        {
            cancelbutton.BackgroundImage = Properties.Resources.button3;
        }
        private void cancelbutton_MouseLeave(object sender, EventArgs e)
        {
            cancelbutton.BackgroundImage = Properties.Resources.button2;
        }
        private void deletebutton_MouseEnter(object sender, EventArgs e)
        {
            deletebutton.BackgroundImage = Properties.Resources.button3;
        }
        private void deletebutton_MouseLeave(object sender, EventArgs e)
        {
            deletebutton.BackgroundImage = Properties.Resources.button2;
        }

    }
}
