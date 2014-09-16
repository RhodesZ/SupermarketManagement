namespace 客户端
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.account = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.code = new System.Windows.Forms.TextBox();
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.loginbutton = new System.Windows.Forms.Button();
            this.quitbutton = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.regbutton = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // account
            // 
            this.account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.account.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.account.Location = new System.Drawing.Point(101, 267);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(263, 27);
            this.account.TabIndex = 4;
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password.Location = new System.Drawing.Point(101, 354);
            this.password.Name = "password";
            this.password.PasswordChar = '●';
            this.password.Size = new System.Drawing.Size(263, 27);
            this.password.TabIndex = 5;
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
            // timer4
            // 
            this.timer4.Interval = 1;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 1;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Interval = 1000;
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // code
            // 
            this.code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.code.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.code.Location = new System.Drawing.Point(654, 354);
            this.code.Name = "code";
            this.code.PasswordChar = '●';
            this.code.Size = new System.Drawing.Size(90, 27);
            this.code.TabIndex = 13;
            // 
            // timer7
            // 
            this.timer7.Interval = 1;
            this.timer7.Tick += new System.EventHandler(this.timer7_Tick);
            // 
            // loginbutton
            // 
            this.loginbutton.BackgroundImage = global::客户端.Properties.Resources.button;
            this.loginbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbutton.Font = new System.Drawing.Font("微软雅黑 Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.loginbutton.Location = new System.Drawing.Point(399, 255);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(163, 52);
            this.loginbutton.TabIndex = 8;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // quitbutton
            // 
            this.quitbutton.BackgroundImage = global::客户端.Properties.Resources.button2;
            this.quitbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quitbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitbutton.Font = new System.Drawing.Font("微软雅黑 Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.quitbutton.Location = new System.Drawing.Point(399, 342);
            this.quitbutton.Name = "quitbutton";
            this.quitbutton.Size = new System.Drawing.Size(163, 52);
            this.quitbutton.TabIndex = 15;
            this.quitbutton.Text = "Quit";
            this.quitbutton.UseVisualStyleBackColor = true;
            this.quitbutton.Click += new System.EventHandler(this.quitbutton_Click_1);
            this.quitbutton.MouseEnter += new System.EventHandler(this.quitbutton_MouseEnter_1);
            this.quitbutton.MouseLeave += new System.EventHandler(this.quitbutton_MouseLeave_1);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.White;
            this.pictureBox9.Image = global::客户端.Properties.Resources.password;
            this.pictureBox9.Location = new System.Drawing.Point(612, 345);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(42, 44);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 14;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::客户端.Properties.Resources.textbox2;
            this.pictureBox8.Location = new System.Drawing.Point(599, 342);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(163, 52);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 12;
            this.pictureBox8.TabStop = false;
            // 
            // regbutton
            // 
            this.regbutton.BackgroundImage = global::客户端.Properties.Resources.button;
            this.regbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.regbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regbutton.Font = new System.Drawing.Font("微软雅黑 Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.regbutton.Location = new System.Drawing.Point(600, 255);
            this.regbutton.Name = "regbutton";
            this.regbutton.Size = new System.Drawing.Size(163, 52);
            this.regbutton.TabIndex = 11;
            this.regbutton.Text = "Register";
            this.regbutton.UseVisualStyleBackColor = true;
            this.regbutton.Click += new System.EventHandler(this.regbutton_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(0, -230);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(599, 229);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox7.TabIndex = 10;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Image = global::客户端.Properties.Resources.password;
            this.pictureBox6.Location = new System.Drawing.Point(52, 345);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(42, 44);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Image = global::客户端.Properties.Resources.account;
            this.pictureBox5.Location = new System.Drawing.Point(50, 258);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(42, 44);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(37, 342);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(343, 52);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(37, 255);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(343, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::客户端.Properties.Resources.logintext;
            this.pictureBox2.Location = new System.Drawing.Point(205, 110);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(184, 89);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(599, 209);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Login
            // 
            this.AcceptButton = this.loginbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(599, 436);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.code);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.regbutton);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.password);
            this.Controls.Add(this.account);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.quitbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox account;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button regbutton;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Timer timer7;
        private System.Windows.Forms.Button quitbutton;


    }
}