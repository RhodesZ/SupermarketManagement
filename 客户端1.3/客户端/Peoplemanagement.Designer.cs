namespace 客户端
{
    partial class Peoplemanagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._firstclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._secondclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._inprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.deletebutton = new System.Windows.Forms.Button();
            this.changebutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.searchbutton = new System.Windows.Forms.Button();
            this.position = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.department = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.salary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.perimission = new System.Windows.Forms.ComboBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.submitbutton = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._firstclass,
            this._secondclass,
            this._id,
            this._name,
            this._state,
            this._inprice});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.dataGridView1.Location = new System.Drawing.Point(40, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(752, 201);
            this.dataGridView1.TabIndex = 58;
            // 
            // _firstclass
            // 
            this._firstclass.HeaderText = "    姓名";
            this._firstclass.Name = "_firstclass";
            this._firstclass.Width = 120;
            // 
            // _secondclass
            // 
            this._secondclass.HeaderText = "    性别";
            this._secondclass.Name = "_secondclass";
            this._secondclass.Width = 120;
            // 
            // _id
            // 
            this._id.HeaderText = "    部门";
            this._id.Name = "_id";
            this._id.Width = 120;
            // 
            // _name
            // 
            this._name.HeaderText = "    职位";
            this._name.Name = "_name";
            this._name.Width = 120;
            // 
            // _state
            // 
            this._state.HeaderText = "    薪水";
            this._state.Name = "_state";
            this._state.Width = 115;
            // 
            // _inprice
            // 
            this._inprice.HeaderText = "    权限";
            this._inprice.Name = "_inprice";
            this._inprice.Width = 114;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::客户端.Properties.Resources.list;
            this.pictureBox6.Location = new System.Drawing.Point(28, 250);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(779, 229);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 59;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::客户端.Properties.Resources.装饰101;
            this.pictureBox7.Location = new System.Drawing.Point(225, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(367, 84);
            this.pictureBox7.TabIndex = 60;
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
            this.deletebutton.Location = new System.Drawing.Point(688, 120);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(119, 40);
            this.deletebutton.TabIndex = 57;
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
            this.changebutton.Location = new System.Drawing.Point(564, 120);
            this.changebutton.Name = "changebutton";
            this.changebutton.Size = new System.Drawing.Size(118, 40);
            this.changebutton.TabIndex = 56;
            this.changebutton.Text = "Change";
            this.changebutton.UseVisualStyleBackColor = true;
            this.changebutton.Click += new System.EventHandler(this.changebutton_Click);
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
            this.cancelbutton.Location = new System.Drawing.Point(689, 188);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(118, 40);
            this.cancelbutton.TabIndex = 55;
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
            this.searchbutton.Location = new System.Drawing.Point(564, 188);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(118, 40);
            this.searchbutton.TabIndex = 54;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // position
            // 
            this.position.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.position.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.position.Location = new System.Drawing.Point(373, 198);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(155, 20);
            this.position.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.label3.Location = new System.Drawing.Point(303, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "  职位  ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::客户端.Properties.Resources.textbox;
            this.pictureBox3.Location = new System.Drawing.Point(296, 188);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(240, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 68;
            this.pictureBox3.TabStop = false;
            // 
            // department
            // 
            this.department.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.department.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.department.Location = new System.Drawing.Point(106, 198);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(155, 20);
            this.department.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.label2.Location = new System.Drawing.Point(36, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "  部门  ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::客户端.Properties.Resources.textbox;
            this.pictureBox1.Location = new System.Drawing.Point(29, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.label1.Location = new System.Drawing.Point(303, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "  性别  ";
            // 
            // sex
            // 
            this.sex.BackColor = System.Drawing.Color.White;
            this.sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sex.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sex.FormattingEnabled = true;
            this.sex.Items.AddRange(new object[] {
            "",
            "男",
            "女"});
            this.sex.Location = new System.Drawing.Point(373, 127);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(155, 28);
            this.sex.TabIndex = 61;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::客户端.Properties.Resources.textbox;
            this.pictureBox2.Location = new System.Drawing.Point(296, 121);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(240, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 64;
            this.pictureBox2.TabStop = false;
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.Location = new System.Drawing.Point(106, 131);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(155, 20);
            this.name.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.label4.Location = new System.Drawing.Point(36, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 72;
            this.label4.Text = "  姓名  ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::客户端.Properties.Resources.textbox;
            this.pictureBox4.Location = new System.Drawing.Point(29, 121);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(240, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 71;
            this.pictureBox4.TabStop = false;
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
            // salary
            // 
            this.salary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salary.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.salary.Location = new System.Drawing.Point(373, 341);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(155, 20);
            this.salary.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.label5.Location = new System.Drawing.Point(303, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 78;
            this.label5.Text = "  薪水  ";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::客户端.Properties.Resources.textbox;
            this.pictureBox5.Location = new System.Drawing.Point(296, 331);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(240, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 77;
            this.pictureBox5.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.label6.Location = new System.Drawing.Point(303, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 76;
            this.label6.Text = "  权限  ";
            // 
            // perimission
            // 
            this.perimission.BackColor = System.Drawing.Color.White;
            this.perimission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.perimission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.perimission.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.perimission.FormattingEnabled = true;
            this.perimission.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.perimission.Location = new System.Drawing.Point(373, 270);
            this.perimission.Name = "perimission";
            this.perimission.Size = new System.Drawing.Size(155, 28);
            this.perimission.TabIndex = 73;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::客户端.Properties.Resources.textbox;
            this.pictureBox8.Location = new System.Drawing.Point(296, 264);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(240, 40);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 75;
            this.pictureBox8.TabStop = false;
            // 
            // submitbutton
            // 
            this.submitbutton.BackgroundImage = global::客户端.Properties.Resources.button;
            this.submitbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.submitbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitbutton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.submitbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.submitbutton.Location = new System.Drawing.Point(360, 386);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Size = new System.Drawing.Size(118, 40);
            this.submitbutton.TabIndex = 79;
            this.submitbutton.Text = "Submit";
            this.submitbutton.UseVisualStyleBackColor = true;
            this.submitbutton.Click += new System.EventHandler(this.submitbutton_Click);
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Peoplemanagement
            // 
            this.AcceptButton = this.searchbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(837, 500);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.position);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.department);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.changebutton);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.submitbutton);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.perimission);
            this.Controls.Add(this.pictureBox8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Peoplemanagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peoplemanagement";
            this.Load += new System.EventHandler(this.Peoplemanagement_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Peoplemanagement_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Peoplemanagement_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button changebutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.TextBox position;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox department;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sex;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox perimission;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button submitbutton;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.DataGridViewTextBoxColumn _firstclass;
        private System.Windows.Forms.DataGridViewTextBoxColumn _secondclass;
        private System.Windows.Forms.DataGridViewTextBoxColumn _id;
        private System.Windows.Forms.DataGridViewTextBoxColumn _name;
        private System.Windows.Forms.DataGridViewTextBoxColumn _state;
        private System.Windows.Forms.DataGridViewTextBoxColumn _inprice;
    }
}