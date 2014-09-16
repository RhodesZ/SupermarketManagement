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

    public partial class Mainfunction : Form
    {
        private Point offset;
        public Mainfunction()
        {
            InitializeComponent();
        }
        const string IP = "59.66.135.77";//默认的服务器IP
        public static string connstring = String.Format("Data Source={0};Initial Catalog=ProductManagement;User ID=Rhodes;Password=123456", IP);//默认的连接字符串
        public static int temp = 0,temp1=0,temp2=0;

        //此函数用于哈希算法加密与解密
        public static string GetSHA1(string pwdata_s)
        {
            System.Security.Cryptography.SHA1CryptoServiceProvider osha1 = new System.Security.Cryptography.SHA1CryptoServiceProvider();
            ASCIIEncoding enc = new ASCIIEncoding();
            byte[] pwdata_b = enc.GetBytes(pwdata_s);//password(string) to byte[]
            byte[] pwsha1_b = osha1.ComputeHash(pwdata_b);//ToHash
            string pwsha1_s = BitConverter.ToString(pwsha1_b).Replace("-", "");//hash to string
            return pwsha1_s;
        }

        //此函数用于验证密码；
        private bool ConfirmPassword()//返回0表示验证错误，返回非0
        {
            bool state = true;
            String pw_sha1 = GetSHA1(code.Text);
            String ID_text = Login.id;

            string sql = string.Format("select * from userinfo where name='{0}' and password='{1}'", ID_text, pw_sha1);
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand command = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                SqlDataReader data = command.ExecuteReader();
                if (data.Read())
                {
                    state = true;
                }
                else
                    state = false;
                data.Close();
                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message, "确认密码时发生错误");
                state = false;
            }
            return state;
        }

        private void Mainfunction_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            timer1.Enabled = true;
            timer2.Enabled = true;
            label1.Text = DateTime.Now.ToString("t");
            label6.Text = "Hello," + Login.id.ToString();
            SqlConnection sqlconn1 = new SqlConnection(connstring);
            sqlconn1.Open();
            //通过左上角信号与字符串来表示是否已经连接数据库
            if (sqlconn1.State == ConnectionState.Open)
            {
                sygnal.Image = Properties.Resources.信号满;
                pictureBox1.Image = Properties.Resources.已连接;
            }
            else
            {
                sygnal.Image = Properties.Resources.信号空;
                pictureBox1.Image = Properties.Resources.未连接;
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer3.Enabled = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Newproductinfo frm1 = new Newproductinfo();
            frm1.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Searchproductinfo frm2 = new Searchproductinfo();
            frm2.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Conditionalsearch frm3 = new Conditionalsearch();
            frm3.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Analyze frm4 = new Analyze();
            frm4.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            timer4.Enabled = true;
            pictureBox7.Image = Properties.Resources.头像逆;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            code.Visible = true;
            textBox1.Visible = true;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (ConfirmPassword() == true)
            {
                string sql = string.Format("UPDATE userinfo SET password='{0}' where name='{1}' and password='{2}'", GetSHA1(textBox1.Text), Login.id, GetSHA1(code.Text));
                SqlConnection conn = new SqlConnection(connstring);
                SqlCommand command = new SqlCommand(sql, conn);
                conn.Open();
                command.ExecuteNonQuery();
                code.Clear();
                textBox1.Clear();
                Message msg = new Message("");
                msg.setmessage("密码修改成功");
                pictureBox7.Image = Properties.Resources.头像顺;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                code.Visible = false;
                textBox1.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                timer4.Enabled = true;
            }
            else
            {
                Message msg = new Message("");
                msg.setmessage("原密码输入错误，请确认后重输");
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.头像顺;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            code.Visible = false;
            textBox1.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            timer4.Enabled = true;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if(temp1==0)
            {
                pictureBox15.Visible = true;
                flowLayoutPanel1.Visible = true;
                flowLayoutPanel1.BringToFront();
                temp1 = 1;
            }
            else
            {
                pictureBox15.Visible = false;
                flowLayoutPanel1.Visible = false;
                temp1 = 0;
            }
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            Userinfo frm6 = new Userinfo();
            frm6.Show();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            if (temp2 == 0)
            {
                pictureBox15.Visible = true;
                flowLayoutPanel2.Visible = true;
                flowLayoutPanel2.BringToFront();
                temp2 = 1;
            }
            else
            {
                pictureBox15.Visible = false;
                flowLayoutPanel2.Visible = false;
                temp2 = 0;
            }
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(text.Text);
            text.Clear();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            int temp = checkedListBox1.SelectedIndex;
            if (temp >= 0)
                checkedListBox1.Items.RemoveAt(temp);
            else
            {
                Message msg = new Message("");
                msg.setmessage("请先选择需要删除的条目");
            }
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            Advice frm8 = new Advice();
            frm8.Show();
        }






        //以下为UI层代码与动画效果有关
        //此时间控件用于加载时间
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("t");
        }
        //此时间控件实现窗口的渐变加载效果
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity + 0.03;
            if (this.Opacity == 1)
            {
                timer2.Enabled = false;
                SqlConnection sqlconn1 = new SqlConnection(connstring);
                sqlconn1.Open();
                String SearchComm = string.Format("SELECT * FROM userinfo WHERE name= \'" + Login.id + "\'");
                SqlCommand comm = new SqlCommand(SearchComm, sqlconn1);
                SqlDataReader sdr = comm.ExecuteReader();
                while (sdr.Read())
                {
                    if (sdr[2] == null || sdr[2].ToString() == "")
                    {
                        Message msg = new Message("");
                        msg.setmessage("尚未登记具体信息，请进入人员信息功能完善信息");
                    }
                }
            }
                
        }
        //此时间 实现窗口的渐变消失效果
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
                this.Opacity = this.Opacity - 0.03;
            else
            {
                timer1.Enabled = false;
                timer3.Enabled = false;
                this.Close();
            }
        }
        //时间控件实现更改密码时的动画效果
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (temp == 0)
            {
                if (pictureBox7.Location.X > 0)
                {
                    pictureBox7.Location = new Point(pictureBox7.Location.X - 20, pictureBox7.Location.Y);
                    pictureBox8.Size = new Size(pictureBox8.Size.Width + 20, pictureBox8.Size.Height);
                    pictureBox11.Size = new Size(pictureBox11.Size.Width + 20, pictureBox11.Size.Height);
                    textBox1.Size = new Size(textBox1.Size.Width + 20, textBox1.Size.Height);
                    code.Size = new Size(code.Size.Width + 20, code.Size.Height);
                }
                else
                {
                    pictureBox7.Image = Properties.Resources.头像;
                    pictureBox12.Visible = true;
                    pictureBox13.Visible = true;
                    timer4.Enabled = false;
                    temp = 1;
                }
            }
            else
            {
                if (pictureBox7.Location.X < 155)
                {
                    pictureBox7.Location = new Point(pictureBox7.Location.X + 10, pictureBox7.Location.Y);
                    pictureBox8.Size = new Size(pictureBox8.Size.Width - 10, pictureBox8.Size.Height);
                    pictureBox11.Size = new Size(pictureBox11.Size.Width - 10, pictureBox11.Size.Height);
                    textBox1.Size = new Size(textBox1.Size.Width - 10, textBox1.Size.Height);
                    code.Size = new Size(code.Size.Width - 10, code.Size.Height);
                }
                else
                {
                    pictureBox7.Image = Properties.Resources.头像;
                    timer4.Enabled = false;
                    temp = 0;
                }
            }
        }
        //以下两段实现窗口的拖动效果
        private void Mainfunction_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;
            Point cur = this.PointToScreen(e.Location);
            offset = new Point(cur.X - this.Left, cur.Y - this.Top);
        }
        private void Mainfunction_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;
            Point cur = MousePosition;
            this.Location = new Point(cur.X - offset.X, cur.Y - offset.Y);
        }
        //以下10段函数实现换肤功能
        private void pictureBox16_DoubleClick(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BG2;
        }
        private void pictureBox17_DoubleClick(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BG11;
        }
        private void pictureBox18_DoubleClick(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BG3;
        }
        private void pictureBox19_DoubleClick(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BG4;
        }
        private void pictureBox20_DoubleClick(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BG5;
        }
        private void pictureBox21_DoubleClick(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BG6;
        }
        private void pictureBox22_DoubleClick(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BG7;
        }
        private void pictureBox23_DoubleClick(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BG8;
        }
        private void pictureBox24_DoubleClick(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BG9;
        }
        private void pictureBox25_DoubleClick(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.BG1;
        }
    }
}
