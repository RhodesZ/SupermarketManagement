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
    public partial class Login : Form
    {
        //连接服务器的基本信息
        const string IP = "59.66.135.77";//默认的服务器IP
        public static string connstring = String.Format("Data Source={0};Initial Catalog=ProductManagement;User ID=Rhodes;Password=123456", IP);//默认的连接字符串
        private Point offset;
        const string Code = "123456";//可以修改为自己想要的Code
        int temp = 0;
        public static string id="";
        public static int permession = 0;
        public Login()
        {
            InitializeComponent();
        }
        public static string GetSHA1(string pwdata_s)
        {
            System.Security.Cryptography.SHA1CryptoServiceProvider osha1 = new System.Security.Cryptography.SHA1CryptoServiceProvider();
            ASCIIEncoding enc = new ASCIIEncoding();
            byte[] pwdata_b = enc.GetBytes(pwdata_s);//password(string) to byte[]
            byte[] pwsha1_b = osha1.ComputeHash(pwdata_b);//ToHash
            string pwsha1_s = BitConverter.ToString(pwsha1_b).Replace("-", "");//hash to string
            return pwsha1_s;
        }

        //验证密码的函数
         private  bool ConfirmPassword()//返回0表示验证错误，返回非0
        {
            bool state = true;
            String pw_sha1 = GetSHA1(password.Text);
            String ID_text = this.account.Text;

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

         //检查命名是否科学是否已经存在
         private int CheckName(string name)
         {
             int state = 0;
             //首先判断是否科学;
             int len = name.Length;
             if (len >= 2 && len <= 20)
             {
                 SqlConnection conn = new SqlConnection(connstring);
                 string sql = string.Format("select name from userinfo where name='{0}'", name);
                 //创建Command对象
                 SqlCommand command = new SqlCommand(sql, conn);
                 conn.Open();
                 String s4 = Convert.ToString(command.ExecuteScalar());
                 if (String.Compare("", s4) != 0)
                 {
                     Message msg = new Message("");
                     msg.setmessage("很抱歉，此用户名已存在");
                     state = 0;
                     return state;
                 }
                 else
                 {
                     state = 1;
                 }
             }
             else
             {
                 Message msg = new Message("");
                 msg.setmessage("用户名长度不符合规范");
                 return state;
             }
             return state;
         }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            timer3.Enabled = true;
        }

        private void regbutton_Click(object sender, EventArgs e)
        {
            if (code.Text == Code)
            {
                if (CheckName(account.Text) == 0)
                {
                    account.Clear();
                    password.Clear();
                    return;
                }
                else
                {
                    int state = 0;
                    SqlConnection Reg = new SqlConnection(connstring);
                    String InsertNewComm = string.Format("INSERT INTO userinfo(name,password) VALUES('{0}','{1}')", account.Text, Login.GetSHA1(password.Text));
                    SqlCommand RegComm = new SqlCommand(InsertNewComm, Reg);
                    try
                    {
                        Reg.Open();
                        RegComm.ExecuteNonQuery();
                        state = 1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "写入注册信息错误");
                    }
                    if (state == 1)
                    {
                        Message msg = new Message("");
                        msg.setmessage("恭喜你，注册成功，请登陆。");
                        timer4.Enabled = true;

                    }
                }
            }
            else
            {
                Message msg = new Message("");
                msg.setmessage("内部代码输入错误");
            }
                
            
        }

        //启动注册控件加载动画
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer4.Enabled = true;
        }

        private void quitbutton_Click_1(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }



        //以下为UI层代码，与动画效果有关
        //以下两段实现鼠标悬停的动态效果
        private void quitbutton_MouseEnter_1(object sender, EventArgs e)
        {
            quitbutton.BackgroundImage = Properties.Resources.button3;
        }
        private void quitbutton_MouseLeave_1(object sender, EventArgs e)
        {
            quitbutton.BackgroundImage = Properties.Resources.button2;
        }
        //以下四段实现拖动窗口
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
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;
            Point cur = this.PointToScreen(e.Location);
            offset = new Point(cur.X - this.Left, cur.Y - this.Top);
        }
        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;
            Point cur = MousePosition;
            this.Location = new Point(cur.X - offset.X, cur.Y - offset.Y);
        }
        //此时间控件为加载动画
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox7.Location.Y < -5)
                pictureBox7.Location = new Point(pictureBox7.Location.X, pictureBox7.Location.Y + 3);
            else
            {
                timer6.Enabled = true;
                timer1.Enabled = false;
            }
        }
        //窗口渐变消失效果
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
        //窗口的渐变加载效果
        private void timer3_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity + 0.03;
            if (this.Opacity == 1)
                timer3.Enabled = false;
        }
        //此时间控件为注册时按钮与内部验证码加载动画
        private void timer4_Tick(object sender, EventArgs e)
        {

            if (temp == 0)
            {
                if (regbutton.Location.X > 390)
                {
                    regbutton.Location = new Point(regbutton.Location.X - 5, regbutton.Location.Y);
                    pictureBox8.Location = new Point(pictureBox8.Location.X - 5, pictureBox8.Location.Y);
                    pictureBox9.Location = new Point(pictureBox9.Location.X - 5, pictureBox9.Location.Y);
                    code.Location = new Point(code.Location.X - 5, code.Location.Y);
                }

                else
                {
                    timer4.Enabled = false;
                    temp = 1;
                }
            }
            if (temp == 1)
            {
                if (regbutton.Location.X < 600)
                {
                    regbutton.Location = new Point(regbutton.Location.X + 10, regbutton.Location.Y);
                    pictureBox8.Location = new Point(pictureBox8.Location.X + 10, pictureBox8.Location.Y);
                    pictureBox9.Location = new Point(pictureBox9.Location.X + 10, pictureBox9.Location.Y);
                    code.Location = new Point(code.Location.X + 10, code.Location.Y);
                }
                else
                {
                    timer4.Enabled = false;
                    temp = 0;
                }
            }

        }
        //此时间控件为加载动画
        private void timer5_Tick(object sender, EventArgs e)
        {
            if (pictureBox7.Location.Y > -230)
                pictureBox7.Location = new Point(pictureBox7.Location.X, pictureBox7.Location.Y - 3);
            else
            {
                timer5.Enabled = false;
            }
        }
        //此时间控件保证动画完整播放并验证密码
        private void timer6_Tick(object sender, EventArgs e)
        {
            if (ConfirmPassword())
            {
                id = account.Text;
                SqlConnection sqlconn1 = new SqlConnection(connstring);
                sqlconn1.Open();
                String SearchComm = string.Format("SELECT * FROM userinfo WHERE name='{0}'",id);
                SqlCommand comm = new SqlCommand(SearchComm, sqlconn1);
                SqlDataReader sdr = comm.ExecuteReader();
                    while (sdr.Read())
                    {
                        permession = (int)sdr[5];
                    }
                timer6.Enabled = false;
                timer7.Enabled = true;
            }

            else
            {
                Message msg = new Message("");
                msg.setmessage("用户名密码输入错误，请重新输入一下吧！");
                timer6.Enabled = false;
                timer5.Enabled = true;

            }
        }
        //此时间控件实现成功登陆后的渐变消失效果
        private void timer7_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
                this.Opacity = this.Opacity - 0.03;
            else
            {
                timer7.Enabled = false;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
