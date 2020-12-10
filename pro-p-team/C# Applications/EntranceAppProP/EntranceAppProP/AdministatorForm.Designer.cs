namespace EntranceAppProP
{
    partial class AdministatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministatorForm));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.btn_Emp = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Activate = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.lb_status = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_Activeties = new System.Windows.Forms.ListBox();
            this.tb_Activeties = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_location = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_Notify = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_Stand = new System.Windows.Forms.ComboBox();
            this.leftPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.leftPanel.Controls.Add(this.btn_Emp);
            this.leftPanel.Controls.Add(this.btn_Create);
            this.leftPanel.Controls.Add(this.btn_Activate);
            this.leftPanel.Controls.Add(this.btn_Send);
            this.leftPanel.Controls.Add(this.logoPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(239, 716);
            this.leftPanel.TabIndex = 2;
            // 
            // btn_Emp
            // 
            this.btn_Emp.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Emp.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_Emp.Location = new System.Drawing.Point(-3, 466);
            this.btn_Emp.Name = "btn_Emp";
            this.btn_Emp.Size = new System.Drawing.Size(239, 104);
            this.btn_Emp.TabIndex = 7;
            this.btn_Emp.Text = "Add Employee";
            this.btn_Emp.UseVisualStyleBackColor = false;
            this.btn_Emp.Click += new System.EventHandler(this.btn_Emp_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Create.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_Create.Location = new System.Drawing.Point(0, 354);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(239, 103);
            this.btn_Create.TabIndex = 6;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = false;
            this.btn_Create.Click += new System.EventHandler(this.btn_CrActive_Click);
            // 
            // btn_Activate
            // 
            this.btn_Activate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Activate.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Activate.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_Activate.Location = new System.Drawing.Point(-3, 237);
            this.btn_Activate.Name = "btn_Activate";
            this.btn_Activate.Size = new System.Drawing.Size(242, 109);
            this.btn_Activate.TabIndex = 5;
            this.btn_Activate.Text = "Activate Entry";
            this.btn_Activate.UseVisualStyleBackColor = false;
            this.btn_Activate.Click += new System.EventHandler(this.btn_Activate_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Send.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_Send.Location = new System.Drawing.Point(0, 585);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(239, 104);
            this.btn_Send.TabIndex = 3;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = false;
            this.btn_Send.Click += new System.EventHandler(this.btn_sendReminder_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.logoPanel.Controls.Add(this.pictureBox1);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(239, 191);
            this.logoPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbX.Location = new System.Drawing.Point(865, 18);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(27, 26);
            this.lbX.TabIndex = 0;
            this.lbX.Text = "X";
            this.lbX.Click += new System.EventHandler(this.lbX_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(824, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "_";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.lb_status);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.lbX);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(239, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(904, 191);
            this.topPanel.TabIndex = 3;
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Location = new System.Drawing.Point(238, 87);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(0, 26);
            this.lb_status.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_Activeties
            // 
            this.lb_Activeties.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lb_Activeties.ForeColor = System.Drawing.SystemColors.Info;
            this.lb_Activeties.FormattingEnabled = true;
            this.lb_Activeties.ItemHeight = 25;
            this.lb_Activeties.Location = new System.Drawing.Point(287, 225);
            this.lb_Activeties.Name = "lb_Activeties";
            this.lb_Activeties.Size = new System.Drawing.Size(421, 204);
            this.lb_Activeties.TabIndex = 1;
            // 
            // tb_Activeties
            // 
            this.tb_Activeties.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tb_Activeties.ForeColor = System.Drawing.SystemColors.Info;
            this.tb_Activeties.Location = new System.Drawing.Point(876, 281);
            this.tb_Activeties.Name = "tb_Activeties";
            this.tb_Activeties.Size = new System.Drawing.Size(232, 32);
            this.tb_Activeties.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 544);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Remind the Client";
            // 
            // tb_location
            // 
            this.tb_location.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tb_location.ForeColor = System.Drawing.SystemColors.Info;
            this.tb_location.Location = new System.Drawing.Point(876, 238);
            this.tb_location.Name = "tb_location";
            this.tb_location.Size = new System.Drawing.Size(232, 32);
            this.tb_location.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(755, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(755, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "name";
            // 
            // tb_Price
            // 
            this.tb_Price.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tb_Price.ForeColor = System.Drawing.SystemColors.Info;
            this.tb_Price.Location = new System.Drawing.Point(876, 319);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(232, 32);
            this.tb_Price.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(757, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Price";
            // 
            // lb_Notify
            // 
            this.lb_Notify.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lb_Notify.ForeColor = System.Drawing.SystemColors.Info;
            this.lb_Notify.FormattingEnabled = true;
            this.lb_Notify.ItemHeight = 25;
            this.lb_Notify.Location = new System.Drawing.Point(287, 435);
            this.lb_Notify.Name = "lb_Notify";
            this.lb_Notify.Size = new System.Drawing.Size(421, 254);
            this.lb_Notify.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(714, 495);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "EmployeeName";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(889, 492);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 32);
            this.textBox1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(814, 565);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 26);
            this.label6.TabIndex = 17;
            this.label6.Text = "Stand";
            // 
            // cb_Stand
            // 
            this.cb_Stand.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cb_Stand.FormattingEnabled = true;
            this.cb_Stand.Location = new System.Drawing.Point(889, 562);
            this.cb_Stand.Name = "cb_Stand";
            this.cb_Stand.Size = new System.Drawing.Size(232, 33);
            this.cb_Stand.TabIndex = 18;
            // 
            // AdministatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1143, 716);
            this.Controls.Add(this.cb_Stand);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_Notify);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.lb_Activeties);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_location);
            this.Controls.Add(this.tb_Price);
            this.Controls.Add(this.tb_Activeties);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "AdministatorForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administration";
            this.leftPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Activate;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbX;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox lb_Activeties;
        private System.Windows.Forms.TextBox tb_Activeties;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_location;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lb_Notify;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_Stand;
        private System.Windows.Forms.Button btn_Emp;
        private System.Windows.Forms.Label lb_status;
    }
}

