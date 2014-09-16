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
    public partial class Newproductinfo : Form
    {
        const string IP = "59.66.135.77";//默认的服务器IP
        public static string connstring = String.Format("Data Source={0};Initial Catalog=ProductManagement;User ID=Rhodes;Password=123456", IP);//默认的连接字符串
        private Point offset;
        public Newproductinfo()
        {
            InitializeComponent();
        }
        public void monthtoseason()
        {
            int temp = dateTimePicker1.Value.Month;
            switch (temp)
            {
                case 1:
                case 2:
                case 3:
                    season.Text = "1";
                    break;
                case 4:
                case 5:
                case 6:
                    season.Text = "2";
                    break;
                case 7:
                case 8:
                case 9:
                    season.Text = "3";
                    break;
                case 10:
                case 11:
                case 12:
                    season.Text = "4";
                    break;
            }
        }
        //检验某字符串是否只含有数字
        public bool isint(string temp)
        {
            foreach (char character in temp)
            {
                if (character < 0x30 || character > 0x39)
                    return false;
            }
            return true;
        }

        //检查某字符串是否只含有数字和小数点以及小数点数目是否不大于1
        public bool isfloat(string temp)
        {
            int dotnumber = 0;
            foreach (char character in temp)
            {
                if ((character < 0x30 || character > 0x39))
                {
                    if(character==46)
                    {
                        dotnumber=dotnumber+1;
                        continue;
                    }     
                    return false;
                }
            }
            if(dotnumber>1)
                return false;
            return true;
        }

        public bool checkid(string temp)
        {
            SqlConnection conn = new SqlConnection(connstring);
            string sql = string.Format("select id from productinfo where id='{0}'", temp);
            //创建Command对象
            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();
            String s4 = Convert.ToString(command.ExecuteScalar());
            if (String.Compare("", s4) != 0)
                return false;
            else
                return true;
        }
        //此函数实现将选填的文本框重置的功能
        public void abandon()
        {
            label8.Text = "（选填）";
            season.Visible = false;
            season.Clear();
            reason.Visible = false;
            reason.Clear();
        }

        //此函数实现将所有文本框清空的功能
        public void clc()
        {
            id.Clear();
            name.Clear();
            inprice.Clear();
            outprice.Clear();
            reason.Clear();
            season.Clear();
            num.Clear();
            textBox1.Clear();
        }
        public class ProductInfo
        {
            private string firstclass="";
            private string secondclass="";
            private string id = "";
            private string name = "";
            private string state = "";
            private string inprice = "";
            private string outprice = "";
            private string reason = "";
            private string season = "";
            private string num = "";
            private string account = "";
            private string date = "";
            public void set(string _firstclass,string _secondclass,string _id,string _name, string _state, 
                string _inprice,string _outprice,string _reason,string _season,string _num,string _date)
            {
                firstclass = _firstclass;
                secondclass = _secondclass;
                id = _id;
                name = _name;
                state = _state;
                inprice = _inprice;
                outprice = _outprice;
                reason = _reason;
                season = _season;
                num = _num;
                account = Login.id;
                date = _date;
            }
            public void upload()
            {
                SqlConnection sqlconn1 = new SqlConnection(connstring);
                String InsertNewComm = string.Format("INSERT INTO productinfo(firstclass,secondclass,id,name,state,inprice,outprice,season,reason,num,account,date) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')",firstclass,secondclass,id,name,state,inprice,outprice,season,reason,num,account,date);
                SqlCommand Upload = new SqlCommand(InsertNewComm,sqlconn1);
                try
                {
                    sqlconn1.Open();
                    if (Upload.ExecuteNonQuery() == 1)
                    {
                        Message msg = new Message("");
                        msg.setmessage("上传信息成功");
                    }                     
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "写入商品信息错误");
                }
            }
        };
        public static ProductInfo productinfo=new ProductInfo();

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Newproductinfo_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            timer2.Enabled = true;
        }

        //通过一级分类的确定来确定二级分类
        private void firstclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstclass.Text == "电器")
            {
                secondclass.Items.Clear();
                secondclass.Items.Add("电脑");
                secondclass.Items.Add("家用电器");
                secondclass.Items.Add("移动电子商品");
            }
            else if(firstclass.Text=="百货")
            {
                secondclass.Items.Clear();
                secondclass.Items.Add("日用品");
                secondclass.Items.Add("玩具");
                secondclass.Items.Add("其他");
            }
            else if (firstclass.Text == "食品")
            {
                secondclass.Items.Clear();
                secondclass.Items.Add("生鲜食品");
                secondclass.Items.Add("果蔬食品");
                secondclass.Items.Add("干货食品");
            }
            else if (firstclass.Text == "书籍")
            {
                secondclass.Items.Clear();
                secondclass.Items.Add("育儿");
                secondclass.Items.Add("美容");
                secondclass.Items.Add("文学");
                secondclass.Items.Add("历史");
            }

        }

        //通过二级分类确定商品编码的其难追
        private void secondclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (secondclass.Text == "电脑")
                textBox1.Text = "0101";
            else if (secondclass.Text == "家用电器")
                textBox1.Text = "0102";
            else if (secondclass.Text == "移动电子商品")
                textBox1.Text = "0103";
            else if (secondclass.Text == "日用品")
                textBox1.Text = "0201";
            else if (secondclass.Text == "玩具")
                textBox1.Text = "0202";
            else if (secondclass.Text == "体育用品")
                textBox1.Text = "0203";
            else if (secondclass.Text == "生鲜食品")
                textBox1.Text = "0301";
            else if (secondclass.Text == "果蔬食品")
                textBox1.Text = "0302";
            else if (secondclass.Text == "干货食品")
                textBox1.Text = "0303";
            else if (secondclass.Text == "育儿")
                textBox1.Text = "0401";
            else if (secondclass.Text == "美容")
                textBox1.Text = "0402";
            else if (secondclass.Text == "文学")
                textBox1.Text = "0403";
            else if (secondclass.Text == "历史")
                textBox1.Text = "0404";
        }

        //通过状态的不同来确定所填的是售出季度还是退回理由
        private void state_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (state.Text == "退回")
            {
                label8.Text = "退回理由";
                season.Visible = false;
                season.Clear();
                reason.Visible = true;
            }
            else if (state.Text == "售出")
            {
                label8.Text = "售出季度";
                season.Visible = true;
                reason.Visible = false;
                reason.Clear();
                monthtoseason();
            }
            else
            {
                abandon();
            }
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            if (isfloat(inprice.Text) == false)
            {
                Message msg = new Message("");
                msg.setmessage("亲，商品进价只能输入数字哦");
            }
            else if (isfloat(outprice.Text) == false)
            {
                Message msg = new Message("");
                msg.setmessage("亲，商品售价只能输入数字哦");
            }
            else if (isint(num.Text) == false)
            {
                Message msg = new Message("");
                msg.setmessage("亲，商品数量只能输入数字哦");
            }
            else if (isint(id.Text) == false)
            {
                Message msg = new Message("");
                msg.setmessage("亲，商品ID只能输入数字哦");
            }
            else if (checkid(textBox1.Text + id.Text) == false)
            {
                Message msg = new Message("");
                msg.setmessage("很抱歉，此商品ID已存在");
            }
            else
            {
                if (firstclass.Text != "" && secondclass.Text != "" && id.Text != "" && name.Text != "" && state.Text != "" && inprice.Text != "" && outprice.Text != "" && num.Text != "")
                {
                    if (state.Text == "售出" && season.Text != "")
                        productinfo.set(firstclass.Text, secondclass.Text, textBox1.Text + id.Text, name.Text, state.Text, inprice.Text, outprice.Text, "", season.Text, num.Text, dateTimePicker1.Text);

                    else if (state.Text == "退回")
                        productinfo.set(firstclass.Text, secondclass.Text, textBox1.Text + id.Text, name.Text, state.Text, inprice.Text, outprice.Text, reason.Text, "", num.Text, dateTimePicker1.Text);
                    else
                        productinfo.set(firstclass.Text, secondclass.Text, textBox1.Text + id.Text, name.Text, state.Text, inprice.Text, outprice.Text, "", "", num.Text, dateTimePicker1.Text);
                    try
                    {
                        productinfo.upload();
                        clc();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "写入商品信息错误");
                    }
                }
                else if (state.Text == "售出" && season.Text == "")
                {
                    Message msg = new Message("");
                    msg.setmessage("请检查是否漏填售出季度！");
                }
                else
                {
                    Message msg = new Message("");
                    msg.setmessage("请检查是否有消息漏填！");
                }
            }
        }
        //根据时间来生成季度
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            monthtoseason();
        }





        //以下为UI层代码，与动画效果有关
        //以下四段实现窗口拖动效果
        private void pictureBox9_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;

            Point cur = this.PointToScreen(e.Location);
            offset = new Point(cur.X - this.Left, cur.Y - this.Top);
        }
        private void pictureBox10_MouseDown(object sender, MouseEventArgs e)
        {

        }
        private void pictureBox10_MouseMove(object sender, MouseEventArgs e)
        {

        }
        private void pictureBox9_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;
            Point cur = MousePosition;
            this.Location = new Point(cur.X - offset.X, cur.Y - offset.Y);
        }
        //以下两段实现窗口拖动效果
        private void Newproductinfo_MouseDown(object sender, MouseEventArgs e)
        {

        }
        private void Newproductinfo_MouseMove(object sender, MouseEventArgs e)
        {

        }
        //以下两段实现按钮的动画效果
        private void cancelbutton_MouseEnter(object sender, EventArgs e)
        {
            cancelbutton.BackgroundImage = Properties.Resources.button3;
        }
        private void cancelbutton_MouseLeave(object sender, EventArgs e)
        {
            cancelbutton.BackgroundImage = Properties.Resources.button2;
        }

        //此时间控件实现窗口的渐变消失效果
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
                this.Opacity = this.Opacity - 0.03;
            else
            {
                timer1.Enabled = false;
                this.Close();
            }
        }
        //此时间控件实现窗口的渐变出现效果
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity + 0.03;
            if (this.Opacity == 1)
                timer2.Enabled = false;
        }
    }
}
