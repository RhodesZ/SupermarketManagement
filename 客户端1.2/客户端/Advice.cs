using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;

namespace 客户端
{
    public partial class Advice : Form
    {
        public static string IP = "59.66.135.77";//默认的服务器IP
        public static string connstring = String.Format("Data Source={0};Initial Catalog=ProductManagement;User ID=Rhodes;Password=123456", IP);//默认的连接字符串
        private Point offset;
        public Advice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From=new MailAddress("",Login.id);
                mail.To.Add("445368386@qq.com");
                mail.Subject = "意见";
                mail.BodyEncoding = Encoding.Default;
                mail.Priority = MailPriority.High;
                mail.Body = "test10";
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient("smtp.qq.com", 25);
                smtp.UseDefaultCredentials = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new System.Net.NetworkCredential(""," ");
                smtp.Timeout = 10000;
                smtp.Send(mail);
                Message msg = new Message("");
                msg.setmessage("发送成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Advice_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            timer1.Enabled = true;
        }


        private void cancelbutton_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn1 = new SqlConnection(connstring);
            String InsertNewComm = string.Format("INSERT INTO advice(name,subject,content) VALUES('{0}','{1}','{2}')", Login.id,subject.Text,richTextBox1.Text);
            SqlCommand Comm = new SqlCommand(InsertNewComm, sqlconn1);
            try
            {
                sqlconn1.Open();
                if(Comm.ExecuteNonQuery()!=0)
                {
                    Message msg=new Message("");
                    msg.setmessage("意见上传成功，开发者将会尽快处理，谢谢！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "写入注册信息错误");
            }
        }





        //以下为UI层代码，与各种动画有关
        //此时间空间实现了窗口的动态加载效果
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity + 0.03;
            if (this.Opacity == 1)
            {
                timer1.Enabled = false;
            }
        }
        //此时间空间实现了窗口的渐变消失效果
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
        //以下四段实现窗口的拖动
        private void Advice_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;
            Point cur = this.PointToScreen(e.Location);
            offset = new Point(cur.X - this.Left, cur.Y - this.Top);
        }
        private void Advice_MouseMove(object sender, MouseEventArgs e)
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
        //以下两段实现了鼠标悬停在取消按钮上的动画
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
