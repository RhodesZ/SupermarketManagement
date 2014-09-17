namespace 客户端
{
    partial class Analyze
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.season = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._firstclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._secondclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._inprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._outprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._season = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.secondclass = new System.Windows.Forms.ComboBox();
            this.firstclass = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.searchbutton = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Salescurve1 = new 客户端.Salescurve();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // season
            // 
            this.season.BackColor = System.Drawing.Color.White;
            this.season.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.season.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.season.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.season.FormattingEnabled = true;
            this.season.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4"});
            this.season.Location = new System.Drawing.Point(112, 124);
            this.season.Name = "season";
            this.season.Size = new System.Drawing.Size(155, 28);
            this.season.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.label2.Location = new System.Drawing.Point(42, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "季度";
            // 
            // mode
            // 
            this.mode.BackColor = System.Drawing.Color.White;
            this.mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mode.FormattingEnabled = true;
            this.mode.Items.AddRange(new object[] {
            "",
            "销售量最大的商品",
            "进价最高的商品",
            "售价最高的商品",
            "利润最高的商品",
            "利润率最高的商品"});
            this.mode.Location = new System.Drawing.Point(408, 184);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(155, 28);
            this.mode.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.label1.Location = new System.Drawing.Point(338, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "数据内容";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._firstclass,
            this._secondclass,
            this._id,
            this._name,
            this._state,
            this._inprice,
            this._outprice,
            this._season,
            this._reason,
            this._num,
            this._account,
            this._date});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.dataGridView1.Location = new System.Drawing.Point(55, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(801, 201);
            this.dataGridView1.TabIndex = 73;
            // 
            // _firstclass
            // 
            this._firstclass.HeaderText = "一级分类";
            this._firstclass.Name = "_firstclass";
            this._firstclass.ReadOnly = true;
            this._firstclass.Width = 80;
            // 
            // _secondclass
            // 
            this._secondclass.HeaderText = "二级分类";
            this._secondclass.Name = "_secondclass";
            this._secondclass.ReadOnly = true;
            this._secondclass.Width = 80;
            // 
            // _id
            // 
            this._id.HeaderText = "商品条码";
            this._id.Name = "_id";
            this._id.ReadOnly = true;
            this._id.Width = 80;
            // 
            // _name
            // 
            this._name.HeaderText = "商品名称";
            this._name.Name = "_name";
            this._name.ReadOnly = true;
            this._name.Width = 85;
            // 
            // _state
            // 
            this._state.HeaderText = "    状态";
            this._state.Name = "_state";
            this._state.ReadOnly = true;
            this._state.Width = 80;
            // 
            // _inprice
            // 
            this._inprice.HeaderText = "商品进价";
            this._inprice.Name = "_inprice";
            this._inprice.ReadOnly = true;
            this._inprice.Width = 80;
            // 
            // _outprice
            // 
            this._outprice.HeaderText = "商品售价";
            this._outprice.Name = "_outprice";
            this._outprice.ReadOnly = true;
            this._outprice.Width = 80;
            // 
            // _season
            // 
            this._season.HeaderText = "售出季度";
            this._season.Name = "_season";
            this._season.ReadOnly = true;
            this._season.Width = 80;
            // 
            // _reason
            // 
            this._reason.HeaderText = "退回理由";
            this._reason.Name = "_reason";
            this._reason.ReadOnly = true;
            this._reason.Width = 135;
            // 
            // _num
            // 
            this._num.HeaderText = "商品数量";
            this._num.Name = "_num";
            this._num.ReadOnly = true;
            this._num.Width = 80;
            // 
            // _account
            // 
            this._account.HeaderText = " 录入员";
            this._account.Name = "_account";
            this._account.ReadOnly = true;
            this._account.Width = 80;
            // 
            // _date
            // 
            this._date.HeaderText = "    日期";
            this._date.Name = "_date";
            this._date.ReadOnly = true;
            this._date.Width = 120;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.label3.Location = new System.Drawing.Point(338, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 78;
            this.label3.Text = "一级分类";
            // 
            // secondclass
            // 
            this.secondclass.BackColor = System.Drawing.Color.White;
            this.secondclass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.secondclass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secondclass.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.secondclass.FormattingEnabled = true;
            this.secondclass.Items.AddRange(new object[] {
            "(请先选择一级分类)"});
            this.secondclass.Location = new System.Drawing.Point(112, 183);
            this.secondclass.Name = "secondclass";
            this.secondclass.Size = new System.Drawing.Size(155, 28);
            this.secondclass.TabIndex = 3;
            // 
            // firstclass
            // 
            this.firstclass.BackColor = System.Drawing.Color.White;
            this.firstclass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.firstclass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstclass.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.firstclass.FormattingEnabled = true;
            this.firstclass.Items.AddRange(new object[] {
            "",
            "电器",
            "百货",
            "食品",
            "书籍"});
            this.firstclass.Location = new System.Drawing.Point(408, 123);
            this.firstclass.Name = "firstclass";
            this.firstclass.Size = new System.Drawing.Size(155, 28);
            this.firstclass.TabIndex = 2;
            this.firstclass.SelectedIndexChanged += new System.EventHandler(this.firstclass_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.label4.Location = new System.Drawing.Point(42, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 80;
            this.label4.Text = "二级分类";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::客户端.Properties.Resources.button2;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button2.Location = new System.Drawing.Point(755, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 40);
            this.button2.TabIndex = 88;
            this.button2.Text = "Back to Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::客户端.Properties.Resources.button;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button1.Location = new System.Drawing.Point(631, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 40);
            this.button1.TabIndex = 86;
            this.button1.Text = "Sales Curve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.BackgroundImage = global::客户端.Properties.Resources.button2;
            this.cancelbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbutton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancelbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cancelbutton.Location = new System.Drawing.Point(753, 119);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(118, 40);
            this.cancelbutton.TabIndex = 85;
            this.cancelbutton.Text = "Quit";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            this.cancelbutton.MouseEnter += new System.EventHandler(this.cancelbutton_MouseEnter);
            this.cancelbutton.MouseLeave += new System.EventHandler(this.cancelbutton_MouseLeave);
            // 
            // searchbutton
            // 
            this.searchbutton.BackgroundImage = global::客户端.Properties.Resources.button;
            this.searchbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbutton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.searchbutton.Location = new System.Drawing.Point(631, 118);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(118, 40);
            this.searchbutton.TabIndex = 84;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::客户端.Properties.Resources.textbox;
            this.pictureBox4.Location = new System.Drawing.Point(331, 117);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(240, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 77;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::客户端.Properties.Resources.textbox;
            this.pictureBox5.Location = new System.Drawing.Point(35, 177);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(240, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 79;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::客户端.Properties.Resources.list;
            this.pictureBox6.Location = new System.Drawing.Point(34, 241);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(837, 229);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 74;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::客户端.Properties.Resources.textbox;
            this.pictureBox3.Location = new System.Drawing.Point(331, 178);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(240, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::客户端.Properties.Resources.textbox;
            this.pictureBox2.Location = new System.Drawing.Point(35, 118);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(240, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::客户端.Properties.Resources.装饰5;
            this.pictureBox1.Location = new System.Drawing.Point(328, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.crystalReportViewer1.Location = new System.Drawing.Point(34, 239);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.Salescurve1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(836, 533);
            this.crystalReportViewer1.TabIndex = 87;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Visible = false;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // Analyze
            // 
            this.AcceptButton = this.searchbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(909, 496);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.secondclass);
            this.Controls.Add(this.firstclass);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.mode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.season);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.crystalReportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Analyze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analyze";
            this.Load += new System.EventHandler(this.Analyze_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Analyze_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Analyze_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox season;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox mode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _firstclass;
        private System.Windows.Forms.DataGridViewTextBoxColumn _secondclass;
        private System.Windows.Forms.DataGridViewTextBoxColumn _id;
        private System.Windows.Forms.DataGridViewTextBoxColumn _name;
        private System.Windows.Forms.DataGridViewTextBoxColumn _state;
        private System.Windows.Forms.DataGridViewTextBoxColumn _inprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn _outprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn _season;
        private System.Windows.Forms.DataGridViewTextBoxColumn _reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn _num;
        private System.Windows.Forms.DataGridViewTextBoxColumn _account;
        private System.Windows.Forms.DataGridViewTextBoxColumn _date;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox secondclass;
        private System.Windows.Forms.ComboBox firstclass;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer3;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button button2;
        private Salescurve Salescurve1;
    }
}