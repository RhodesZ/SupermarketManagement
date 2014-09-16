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
using CrystalDecisions.Shared;
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports.Engine;

namespace 客户端
{
    public partial class Analyze : Form
    {
        public static string IP = "59.66.135.77";//默认的服务器IP
        public static string connstring = String.Format("Data Source={0};Initial Catalog=ProductManagement;User ID=Rhodes;Password=123456", IP);//默认的连接字符串
        private Point offset;
        public int temp = 0;
        public ArrayList list = new ArrayList();

        //该类为生成曲线图所需数据的几何
        public class salescurve
        {
            private string season;
            private int num;
            public salescurve(string _season,int _num)
            {
                season = _season;
                num = _num;
            }
            public string getseason()
            {
                return season;
            }
            public int getnum()
            {
                return num;
            }
        };
        public Analyze()
        {
            InitializeComponent();
        }

        //此函数用以生成查找字符串
        public string sortcommand()
        {
            string command = "";
            if(mode.Text=="销售量最大的商品")
                command ="num desc ";
            if (mode.Text == "进价最高的商品")
                command = "inprice desc";
            if (mode.Text == "售价最高的商品")
                command = "outprice desc";
            if (mode.Text == "利润最高的商品")
                command = "(outprice-inprice) desc";
            if (mode.Text == "利润率最高的商品")
                command = "((outprice-inprice)/inprice) desc";
            return command;
        }

        //此函数用以生成搜索字符串
        public string searchcommannd()
        {
            string command = "";
            if (firstclass.Text != "")
                command = command + "firstclass=\'" + firstclass.Text + "\' and ";
            if (secondclass.Text != "")
                command = command + "secondclass=\'" + season.Text + "\' and ";
            if (season.Text != "")
                command = command + "season=\'" + season.Text + "\' and ";
            if (command != "")
            {
                command = command.Remove(command.LastIndexOf("and"), 3);
            }
            return command;
        }

        //以下两个函数用于自动为水晶报表认证，免去每次弹窗要求登录的麻烦
        private void ConfigCrystalReports()
        {

            ConnectionInfo ConnectionInfo = new ConnectionInfo();
            ConnectionInfo.ServerName = "RHODES-PC";

            ConnectionInfo.DatabaseName = "ProductManagement";

            ConnectionInfo.UserID = "Rhodes";

            ConnectionInfo.Password = "123456";

            SetDbLoginForReport(ConnectionInfo);

        }
        private void SetDbLoginForReport(ConnectionInfo ConnectionInfo)
        {

            TableLogOnInfos tableLogOnInfos = crystalReportViewer1.LogOnInfo;

            foreach (TableLogOnInfo tableLogOnInfo in tableLogOnInfos)
            {

                tableLogOnInfo.ConnectionInfo = ConnectionInfo;

            }

        }    

        private void Analyze_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            timer1.Enabled = true;
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn1 = new SqlConnection(connstring);
            sqlconn1.Open();
            String ClearComm = string.Format("DELETE FROM temp");
            SqlCommand comm = new SqlCommand(ClearComm, sqlconn1);
            comm.ExecuteNonQuery(); 
            timer2.Enabled = true;
        }

        //选择第一分类时第二分类的加载
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
            else
            {
                secondclass.Items.Clear();
            }
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            if(mode.Text=="")
            {
                Message msg = new Message("");
                msg.setmessage("请选择数据内容！");
            }
            else
            {
                if (searchcommannd() != "" && sortcommand() != "")
                {
                    dataGridView1.Rows.Clear();
                    SqlConnection sqlconn1 = new SqlConnection(connstring);
                    sqlconn1.Open();
                    String SearchComm = string.Format("SELECT * FROM productinfo WHERE " + searchcommannd() + " ORDER BY " + sortcommand());
                    SqlCommand comm = new SqlCommand(SearchComm, sqlconn1);
                    SqlDataReader sdr = comm.ExecuteReader();
                    if (sdr.HasRows)
                    {
                        while (sdr.Read())
                        {
                            int index = this.dataGridView1.Rows.Add();
                            for (int i = 0; i < 12; i++)
                            {
                                this.dataGridView1.Rows[index].Cells[i].Value = sdr[i];
                            }
                            break;
                        }

                    }
                    else
                    {
                        Message msg = new Message("");
                        msg.setmessage("该商品不存在!");
                    }
                    sdr.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn1 = new SqlConnection(connstring);
            sqlconn1.Open();
            String ClearComm = string.Format("DELETE FROM temp");
            SqlCommand comm = new SqlCommand(ClearComm, sqlconn1);
            String SearchComm="";
            comm.ExecuteNonQuery();
            if(firstclass.Text=="")
            {
                Message msg = new Message("");
                msg.setmessage("请选择第一分类以生成销售曲线图!");
            }
            else
            {
                season.Text = "";
                mode.Text = "";
                if (temp == 0)
                {
                    timer3.Enabled = true;
                    crystalReportViewer1.Visible = true;
                    this.Size = new Size(this.Size.Width, 803);
                    this.Location = new Point(this.Location.X, this.Location.Y - 170);
                }
                if(secondclass.Text=="")
                    SearchComm = string.Format("SELECT * FROM productinfo WHERE firstclass='{0}'and state='售出'",firstclass.Text);
                    //SearchComm = string.Format("SELECT * FROM productinfo WHERE firstclass= \'"+firstclass.Text+"\' and state='售出'");
                else
                    SearchComm = string.Format("SELECT * FROM productinfo WHERE firstclass='{0}' and secondclass='{1}' and state='售出'",firstclass.Text,secondclass.Text);
                    //SearchComm = string.Format("SELECT * FROM productinfo WHERE firstclass= \'"+firstclass.Text+"\' and secondclass= \'"+secondclass.Text +"\' and state='售出'");
                SqlCommand comm1=new SqlCommand(SearchComm,sqlconn1);
                SqlDataReader sdr = comm1.ExecuteReader();

                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        salescurve tempdata = new salescurve(sdr[7].ToString(), (int)sdr[9]);
                        list.Add(tempdata);
                    }
                }
                else
                {
                    Message msg = new Message("");
                    msg.setmessage("无足够信息生成折线图!");
                }
                sdr.Close();
                foreach(salescurve salesdata in list)
                {
                    String InsertNewComm = string.Format("INSERT INTO temp(season,num) VALUES('{0}','{1}')",salesdata.getseason(),salesdata.getnum());
                    SqlCommand comm2 = new SqlCommand(InsertNewComm, sqlconn1);
                    comm2.ExecuteNonQuery();
                }
                crystalReportViewer1.RefreshReport();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (temp == 1)
            {
                timer3.Enabled = true;
                crystalReportViewer1.Visible = false;
                this.Size = new Size(this.Size.Width, 496);
                this.Location = new Point(this.Location.X, this.Location.Y + 170);
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ConfigCrystalReports();    
        }






        //以下为UI层代码，与动画效果有关
        //以下四段实现窗口的拖动效果
        private void Analyze_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;

            Point cur = this.PointToScreen(e.Location);
            offset = new Point(cur.X - this.Left, cur.Y - this.Top);
        }
        private void Analyze_MouseMove(object sender, MouseEventArgs e)
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
        //以下两段实现了鼠标移入移出calcelbutton的动画效果
        private void cancelbutton_MouseEnter(object sender, EventArgs e)
        {
            cancelbutton.BackgroundImage = Properties.Resources.button3;
        }
        private void cancelbutton_MouseLeave(object sender, EventArgs e)
        {
            cancelbutton.BackgroundImage = Properties.Resources.button2;
        }
        //以下两段实现了鼠标移入移出button2的动画效果
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.button3;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.button2;
        }
        //此时间控件实现了窗口加载的渐变效果
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity + 0.03;
            if (this.Opacity == 1)
                timer1.Enabled = false;
        }
        //此时间控件实现了窗口的渐变消失效果
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
        //此时间控件实现数据显示框的渐变加载与消失效果
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (temp == 0)
            {
                if (pictureBox6.Location.Y < 1046)
                {
                    pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y + 5);
                    dataGridView1.Location = new Point(dataGridView1.Location.X, dataGridView1.Location.Y + 5);
                }
                else
                {
                    timer3.Enabled = false;
                    temp = 1;
                }
            }
            if (temp == 1)
            {
                if (pictureBox6.Location.Y > 245)
                {
                    pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y - 10);
                    dataGridView1.Location = new Point(dataGridView1.Location.X, dataGridView1.Location.Y - 10);
                }
                else
                {
                    timer3.Enabled = false;
                    temp = 0;
                }
            }
        }
    }
}
