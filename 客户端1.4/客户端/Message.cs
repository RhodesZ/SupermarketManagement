using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//自带信息弹窗与软件整体界面风格不统一而且不美观，使用此窗体替代系统弹窗的简单功能

namespace 客户端
{
   
    public partial class Message : Form
    { 
        public static string str1;
        public static int n=0;
        private Point offset;
        public Message(string str)
        {
            InitializeComponent();
            str1=str;
        }

        //此函数实现此窗口的随机移动方向
        public void randommove(int n)
        {   
            if(n==0)
                this.Location = new Point(this.Location.X + 5, this.Location.Y); 
            else if(n==1)
                this.Location = new Point(this.Location.X - 5, this.Location.Y);
            else if(n==2)
                this.Location = new Point(this.Location.X, this.Location.Y+5);
            else
                this.Location = new Point(this.Location.X, this.Location.Y-5);
        }

        //设定消息函数
        public void setmessage(string str)
        {
            str1 = str;
            this.Show();
        }

        private void Message_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            timer2.Enabled = true;
            label1.Text = str1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Random random=new Random();
            n=random.Next(0,4);
        }




        //以下为UI层代码，与动画效果有关
        //以下两段为悬浮关闭按钮时的动画效果
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Image = Properties.Resources.button7;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Image = Properties.Resources.button6;
        }
        //此时间控件实现消息弹窗的渐变消失动画
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity = this.Opacity - 0.05;
                randommove(n);
            }
            else
            {
                timer1.Enabled = false;
                this.Close();
            }
        }
        //此时间控件实现消息弹窗的渐变加载动画
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity = this.Opacity + 0.05;
            }
            else
                timer2.Enabled = false;
        }
        //以下四段实现窗口的拖动
        private void Message_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;
            Point cur = this.PointToScreen(e.Location);
            offset = new Point(cur.X - this.Left, cur.Y - this.Top);
        }
        private void Message_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;
            Point cur = MousePosition;
            this.Location = new Point(cur.X - offset.X, cur.Y - offset.Y);
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;

            Point cur = this.PointToScreen(e.Location);
            offset = new Point(cur.X - this.Left, cur.Y - this.Top);
        }
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;
            Point cur = MousePosition;
            this.Location = new Point(cur.X - offset.X, cur.Y - offset.Y);
        }
    }
}
