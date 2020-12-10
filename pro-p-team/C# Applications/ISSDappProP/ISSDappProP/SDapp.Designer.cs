namespace ISSDappProP
{
    partial class SDapp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SDapp));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.btn_create_new_order = new System.Windows.Forms.Button();
            this.btn_return_item = new System.Windows.Forms.Button();
            this.btn_Drinks = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lbX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbCamera = new System.Windows.Forms.PictureBox();
            this.pbSpeakers = new System.Windows.Forms.PictureBox();
            this.pbPhone = new System.Windows.Forms.PictureBox();
            this.pbHeadphone = new System.Windows.Forms.PictureBox();
            this.pbRFID = new System.Windows.Forms.PictureBox();
            this.pbLaptop = new System.Windows.Forms.PictureBox();
            this.pbMicrophone = new System.Windows.Forms.PictureBox();
            this.pbMonitor = new System.Windows.Forms.PictureBox();
            this.lbOrder = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpeakers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeadphone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRFID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLaptop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMicrophone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonitor)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.leftPanel.Controls.Add(this.btn_create_new_order);
            this.leftPanel.Controls.Add(this.btn_return_item);
            this.leftPanel.Controls.Add(this.btn_Drinks);
            this.leftPanel.Controls.Add(this.logoPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(239, 580);
            this.leftPanel.TabIndex = 2;
            // 
            // btn_create_new_order
            // 
            this.btn_create_new_order.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_create_new_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create_new_order.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_create_new_order.Location = new System.Drawing.Point(-3, 200);
            this.btn_create_new_order.Name = "btn_create_new_order";
            this.btn_create_new_order.Size = new System.Drawing.Size(242, 109);
            this.btn_create_new_order.TabIndex = 6;
            this.btn_create_new_order.Text = "Create New Order";
            this.btn_create_new_order.UseVisualStyleBackColor = false;
            this.btn_create_new_order.Click += new System.EventHandler(this.btn_create_new_order_Click);
            // 
            // btn_return_item
            // 
            this.btn_return_item.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_return_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return_item.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_return_item.Location = new System.Drawing.Point(0, 464);
            this.btn_return_item.Name = "btn_return_item";
            this.btn_return_item.Size = new System.Drawing.Size(239, 104);
            this.btn_return_item.TabIndex = 4;
            this.btn_return_item.Text = "Return Item";
            this.btn_return_item.UseVisualStyleBackColor = false;
            this.btn_return_item.Click += new System.EventHandler(this.btn_return_item_Click);
            // 
            // btn_Drinks
            // 
            this.btn_Drinks.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Drinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Drinks.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_Drinks.Location = new System.Drawing.Point(0, 334);
            this.btn_Drinks.Name = "btn_Drinks";
            this.btn_Drinks.Size = new System.Drawing.Size(242, 109);
            this.btn_Drinks.TabIndex = 5;
            this.btn_Drinks.Text = "Rent";
            this.btn_Drinks.UseVisualStyleBackColor = false;
            this.btn_Drinks.Click += new System.EventHandler(this.btn_Drinks_Click);
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
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbX.Location = new System.Drawing.Point(734, 18);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(27, 26);
            this.lbX.TabIndex = 0;
            this.lbX.Text = "X";
            this.lbX.Click += new System.EventHandler(this.lbX_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(704, 9);
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
            this.topPanel.Location = new System.Drawing.Point(239, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(773, 191);
            this.topPanel.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // pbCamera
            // 
            this.pbCamera.Image = ((System.Drawing.Image)(resources.GetObject("pbCamera.Image")));
            this.pbCamera.Location = new System.Drawing.Point(412, 262);
            this.pbCamera.Name = "pbCamera";
            this.pbCamera.Size = new System.Drawing.Size(111, 102);
            this.pbCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCamera.TabIndex = 4;
            this.pbCamera.TabStop = false;
            this.pbCamera.Click += new System.EventHandler(this.pictureBoxClick);
            // 
            // pbSpeakers
            // 
            this.pbSpeakers.Image = ((System.Drawing.Image)(resources.GetObject("pbSpeakers.Image")));
            this.pbSpeakers.Location = new System.Drawing.Point(576, 262);
            this.pbSpeakers.Name = "pbSpeakers";
            this.pbSpeakers.Size = new System.Drawing.Size(111, 102);
            this.pbSpeakers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSpeakers.TabIndex = 5;
            this.pbSpeakers.TabStop = false;
            this.pbSpeakers.Click += new System.EventHandler(this.pictureBoxClick);
            // 
            // pbPhone
            // 
            this.pbPhone.Image = ((System.Drawing.Image)(resources.GetObject("pbPhone.Image")));
            this.pbPhone.Location = new System.Drawing.Point(725, 262);
            this.pbPhone.Name = "pbPhone";
            this.pbPhone.Size = new System.Drawing.Size(111, 102);
            this.pbPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhone.TabIndex = 6;
            this.pbPhone.TabStop = false;
            this.pbPhone.Click += new System.EventHandler(this.pictureBoxClick);
            // 
            // pbHeadphone
            // 
            this.pbHeadphone.Image = ((System.Drawing.Image)(resources.GetObject("pbHeadphone.Image")));
            this.pbHeadphone.Location = new System.Drawing.Point(878, 262);
            this.pbHeadphone.Name = "pbHeadphone";
            this.pbHeadphone.Size = new System.Drawing.Size(111, 102);
            this.pbHeadphone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHeadphone.TabIndex = 7;
            this.pbHeadphone.TabStop = false;
            this.pbHeadphone.Click += new System.EventHandler(this.pictureBoxClick);
            // 
            // pbRFID
            // 
            this.pbRFID.Image = ((System.Drawing.Image)(resources.GetObject("pbRFID.Image")));
            this.pbRFID.Location = new System.Drawing.Point(412, 407);
            this.pbRFID.Name = "pbRFID";
            this.pbRFID.Size = new System.Drawing.Size(111, 102);
            this.pbRFID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRFID.TabIndex = 8;
            this.pbRFID.TabStop = false;
            this.pbRFID.Click += new System.EventHandler(this.pictureBoxClick);
            // 
            // pbLaptop
            // 
            this.pbLaptop.Image = ((System.Drawing.Image)(resources.GetObject("pbLaptop.Image")));
            this.pbLaptop.Location = new System.Drawing.Point(576, 407);
            this.pbLaptop.Name = "pbLaptop";
            this.pbLaptop.Size = new System.Drawing.Size(111, 102);
            this.pbLaptop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLaptop.TabIndex = 9;
            this.pbLaptop.TabStop = false;
            this.pbLaptop.Click += new System.EventHandler(this.pictureBoxClick);
            // 
            // pbMicrophone
            // 
            this.pbMicrophone.Image = ((System.Drawing.Image)(resources.GetObject("pbMicrophone.Image")));
            this.pbMicrophone.Location = new System.Drawing.Point(725, 407);
            this.pbMicrophone.Name = "pbMicrophone";
            this.pbMicrophone.Size = new System.Drawing.Size(111, 102);
            this.pbMicrophone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMicrophone.TabIndex = 10;
            this.pbMicrophone.TabStop = false;
            this.pbMicrophone.Click += new System.EventHandler(this.pictureBoxClick);
            // 
            // pbMonitor
            // 
            this.pbMonitor.Image = ((System.Drawing.Image)(resources.GetObject("pbMonitor.Image")));
            this.pbMonitor.Location = new System.Drawing.Point(878, 407);
            this.pbMonitor.Name = "pbMonitor";
            this.pbMonitor.Size = new System.Drawing.Size(111, 102);
            this.pbMonitor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMonitor.TabIndex = 11;
            this.pbMonitor.TabStop = false;
            this.pbMonitor.Click += new System.EventHandler(this.pictureBoxClick);
            // 
            // lbOrder
            // 
            this.lbOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrder.FormattingEnabled = true;
            this.lbOrder.Location = new System.Drawing.Point(245, 237);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(151, 277);
            this.lbOrder.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(696, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please select the items that you want to rent";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SDapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1012, 580);
            this.Controls.Add(this.lbOrder);
            this.Controls.Add(this.pbMonitor);
            this.Controls.Add(this.pbMicrophone);
            this.Controls.Add(this.pbLaptop);
            this.Controls.Add(this.pbRFID);
            this.Controls.Add(this.pbHeadphone);
            this.Controls.Add(this.pbPhone);
            this.Controls.Add(this.pbSpeakers);
            this.Controls.Add(this.pbCamera);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "SDapp";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoodStand";
            this.leftPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpeakers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeadphone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRFID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLaptop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMicrophone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonitor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btn_return_item;
        private System.Windows.Forms.Button btn_Drinks;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbX;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbMonitor;
        private System.Windows.Forms.PictureBox pbMicrophone;
        private System.Windows.Forms.PictureBox pbLaptop;
        private System.Windows.Forms.PictureBox pbRFID;
        private System.Windows.Forms.PictureBox pbHeadphone;
        private System.Windows.Forms.PictureBox pbPhone;
        private System.Windows.Forms.PictureBox pbSpeakers;
        private System.Windows.Forms.PictureBox pbCamera;
        private System.Windows.Forms.ListBox lbOrder;
        private System.Windows.Forms.Button btn_create_new_order;
        private System.Windows.Forms.Label label2;
    }
}

