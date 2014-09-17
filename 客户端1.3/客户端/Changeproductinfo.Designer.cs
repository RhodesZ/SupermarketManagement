namespace 客户端
{
    partial class Changeproductinfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.TextBox();
            this.secondclass = new System.Windows.Forms.ComboBox();
            this.firstclass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.newreason = new System.Windows.Forms.TextBox();
            this.newstate = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.searchbutton = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.deletebutton = new System.Windows.Forms.Button();
            this.changebutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.submitbutton = new System.Windows.Forms.Button();
            this.idnumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.label1.Location = new System.Drawing.Point(38, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "一级分类";
            // 
            // state
            // 
            this.state.BackColor = System.Drawing.Color.White;
            this.state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.state.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.state.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.state.FormattingEnabled = true;
            this.state.Items.AddRange(new object[] {
            "",
            "入库",
            "上架",
            "售出",
            "退回"});
            this.state.Location = new System.Drawing.Point(642, 121);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(155, 28);
            this.state.TabIndex = 3;
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.Location = new System.Drawing.Point(374, 126);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(155, 20);
            this.name.TabIndex = 5;
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
            this.secondclass.Location = new System.Drawing.Point(108, 188);
            this.secondclass.Name = "secondclass";
            this.secondclass.Size = new System.Drawing.Size(155, 28);
            this.secondclass.TabIndex = 4;
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
            this.firstclass.Location = new System.Drawing.Point(108, 122);
            this.firstclass.Name = "firstclass";
            this.firstclass.Size = new System.Drawing.Size(155, 28);
            this.firstclass.TabIndex = 1;
            this.firstclass.SelectedIndexChanged += new System.EventHandler(this.firstclass_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.label2.Location = new System.Drawing.Point(38, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "二级分类";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.label3.Location = new System.Drawing.Point(304, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "商品条码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.label4.Location = new System.Drawing.Point(304, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "商品名称";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.label5.Location = new System.Drawing.Point(572, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "当前状态";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.dataGridView1.Location = new System.Drawing.Point(42, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1015, 201);
            this.dataGridView1.TabIndex = 51;
            // 
            // _firstclass
            // 
            this._firstclass.HeaderText = "一级分类";
            this._firstclass.Name = "_firstclass";
            this._firstclass.Width = 80;
            // 
            // _secondclass
            // 
            this._secondclass.HeaderText = "二级分类";
            this._secondclass.Name = "_secondclass";
            this._secondclass.Width = 80;
            // 
            // _id
            // 
            this._id.HeaderText = "商品条码";
            this._id.Name = "_id";
            this._id.Width = 80;
            // 
            // _name
            // 
            this._name.HeaderText = "商品名称";
            this._name.Name = "_name";
            this._name.Width = 80;
            // 
            // _state
            // 
            this._state.HeaderText = "    状态";
            this._state.Name = "_state";
            this._state.Width = 80;
            // 
            // _inprice
            // 
            this._inprice.HeaderText = "商品进价";
            this._inprice.Name = "_inprice";
            this._inprice.Width = 80;
            // 
            // _outprice
            // 
            this._outprice.HeaderText = "商品售价";
            this._outprice.Name = "_outprice";
            this._outprice.Width = 80;
            // 
            // _season
            // 
            this._season.HeaderText = "售出季度";
            this._season.Name = "_season";
            this._season.Width = 80;
            // 
            // _reason
            // 
            this._reason.HeaderText = "退回理由";
            this._reason.Name = "_reason";
            this._reason.Width = 140;
            // 
            // _num
            // 
            this._num.HeaderText = "商品数量";
            this._num.Name = "_num";
            this._num.Width = 80;
            // 
            // _account
            // 
            this._account.HeaderText = " 录入员";
            this._account.Name = "_account";
            this._account.Width = 80;
            // 
            // _date
            // 
            this._date.HeaderText = "    日期";
            this._date.Name = "_date";
            this._date.Width = 110;
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
            // newreason
            // 
            this.newreason.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newreason.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.newreason.Location = new System.Drawing.Point(1184, 348);
            this.newreason.Name = "newreason";
            this.newreason.Size = new System.Drawing.Size(150, 20);
            this.newreason.TabIndex = 56;
            this.newreason.Visible = false;
            // 
            // newstate
            // 
            this.newstate.BackColor = System.Drawing.Color.White;
            this.newstate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newstate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newstate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.newstate.FormattingEnabled = true;
            this.newstate.Items.AddRange(new object[] {
            "入库",
            "上架",
            "售出",
            "退回"});
            this.newstate.Location = new System.Drawing.Point(-164, 283);
            this.newstate.Name = "newstate";
            this.newstate.Size = new System.Drawing.Size(155, 28);
            this.newstate.TabIndex = 54;
            this.newstate.SelectedIndexChanged += new System.EventHandler(this.newstate_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.label6.Location = new System.Drawing.Point(-233, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 59;
            this.label6.Text = "新状态";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.label8.Location = new System.Drawing.Point(1110, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 61;
            this.label8.Text = "（选填）";
            // 
            // timer4
            // 
            this.timer4.Interval = 1;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.White;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dateTimePicker1.CausesValidation = false;
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker1.Location = new System.Drawing.Point(647, 186);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 27);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.label10.Location = new System.Drawing.Point(572, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 63;
            this.label10.Text = "操作时间";
            // 
            // searchbutton
            // 
            this.searchbutton.BackgroundImage = global::客户端.Properties.Resources.button;
            this.searchbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbutton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.searchbutton.Location = new System.Drawing.Point(831, 182);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(118, 40);
            this.searchbutton.TabIndex = 47;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::客户端.Properties.Resources.list;
            this.pictureBox6.Location = new System.Drawing.Point(30, 244);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(1044, 229);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 52;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::客户端.Properties.Resources.textbox;
            this.pictureBox12.Location = new System.Drawing.Point(565, 179);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(240, 40);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 62;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::客户端.Properties.Resources.装饰3;
            this.pictureBox7.Location = new System.Drawing.Point(47, 15);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(1004, 84);
            this.pictureBox7.TabIndex = 53;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox7_MouseDown);
            this.pictureBox7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox7_MouseMove);
            // 
            // deletebutton
            // 
            this.deletebutton.BackgroundImage = global::客户端.Properties.Resources.button2;
            this.deletebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deletebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebutton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deletebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.deletebutton.Location = new System.Drawing.Point(955, 114);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(119, 40);
            this.deletebutton.TabIndex = 50;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            this.deletebutton.MouseEnter += new System.EventHandler(this.deletebutton_MouseEnter);
            this.deletebutton.MouseLeave += new System.EventHandler(this.deletebutton_MouseLeave);
            // 
            // changebutton
            // 
            this.changebutton.BackgroundImage = global::客户端.Properties.Resources.button;
            this.changebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.changebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changebutton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.changebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.changebutton.Location = new System.Drawing.Point(831, 114);
            this.changebutton.Name = "changebutton";
            this.changebutton.Size = new System.Drawing.Size(118, 40);
            this.changebutton.TabIndex = 49;
            this.changebutton.Text = "Change";
            this.changebutton.UseVisualStyleBackColor = true;
            this.changebutton.Click += new System.EventHandler(this.changebutton_Click);
            this.changebutton.MouseEnter += new System.EventHandler(this.changebutton_MouseEnter);
            this.changebutton.MouseLeave += new System.EventHandler(this.changebutton_MouseLeave);
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
            this.cancelbutton.Location = new System.Drawing.Point(956, 182);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(118, 40);
            this.cancelbutton.TabIndex = 48;
            this.cancelbutton.Text = "Quit";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            this.cancelbutton.MouseEnter += new System.EventHandler(this.cancelbutton_MouseEnter);
            this.cancelbutton.MouseLeave += new System.EventHandler(this.cancelbutton_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::客户端.Properties.Resources.textbox;
            this.pictureBox1.Location = new System.Drawing.Point(31, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::客户端.Properties.Resources.textbox;
            this.pictureBox2.Location = new System.Drawing.Point(31, 182);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(240, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::客户端.Properties.Resources.textbox;
            this.pictureBox3.Location = new System.Drawing.Point(297, 181);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(240, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 41;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::客户端.Properties.Resources.textbox;
            this.pictureBox4.Location = new System.Drawing.Point(297, 116);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(240, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 43;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::客户端.Properties.Resources.textbox;
            this.pictureBox5.Location = new System.Drawing.Point(565, 115);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(240, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 45;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::客户端.Properties.Resources.textbox;
            this.pictureBox8.Location = new System.Drawing.Point(-241, 277);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(240, 40);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 58;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::客户端.Properties.Resources.textbox;
            this.pictureBox9.Location = new System.Drawing.Point(1101, 338);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(240, 40);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 60;
            this.pictureBox9.TabStop = false;
            // 
            // submitbutton
            // 
            this.submitbutton.BackgroundImage = global::客户端.Properties.Resources.button;
            this.submitbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.submitbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitbutton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.submitbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.submitbutton.Location = new System.Drawing.Point(485, 402);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Size = new System.Drawing.Size(118, 40);
            this.submitbutton.TabIndex = 57;
            this.submitbutton.Text = "Submit";
            this.submitbutton.UseVisualStyleBackColor = true;
            this.submitbutton.Click += new System.EventHandler(this.submitbutton_Click);
            // 
            // idnumber
            // 
            this.idnumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idnumber.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.idnumber.Location = new System.Drawing.Point(374, 192);
            this.idnumber.Name = "idnumber";
            this.idnumber.Size = new System.Drawing.Size(155, 20);
            this.idnumber.TabIndex = 64;
            // 
            // Changeproductinfo
            // 
            this.AcceptButton = this.searchbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1100, 500);
            this.Controls.Add(this.idnumber);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.changebutton);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.state);
            this.Controls.Add(this.name);
            this.Controls.Add(this.secondclass);
            this.Controls.Add(this.firstclass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.newreason);
            this.Controls.Add(this.newstate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.submitbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Changeproductinfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Searchproductinfo";
            this.Load += new System.EventHandler(this.Searchproductinfo_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Searchproductinfo_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Searchproductinfo_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox state;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.ComboBox secondclass;
        private System.Windows.Forms.ComboBox firstclass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button changebutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button submitbutton;
        private System.Windows.Forms.TextBox newreason;
        private System.Windows.Forms.ComboBox newstate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox12;
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
        private System.Windows.Forms.TextBox idnumber;
    }
}