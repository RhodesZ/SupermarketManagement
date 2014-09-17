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
    public partial class Setinnercode : Form
    {
        const string IP = "59.66.135.77";//默认的服务器IP
        public static string connstring = String.Format("Data Source={0};Initial Catalog=ProductManagement;User ID=Rhodes;Password=123456", IP);//默认的连接字符串
        private Point offset;
        public Setinnercode()
        {
            InitializeComponent();
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            string sql = string.Format("UPDATE innercode SET code='{0}' where id=1", code.Text);
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand command = new SqlCommand(sql, conn);
            conn.Open();
            if(command.ExecuteNonQuery()!=0)
            {
                Message msg = new Message("");
                msg.setmessage("内部代码修改成功！");
            }
            code.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity + 0.03;
            if (this.Opacity == 1)
            {
                timer1.Enabled = false;
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

        private void Setinnercode_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            timer1.Enabled = true;
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void cancelbutton_MouseEnter(object sender, EventArgs e)
        {
            cancelbutton.BackgroundImage = Properties.Resources.button3;
        }
        private void cancelbutton_MouseLeave(object sender, EventArgs e)
        {
            cancelbutton.BackgroundImage = Properties.Resources.button2;
        }

        private void Setinnercode_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;
            Point cur = this.PointToScreen(e.Location);
            offset = new Point(cur.X - this.Left, cur.Y - this.Top);
        }

        private void Setinnercode_MouseMove(object sender, MouseEventArgs e)
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
    }
}
