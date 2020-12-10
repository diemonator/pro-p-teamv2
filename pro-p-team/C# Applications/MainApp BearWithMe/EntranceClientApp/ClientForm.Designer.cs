namespace EntranceClientApp
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_AddTo_Reg = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_anim = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.tb_status = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_BankInfo = new System.Windows.Forms.TextBox();
            this.tb_lastName = new System.Windows.Forms.TextBox();
            this.tb_FirstName = new System.Windows.Forms.TextBox();
            this.lb_GichkaForm = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_EventAccount = new System.Windows.Forms.TextBox();
            this.tb_telephone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_anim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.leftPanel.Controls.Add(this.btn_connect);
            this.leftPanel.Controls.Add(this.btn_AddTo_Reg);
            this.leftPanel.Controls.Add(this.logoPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(239, 527);
            this.leftPanel.TabIndex = 2;
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connect.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_connect.Location = new System.Drawing.Point(0, 360);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(239, 103);
            this.btn_connect.TabIndex = 8;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_AddTo_Reg
            // 
            this.btn_AddTo_Reg.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_AddTo_Reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddTo_Reg.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_AddTo_Reg.Location = new System.Drawing.Point(0, 238);
            this.btn_AddTo_Reg.Name = "btn_AddTo_Reg";
            this.btn_AddTo_Reg.Size = new System.Drawing.Size(239, 103);
            this.btn_AddTo_Reg.TabIndex = 6;
            this.btn_AddTo_Reg.Text = "Register Client";
            this.btn_AddTo_Reg.UseVisualStyleBackColor = false;
            this.btn_AddTo_Reg.Click += new System.EventHandler(this.btn_RegisterClient_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.logoPanel.Controls.Add(this.panel1);
            this.logoPanel.Controls.Add(this.pb_anim);
            this.logoPanel.Controls.Add(this.pictureBox1);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(239, 191);
            this.logoPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(239, 194);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 286);
            this.panel1.TabIndex = 7;
            // 
            // pb_anim
            // 
            this.pb_anim.Location = new System.Drawing.Point(3, 0);
            this.pb_anim.Name = "pb_anim";
            this.pb_anim.Size = new System.Drawing.Size(239, 191);
            this.pb_anim.TabIndex = 8;
            this.pb_anim.TabStop = false;
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
            this.lbX.Location = new System.Drawing.Point(761, 26);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(27, 26);
            this.lbX.TabIndex = 0;
            this.lbX.Text = "X";
            this.lbX.Click += new System.EventHandler(this.lbX_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(720, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "_";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.tb_status);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.lbX);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(239, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(798, 191);
            this.topPanel.TabIndex = 3;
            // 
            // tb_status
            // 
            this.tb_status.AutoSize = true;
            this.tb_status.Location = new System.Drawing.Point(203, 82);
            this.tb_status.Name = "tb_status";
            this.tb_status.Size = new System.Drawing.Size(0, 26);
            this.tb_status.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(680, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 26);
            this.label4.TabIndex = 26;
            this.label4.Text = "Address";
            // 
            // tb_Address
            // 
            this.tb_Address.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tb_Address.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tb_Address.Location = new System.Drawing.Point(810, 329);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(195, 32);
            this.tb_Address.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(680, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 26);
            this.label3.TabIndex = 23;
            this.label3.Text = "BankInfo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(680, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 26);
            this.label2.TabIndex = 22;
            this.label2.Text = "lastName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(680, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 26);
            this.label6.TabIndex = 21;
            this.label6.Text = "firstName";
            // 
            // tb_BankInfo
            // 
            this.tb_BankInfo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tb_BankInfo.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tb_BankInfo.Location = new System.Drawing.Point(810, 292);
            this.tb_BankInfo.Name = "tb_BankInfo";
            this.tb_BankInfo.Size = new System.Drawing.Size(195, 32);
            this.tb_BankInfo.TabIndex = 20;
            // 
            // tb_lastName
            // 
            this.tb_lastName.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tb_lastName.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tb_lastName.Location = new System.Drawing.Point(810, 254);
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(195, 32);
            this.tb_lastName.TabIndex = 19;
            // 
            // tb_FirstName
            // 
            this.tb_FirstName.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tb_FirstName.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tb_FirstName.Location = new System.Drawing.Point(810, 220);
            this.tb_FirstName.Name = "tb_FirstName";
            this.tb_FirstName.Size = new System.Drawing.Size(195, 32);
            this.tb_FirstName.TabIndex = 18;
            // 
            // lb_GichkaForm
            // 
            this.lb_GichkaForm.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lb_GichkaForm.ForeColor = System.Drawing.SystemColors.Info;
            this.lb_GichkaForm.FormattingEnabled = true;
            this.lb_GichkaForm.ItemHeight = 25;
            this.lb_GichkaForm.Location = new System.Drawing.Point(277, 236);
            this.lb_GichkaForm.Name = "lb_GichkaForm";
            this.lb_GichkaForm.Size = new System.Drawing.Size(329, 279);
            this.lb_GichkaForm.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(680, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 26);
            this.label7.TabIndex = 31;
            this.label7.Text = "Client cash";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(680, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 26);
            this.label8.TabIndex = 30;
            this.label8.Text = "Telephone";
            // 
            // tb_EventAccount
            // 
            this.tb_EventAccount.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tb_EventAccount.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tb_EventAccount.Location = new System.Drawing.Point(810, 401);
            this.tb_EventAccount.Name = "tb_EventAccount";
            this.tb_EventAccount.Size = new System.Drawing.Size(195, 32);
            this.tb_EventAccount.TabIndex = 29;
            // 
            // tb_telephone
            // 
            this.tb_telephone.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tb_telephone.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tb_telephone.Location = new System.Drawing.Point(810, 367);
            this.tb_telephone.Name = "tb_telephone";
            this.tb_telephone.Size = new System.Drawing.Size(195, 32);
            this.tb_telephone.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Select your activetie";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1037, 527);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_EventAccount);
            this.Controls.Add(this.tb_telephone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_BankInfo);
            this.Controls.Add(this.tb_lastName);
            this.Controls.Add(this.tb_FirstName);
            this.Controls.Add(this.lb_GichkaForm);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "ClientForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client entrance app";
            this.leftPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_anim)).EndInit();
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
        private System.Windows.Forms.Button btn_AddTo_Reg;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbX;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_BankInfo;
        private System.Windows.Forms.TextBox tb_lastName;
        private System.Windows.Forms.TextBox tb_FirstName;
        private System.Windows.Forms.ListBox lb_GichkaForm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_EventAccount;
        private System.Windows.Forms.TextBox tb_telephone;
        private System.Windows.Forms.PictureBox pb_anim;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label tb_status;
        private System.Windows.Forms.Label label5;
    }
}

