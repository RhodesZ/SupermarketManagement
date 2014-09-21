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
using 类库;

namespace 客户端
{
    public partial class Conditionalsearch : Form
    {
        public static string IP = "59.66.135.77";//默认的服务器IP
        public static string connstring = String.Format("Data Source={0};Initial Catalog=ProductManagement;User ID=Rhodes;Password=123456", IP);//默认的连接字符串
        private Point offset;
        private List<GeneralProductInfo> data=new List<GeneralProductInfo>();
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
            StreamWriter sw =new StreamWriter(myStream, System.Text.Encoding.GetEncoding(-0));
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


        public Conditionalsearch()
        {
            InitializeComponent();
        }

        //此函数实现数据库搜索字符串的生成
        public string searchcommannd()
        {
            string command = "";
            if (firstclass.Text != "")
                command = command + "firstclass=\'" + firstclass.Text;
            if (checkBox1.Checked == true)
                command = command + "\' or  ";
            else if (checkBox1.Checked == false)
                command = command + "\' and ";
            if (secondclass.Text != "")
                command = command + "secondclass=\'" + secondclass.Text;
            if (checkBox2.Checked == true)
                command = command + "\' or  ";
            else if (checkBox2.Checked == false && checkBox2.Enabled==true)
                command = command + "\' and ";
            if (state.Text != "")
                command = command + "state=\'" + state.Text;
            if (checkBox3.Checked == true)
                command = command + "\' or  ";
            else if (checkBox3.Checked == false && checkBox3.Enabled == true)
                command = command + "\' and ";
            if (dateTimePicker1.Text != " ")
                command = command + "date=\'" + dateTimePicker1.Text + "\' and ";
            if (command != "")
            {
                command = command.Remove(command.LastIndexOf("\'")+1,4);
            }
            return command;
        }

        //选择第一排序顺序的时候第二排序顺序的加载
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "按时间从早到晚" || comboBox1.Text == "按时间从晚到早")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("按数量从少到多");
                comboBox2.Items.Add("按数量从多到少");
                comboBox2.Items.Add("按出售价格从低到高");
                comboBox2.Items.Add("按出售价格从高到低");
                comboBox2.Items.Add("");
            }
            else if (comboBox1.Text == "按数量从少到多" || comboBox1.Text == "按数量从多到少")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("按时间从早到晚");
                comboBox2.Items.Add("按时间从晚到早");
                comboBox2.Items.Add("按出售价格从低到高");
                comboBox2.Items.Add("按出售价格从高到低");
                comboBox2.Items.Add("");
            }
            else if (comboBox1.Text == "按出售价格从低到高" || comboBox1.Text == "按出售价格从高到低")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("按时间从早到晚");
                comboBox2.Items.Add("按时间从晚到早");
                comboBox2.Items.Add("按数量从少到多");
                comboBox2.Items.Add("按数量从多到少");
                comboBox2.Items.Add("");
            }
        }

        //选择第一分类的时候第二分类的加载
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
            checkBox1.Enabled = true;
            checkBox1.Checked = false;
        }

        //选择第二分类的时候“与”“或”选择盒的激活
        private void secondclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBox2.Enabled = true;
            checkBox2.Checked = false;
        }

        //选择状态的时候“与”“或”选择盒的激活
        private void state_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBox3.Enabled = true;
            checkBox3.Checked = false;
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            if(searchcommannd()=="")
            {
                Message msg = new Message("");
                msg.setmessage("请至少选择一条搜索条件");
            }
            if(comboBox1.Text=="")
            {
                Message msg = new Message("");
                msg.setmessage("请至少选择一项排序顺序");
            }
            if (searchcommannd() != "" && comboBox1.Text != "")
            {
                dataGridView1.Rows.Clear();
                SqlConnection sqlconn1 = new SqlConnection(connstring);
                sqlconn1.Open();
                String SearchComm = string.Format("SELECT * FROM productinfo WHERE "+searchcommannd());
                SqlCommand comm = new SqlCommand(SearchComm, sqlconn1);
                SqlDataReader sdr = comm.ExecuteReader();
                if(sdr.HasRows)
                {
                    while(sdr.Read())
                    {
                        GeneralProductInfo temp=new GeneralProductInfo();
                        temp.set(sdr[0].ToString(), sdr[1].ToString(), sdr[2].ToString(), sdr[3].ToString(), sdr[4].ToString(), sdr[5].ToString(), sdr[6].ToString(), sdr[7].ToString(), sdr[8].ToString(), sdr[9].ToString(), sdr[10].ToString(), sdr[11].ToString(), sdr[12].ToString(), sdr[13].ToString(), sdr[14].ToString(), sdr[15].ToString());
                        data.Add(temp);
                    }
                }
                else
                {
                    Message msg = new Message("");
                    msg.setmessage("该商品不存在!");
                }
                if (comboBox1.Text == "按时间从早到晚")
                {
                    if (comboBox2.Text == "")
                        data.Sort(new DateUp());
                    else if (comboBox2.Text == "按数量从少到多")
                        data.Sort(new DateUpNumUp());
                    else if (comboBox2.Text == "按数量从多到少")
                        data.Sort(new DateUpNumDown());
                    else if (comboBox2.Text == "按出售价格从低到高")
                        data.Sort(new DateUpPriceUp());
                    else if (comboBox2.Text == "按出售价格从高到低")
                        data.Sort(new DateUpPriceDown());
                }
                else if(comboBox1.Text=="按时间从晚到早")
                {
                    if (comboBox2.Text == "")
                        data.Sort(new DateDown());
                    else if (comboBox2.Text == "按数量从少到多")
                        data.Sort(new DateDownNumUp());
                    else if (comboBox2.Text == "按数量从多到少")
                        data.Sort(new DateDownNumDown());
                    else if (comboBox2.Text == "按出售价格从低到高")
                        data.Sort(new DateUpPriceUp());
                    else if (comboBox2.Text == "按出售价格从高到低")
                        data.Sort(new DateDownPriceDown());
                }
                else if(comboBox1.Text=="按数量从少到多")
                {
                    if (comboBox2.Text == "")
                        data.Sort(new NumUp());
                    else if (comboBox2.Text == "按时间从早到晚")
                        data.Sort(new NumUpDateUp());
                    else if (comboBox2.Text == "按时间从晚到早")
                        data.Sort(new NumUpDateDown());
                    else if (comboBox2.Text == "按出售价格从低到高")
                        data.Sort(new NumUpPriceUp());
                    else if (comboBox2.Text == "按出售价格从高到低")
                        data.Sort(new NumUpPriceDown());
                }
                else if (comboBox1.Text == "按数量从多到少")
                {
                    if (comboBox2.Text == "")
                        data.Sort(new NumDown());
                    else if (comboBox2.Text == "按时间从早到晚")
                        data.Sort(new NumDownDateUp());
                    else if (comboBox2.Text == "按时间从晚到早")
                        data.Sort(new NumDownDateDown());
                    else if (comboBox2.Text == "按出售价格从低到高")
                        data.Sort(new NumDownPriceUp());
                    else if (comboBox2.Text == "按出售价格从高到低")
                        data.Sort(new NumDownPriceDown());
                }
                else if(comboBox1.Text=="按出售价格从高到低")
                {
                    if (comboBox2.Text == "")
                        data.Sort(new OutPriceDown());
                    else if (comboBox2.Text == "按时间从早到晚")
                        data.Sort(new OutPriceDownDateUp());
                    else if (comboBox2.Text == "按时间从晚到早")
                        data.Sort(new OutPriceDownDateDown());
                    else if (comboBox2.Text == "按数量从少到多")
                        data.Sort(new OutPriceDownNumUp());
                    else if (comboBox2.Text == "按数量从多到少")
                        data.Sort(new OutPriceDownNumDown());
                }
                else if (comboBox1.Text == "按出售价格从低到高")
                {
                    if (comboBox2.Text == "")
                        data.Sort(new OutPriceUp());
                    else if (comboBox2.Text == "按时间从早到晚")
                        data.Sort(new OutPriceUpDateUp());
                    else if (comboBox2.Text == "按时间从晚到早")
                        data.Sort(new OutPriceUpDateDown());
                    else if (comboBox2.Text == "按数量从少到多")
                        data.Sort(new OutPriceUpNumUp());
                    else if (comboBox2.Text == "按数量从多到少")
                        data.Sort(new OutPriceUpNumDown());
                }
                for(int i=0;i<data.Count;i++)
                {
                    int index = this.dataGridView1.Rows.Add();
                    for (int j = 0; j < 16; j++)
                    {
                        this.dataGridView1.Rows[index].Cells[j].Value = data[i].data[j];
                    }
                }
                data.Clear();
            }
        }

        private void Conditionalsearch_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            timer1.Enabled = true;
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.CustomFormat = " ";//使得日期选择控件初始为空
        }

        //使得时间控件为空，更改后正常显示
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePicker1.Format = DateTimePickerFormat.Short ;
            this.dateTimePicker1.CustomFormat = null;
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }



        //以下为UI层代码，与动画效果有关
        //以下四段实现窗口的拖动
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
        private void Conditionalsearch_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;
            Point cur = this.PointToScreen(e.Location);
            offset = new Point(cur.X - this.Left, cur.Y - this.Top);
        }
        private void Conditionalsearch_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;
            Point cur = MousePosition;
            this.Location = new Point(cur.X - offset.X, cur.Y - offset.Y);
        }
        //以下两段实现鼠标移入移出cancelbutton的动画效果
        private void cancelbutton_MouseEnter(object sender, EventArgs e)
        {
            cancelbutton.BackgroundImage = Properties.Resources.button3;
        }
        private void cancelbutton_MouseLeave(object sender, EventArgs e)
        {
            cancelbutton.BackgroundImage = Properties.Resources.button2;
        }
        //此时间控件实现窗口的渐变加载效果
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

        private void 另存为数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
