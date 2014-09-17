using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace 客户端
{
    public partial class Statement : Form
    {
        public Statement()
        {
            InitializeComponent();
        }

        private void statement_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            timer1.Enabled = true;
        }




        //以下为UI代码，与动画效果有关
        //此时间控件实现窗口的渐变加载效果
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity + 0.03;
            if (this.Opacity == 1)
            {
                timer1.Enabled = false;
                Thread.Sleep(500);
                timer2.Enabled = true;
            }
                
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
    }
}
