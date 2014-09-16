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

namespace 客户端
{
    public partial class Userinfo : Form
    {
        const string IP = "59.66.135.77";//默认的服务器IP
        public static string connstring = String.Format("Data Source={0};Initial Catalog=ProductManagement;User ID=Rhodes;Password=123456", IP);//默认的连接字符串
        private Point offset;
        public static string GetSHA1(string pwdata_s)
        {
            System.Security.Cryptography.SHA1CryptoServiceProvider osha1 = new System.Security.Cryptography.SHA1CryptoServiceProvider();
            ASCIIEncoding enc = new ASCIIEncoding();
            byte[] pwdata_b = enc.GetBytes(pwdata_s);//password(string) to byte[]
            byte[] pwsha1_b = osha1.ComputeHash(pwdata_b);//ToHash
            string pwsha1_s = BitConverter.ToString(pwsha1_b).Replace("-", "");//hash to string
            return pwsha1_s;
        }
        public Userinfo()
        {
            InitializeComponent();
        }

        //验证密码的函数
        private bool ConfirmPassword()//返回0表示验证错误，返回非0
        {
            bool state = true;
            String pw_sha1 = GetSHA1(password.Text);
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
        private void Userinfo_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            timer1.Enabled = true;
        }
        private void submitbutton_Click(object sender, EventArgs e)
        {
            if(ConfirmPassword()==false)
            {
                Message msg = new Message("");
                msg.setmessage("密码输入错误，请确认后再输");
            }
            else
            {
                if (sex.Text == "" || department.Text == "" || position.Text == "")
                {
                    Message msg = new Message("");
                    msg.setmessage("请检查是否有未输入的信息");
                }
                else
                {
                    SqlConnection sqlconn1 = new SqlConnection(connstring);
                    String comm1 = string.Format("UPDATE userinfo SET sex=\'" + sex.Text + "\',department=\'"+department.Text +"\',position=\'"+position.Text+"\' WHERE name=\'" + Login.id + "\'");
                    SqlCommand command = new SqlCommand(comm1, sqlconn1);
                    sqlconn1.Open();
                    if(command.ExecuteNonQuery()!=0)
                    {
                        Message msg = new Message("");
                        msg.setmessage("录入成功");
                    }
                }
            }
        }
        private void cancelbutton_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }





        //以下为UI层代码，与各种动画有关
        //以下四段实现窗口的拖动
        private void Userinfo_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;
            Point cur = this.PointToScreen(e.Location);
            offset = new Point(cur.X - this.Left, cur.Y - this.Top);
        }
        private void Userinfo_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;
            Point cur = MousePosition;
            this.Location = new Point(cur.X - offset.X, cur.Y - offset.Y);
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;
            Point cur = this.PointToScreen(e.Location);
            offset = new Point(cur.X - this.Left, cur.Y - this.Top);
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;
            Point cur = MousePosition;
            this.Location = new Point(cur.X - offset.X, cur.Y - offset.Y);
        }
        //此时间控件实现窗口的动态加载效果
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity + 0.03;
            if (this.Opacity == 1)
                timer1.Enabled = false;
        }
        //此时间控件实现窗口的渐变消失效果
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
        //以下两段实现鼠标悬停的效果
        private void cancelbutton_MouseEnter(object sender, EventArgs e)
        {
            cancelbutton.BackgroundImage = Properties.Resources.button3;
        }
        private void cancelbutton_MouseLeave(object sender, EventArgs e)
        {
            cancelbutton.BackgroundImage = Properties.Resources.button2;
        }
    }
}
