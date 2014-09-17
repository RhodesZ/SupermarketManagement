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

namespace 客户端
{
    public partial class Peoplemanagement : Form
    {
        const string IP = "59.66.135.77";//默认的服务器IP
        public static string connstring = String.Format("Data Source={0};Initial Catalog=ProductManagement;User ID=Rhodes;Password=123456", IP);//默认的连接字符串
        private Point offset;
        private int temp=0,temp1=0;
        public void Save()
        {
            saveFileDialog.ShowDialog();
            Stream myStream;
            try
            {
                myStream = saveFileDialog.OpenFile();
            }
            catch
            {
                return;
            }
            StreamWriter sw = new StreamWriter(myStream, System.Text.Encoding.GetEncoding(-0));
            string str = "";
            try
            {
                for (int i = 1; i < this.dataGridView1.ColumnCount; i++)
                {
                    if (i > 1)
                    {
                        str += "\t";
                    }
                    str += this.dataGridView1.Columns[i].HeaderText;
                }
                sw.WriteLine(str);
                for (int j = 0; j < this.dataGridView1.Rows.Count; j++)
                {
                    string tempStr = "";
                    for (int k = 1; k < this.dataGridView1.Columns.Count; k++)
                    {
                        if (k > 1)
                        {
                            tempStr += "\t";
                        }
                        tempStr += (dataGridView1.Rows[j].Cells[k].Value == null ? "Null" : dataGridView1.Rows[j].Cells[k].Value.ToString());
                    }
                    sw.WriteLine(tempStr);
                }
                sw.Close();
                myStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sw.Close();
                myStream.Close();
            }
        }
        public Peoplemanagement()
        {
            InitializeComponent();
        }
        public string searchcommannd()
        {
            string command = "";
            if (name.Text != "")
                command = command + "name=\'" + name.Text + "\' and ";
            if (sex.Text != "")
                command = command + "sex=\'" + sex.Text + "\' and ";
            if (department.Text != "")
                command = command + "department=\'" + department.Text + "\' and ";
            if (position.Text != "")
                command = command + "position=\'" + position.Text + "\' and ";
            if (command != "")
            {
                command = command.Remove(command.LastIndexOf("and"), 3);
            }
            return command;
        }
        public void clc()
        {
            name.Text = "";
            sex.Text = "";
            department.Text = "";
            position.Text = "";
        }
        public void delete(string name)
        {
            SqlConnection sqlconn1 = new SqlConnection(connstring);
            sqlconn1.Open();
            String SearchComm = string.Format("DELETE FROM userinfo WHERE name='{0}'", name);
            SqlCommand comm = new SqlCommand(SearchComm, sqlconn1);
            if (comm.ExecuteNonQuery() != 0)
            {
                Message msg = new Message("");
                msg.setmessage("删除成功");
            }
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            if (searchcommannd() != "")
            {
                dataGridView1.Rows.Clear();
                SqlConnection sqlconn1 = new SqlConnection(connstring);
                sqlconn1.Open();
                String SearchComm = string.Format("SELECT * FROM userinfo WHERE " + searchcommannd());
                SqlCommand comm = new SqlCommand(SearchComm, sqlconn1);
                SqlDataReader sdr = comm.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        int index = this.dataGridView1.Rows.Add();
                        dataGridView1.Rows[index].Cells[0].Value = sdr[0];
                        for (int i = 2; i < 7; i++)
                        {
                            this.dataGridView1.Rows[index].Cells[i-1].Value = sdr[i];
                        }
                    }

                }
                else
                {
                    Message msg = new Message("");
                    msg.setmessage("该员工不存在!");
                }
                clc();
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
            for (int i = 0; i < num; i++)
            {
                temp = this.dataGridView1.Rows[dataGridView1.SelectedRows[i].Index].Cells[0].Value.ToString();
                delete(temp);
            }
            foreach (DataGridViewRow deleterow in dataGridView1.SelectedRows)
                dataGridView1.Rows.Remove(deleterow);
        }

        private void Peoplemanagement_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            timer1.Enabled = true;
        }

        private void changebutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                timer3.Enabled = true;
                name.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                sex.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                department.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                position.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                salary.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                perimission.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                if (temp1 == 0)
                {
                    changebutton.BackgroundImage = Properties.Resources.button3;
                    changebutton.Text = "Cancel";
                    temp1 = 1;
                    name.ReadOnly = true;
                    sex.Enabled = false;
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
                msg.setmessage("请先选择要修改的员工！");
            }
            else
            {
                Message msg = new Message("");
                msg.setmessage("对不起,仅支持单条信息修改");
            }
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn1 = new SqlConnection(connstring);
            sqlconn1.Open();
            String UpdateComm = string.Format("UPDATE userinfo set department='{0}',position='{1}',salary='{2}',permission='{3}' WHERE name='{4}'", department.Text, position.Text,salary.Text,perimission.Text,name.Text);
            if (UpdateComm != "")
            {
                SqlCommand comm = new SqlCommand(UpdateComm, sqlconn1);
                if (comm.ExecuteNonQuery() != 0)
                {
                    Message msg = new Message("");
                    msg.setmessage("修改成功");
                    dataGridView1.Rows.Clear();
                    timer3.Enabled = true;
                    clc();
                    changebutton.BackgroundImage = Properties.Resources.button;
                    changebutton.Text = "Change";
                    temp1 = 0;
                }
            }
        }

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity + 0.03;
            if (this.Opacity == 1)
                timer1.Enabled = false;
        }

        private void Peoplemanagement_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;
            Point cur = this.PointToScreen(e.Location);
            offset = new Point(cur.X - this.Left, cur.Y - this.Top);
        }

        private void Peoplemanagement_MouseMove(object sender, MouseEventArgs e)
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

        private void deletebutton_MouseEnter(object sender, EventArgs e)
        {
            deletebutton.BackgroundImage = Properties.Resources.button3;
        }

        private void cancelbutton_MouseEnter(object sender, EventArgs e)
        {
            cancelbutton.BackgroundImage = Properties.Resources.button3;
        }

        private void cancelbutton_MouseLeave(object sender, EventArgs e)
        {
            cancelbutton.BackgroundImage = Properties.Resources.button2;
        }

        private void deletebutton_MouseLeave(object sender, EventArgs e)
        {
            deletebutton.BackgroundImage = Properties.Resources.button2;
        }

        private void 另存为信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
