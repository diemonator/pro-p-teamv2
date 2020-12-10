namespace GUI
{
    partial class CustomerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerList));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Payment = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_RemoveList = new System.Windows.Forms.ListBox();
            this.pb_Animation = new System.Windows.Forms.PictureBox();
            this.pb_rfid = new System.Windows.Forms.PictureBox();
            this.leftPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Animation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rfid)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.leftPanel.Controls.Add(this.btn_Remove);
            this.leftPanel.Controls.Add(this.btn_Payment);
            this.leftPanel.Controls.Add(this.logoPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(140, 662);
            this.leftPanel.TabIndex = 2;
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_Remove.Location = new System.Drawing.Point(3, 290);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(137, 102);
            this.btn_Remove.TabIndex = 7;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = false;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Payment
            // 
            this.btn_Payment.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Payment.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_Payment.Location = new System.Drawing.Point(3, 169);
            this.btn_Payment.Name = "btn_Payment";
            this.btn_Payment.Size = new System.Drawing.Size(137, 102);
            this.btn_Payment.TabIndex = 6;
            this.btn_Payment.Text = "Payment";
            this.btn_Payment.UseVisualStyleBackColor = false;
            this.btn_Payment.Click += new System.EventHandler(this.btn_Buy_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.logoPanel.Controls.Add(this.pictureBox1);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(140, 113);
            this.logoPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbX.Location = new System.Drawing.Point(553, 21);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(27, 26);
            this.lbX.TabIndex = 0;
            this.lbX.Text = "X";
            this.lbX.Click += new System.EventHandler(this.lbX_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "_";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.label2);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.lbX);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(140, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(603, 113);
            this.topPanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Your Shoping Cart";
            // 
            // lb_RemoveList
            // 
            this.lb_RemoveList.FormattingEnabled = true;
            this.lb_RemoveList.ItemHeight = 25;
            this.lb_RemoveList.Location = new System.Drawing.Point(140, 108);
            this.lb_RemoveList.Name = "lb_RemoveList";
            this.lb_RemoveList.Size = new System.Drawing.Size(603, 554);
            this.lb_RemoveList.TabIndex = 4;
            // 
            // pb_Animation
            // 
            this.pb_Animation.Location = new System.Drawing.Point(328, 255);
            this.pb_Animation.Name = "pb_Animation";
            this.pb_Animation.Size = new System.Drawing.Size(201, 168);
            this.pb_Animation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Animation.TabIndex = 17;
            this.pb_Animation.TabStop = false;
            // 
            // pb_rfid
            // 
            this.pb_rfid.Enabled = false;
            this.pb_rfid.Image = ((System.Drawing.Image)(resources.GetObject("pb_rfid.Image")));
            this.pb_rfid.Location = new System.Drawing.Point(246, 214);
            this.pb_rfid.Name = "pb_rfid";
            this.pb_rfid.Size = new System.Drawing.Size(375, 311);
            this.pb_rfid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_rfid.TabIndex = 8;
            this.pb_rfid.TabStop = false;
            this.pb_rfid.Visible = false;
            // 
            // CustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(743, 662);
            this.Controls.Add(this.pb_rfid);
            this.Controls.Add(this.pb_Animation);
            this.Controls.Add(this.lb_RemoveList);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "CustomerList";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoodStand";
            this.leftPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Animation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rfid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.ListBox lb_RemoveList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Payment;
        private System.Windows.Forms.PictureBox pb_Animation;
        private System.Windows.Forms.PictureBox pb_rfid;
    }
}

