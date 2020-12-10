namespace CampSight
{
    partial class Check_in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Check_in));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.btn_Sign = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.Error_panel = new System.Windows.Forms.Panel();
            this.lab_AlreadySignedIn = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer();
            this.CheckIn_pb1 = new System.Windows.Forms.PictureBox();
            this.notSigned_in_PB1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_box_Location = new System.Windows.Forms.ComboBox();
            this.lb_Number = new System.Windows.Forms.Label();
            this.combo_Box_Number = new System.Windows.Forms.ComboBox();
            this.Location_PB = new System.Windows.Forms.PictureBox();
            this.Lb_Location = new System.Windows.Forms.Label();
            this.panel_signIn = new System.Windows.Forms.Panel();
            this.leftPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.topPanel.SuspendLayout();
            this.Error_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckIn_pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notSigned_in_PB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Location_PB)).BeginInit();
            this.panel_signIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.leftPanel.Controls.Add(this.btn_Sign);
            this.leftPanel.Controls.Add(this.logoPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(239, 834);
            this.leftPanel.TabIndex = 2;
            // 
            // btn_Sign
            // 
            this.btn_Sign.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sign.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_Sign.Location = new System.Drawing.Point(0, 354);
            this.btn_Sign.Name = "btn_Sign";
            this.btn_Sign.Size = new System.Drawing.Size(239, 103);
            this.btn_Sign.TabIndex = 6;
            this.btn_Sign.Text = "Sign in";
            this.btn_Sign.UseVisualStyleBackColor = false;
            this.btn_Sign.Click += new System.EventHandler(this.btn_Sign_In);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.logoPanel.Controls.Add(this.panel1);
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
            this.lbX.Location = new System.Drawing.Point(810, 25);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(27, 26);
            this.lbX.TabIndex = 0;
            this.lbX.Text = "X";
            this.lbX.Click += new System.EventHandler(this.lbX_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(769, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "_";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.Error_panel);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.lbX);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(239, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(837, 191);
            this.topPanel.TabIndex = 3;
            // 
            // Error_panel
            // 
            this.Error_panel.Controls.Add(this.lab_AlreadySignedIn);
            this.Error_panel.Location = new System.Drawing.Point(50, 3);
            this.Error_panel.Name = "Error_panel";
            this.Error_panel.Size = new System.Drawing.Size(692, 188);
            this.Error_panel.TabIndex = 9;
            // 
            // lab_AlreadySignedIn
            // 
            this.lab_AlreadySignedIn.AutoSize = true;
            this.lab_AlreadySignedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_AlreadySignedIn.ForeColor = System.Drawing.Color.Black;
            this.lab_AlreadySignedIn.Location = new System.Drawing.Point(205, 77);
            this.lab_AlreadySignedIn.Name = "lab_AlreadySignedIn";
            this.lab_AlreadySignedIn.Size = new System.Drawing.Size(292, 46);
            this.lab_AlreadySignedIn.TabIndex = 7;
            this.lab_AlreadySignedIn.Text = "Camping Sight ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CheckIn_pb1
            // 
            this.CheckIn_pb1.Image = ((System.Drawing.Image)(resources.GetObject("CheckIn_pb1.Image")));
            this.CheckIn_pb1.InitialImage = ((System.Drawing.Image)(resources.GetObject("CheckIn_pb1.InitialImage")));
            this.CheckIn_pb1.Location = new System.Drawing.Point(239, 194);
            this.CheckIn_pb1.Name = "CheckIn_pb1";
            this.CheckIn_pb1.Size = new System.Drawing.Size(855, 637);
            this.CheckIn_pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CheckIn_pb1.TabIndex = 2;
            this.CheckIn_pb1.TabStop = false;
            // 
            // notSigned_in_PB1
            // 
            this.notSigned_in_PB1.Image = ((System.Drawing.Image)(resources.GetObject("notSigned_in_PB1.Image")));
            this.notSigned_in_PB1.InitialImage = ((System.Drawing.Image)(resources.GetObject("notSigned_in_PB1.InitialImage")));
            this.notSigned_in_PB1.Location = new System.Drawing.Point(245, 252);
            this.notSigned_in_PB1.Name = "notSigned_in_PB1";
            this.notSigned_in_PB1.Size = new System.Drawing.Size(855, 582);
            this.notSigned_in_PB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.notSigned_in_PB1.TabIndex = 4;
            this.notSigned_in_PB1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Camping Location";
            // 
            // combo_box_Location
            // 
            this.combo_box_Location.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.combo_box_Location.FormattingEnabled = true;
            this.combo_box_Location.Location = new System.Drawing.Point(437, 75);
            this.combo_box_Location.Name = "combo_box_Location";
            this.combo_box_Location.Size = new System.Drawing.Size(256, 33);
            this.combo_box_Location.TabIndex = 2;
            this.combo_box_Location.SelectedIndexChanged += new System.EventHandler(this.combo_box_Location_SelectedIndexChanged);
            // 
            // lb_Number
            // 
            this.lb_Number.AutoSize = true;
            this.lb_Number.Location = new System.Drawing.Point(143, 136);
            this.lb_Number.Name = "lb_Number";
            this.lb_Number.Size = new System.Drawing.Size(189, 26);
            this.lb_Number.TabIndex = 3;
            this.lb_Number.Text = "Number of Guests";
            // 
            // combo_Box_Number
            // 
            this.combo_Box_Number.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.combo_Box_Number.FormattingEnabled = true;
            this.combo_Box_Number.Location = new System.Drawing.Point(437, 136);
            this.combo_Box_Number.Name = "combo_Box_Number";
            this.combo_Box_Number.Size = new System.Drawing.Size(256, 33);
            this.combo_Box_Number.TabIndex = 4;
            this.combo_Box_Number.SelectedIndexChanged += new System.EventHandler(this.combo_Box_Number_SelectedIndexChanged);
            // 
            // Location_PB
            // 
            this.Location_PB.Image = ((System.Drawing.Image)(resources.GetObject("Location_PB.Image")));
            this.Location_PB.InitialImage = ((System.Drawing.Image)(resources.GetObject("Location_PB.InitialImage")));
            this.Location_PB.Location = new System.Drawing.Point(392, 200);
            this.Location_PB.Name = "Location_PB";
            this.Location_PB.Size = new System.Drawing.Size(430, 414);
            this.Location_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Location_PB.TabIndex = 5;
            this.Location_PB.TabStop = false;
            // 
            // Lb_Location
            // 
            this.Lb_Location.AutoSize = true;
            this.Lb_Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Location.Location = new System.Drawing.Point(71, 376);
            this.Lb_Location.Name = "Lb_Location";
            this.Lb_Location.Size = new System.Drawing.Size(284, 31);
            this.Lb_Location.TabIndex = 6;
            this.Lb_Location.Text = "Insert your card to pay";
            // 
            // panel_signIn
            // 
            this.panel_signIn.Controls.Add(this.Lb_Location);
            this.panel_signIn.Controls.Add(this.Location_PB);
            this.panel_signIn.Controls.Add(this.combo_Box_Number);
            this.panel_signIn.Controls.Add(this.lb_Number);
            this.panel_signIn.Controls.Add(this.combo_box_Location);
            this.panel_signIn.Controls.Add(this.label2);
            this.panel_signIn.Location = new System.Drawing.Point(239, 255);
            this.panel_signIn.Name = "panel_signIn";
            this.panel_signIn.Size = new System.Drawing.Size(933, 628);
            this.panel_signIn.TabIndex = 5;
            // 
            // Check_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1076, 834);
            this.Controls.Add(this.panel_signIn);
            this.Controls.Add(this.notSigned_in_PB1);
            this.Controls.Add(this.CheckIn_pb1);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "Check_in";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camping app";
            this.leftPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.Error_panel.ResumeLayout(false);
            this.Error_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckIn_pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notSigned_in_PB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Location_PB)).EndInit();
            this.panel_signIn.ResumeLayout(false);
            this.panel_signIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Sign;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbX;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox CheckIn_pb1;
        private System.Windows.Forms.PictureBox notSigned_in_PB1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lab_AlreadySignedIn;
        private System.Windows.Forms.Panel Error_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_box_Location;
        private System.Windows.Forms.Label lb_Number;
        private System.Windows.Forms.ComboBox combo_Box_Number;
        private System.Windows.Forms.PictureBox Location_PB;
        private System.Windows.Forms.Label Lb_Location;
        private System.Windows.Forms.Panel panel_signIn;
    }
}

