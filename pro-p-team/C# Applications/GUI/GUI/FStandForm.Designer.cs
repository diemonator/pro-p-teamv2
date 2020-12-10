namespace GUI
{
    partial class FStandForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FStandForm));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.btn_backToShop = new System.Windows.Forms.Button();
            this.btn_removeFromList = new System.Windows.Forms.Button();
            this.btn_ViewList = new System.Windows.Forms.Button();
            this.btn_Food = new System.Windows.Forms.Button();
            this.btn_Buy = new System.Windows.Forms.Button();
            this.btn_Drinks = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_BasketCount = new System.Windows.Forms.Label();
            this.lb_Shop = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pb_rfid = new System.Windows.Forms.PictureBox();
            this.lb_sum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pb_MainAnim = new System.Windows.Forms.PictureBox();
            this.lab_status = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rfid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MainAnim)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.leftPanel.Controls.Add(this.btn_backToShop);
            this.leftPanel.Controls.Add(this.btn_removeFromList);
            this.leftPanel.Controls.Add(this.btn_ViewList);
            this.leftPanel.Controls.Add(this.btn_Food);
            this.leftPanel.Controls.Add(this.btn_Buy);
            this.leftPanel.Controls.Add(this.btn_Drinks);
            this.leftPanel.Controls.Add(this.logoPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(239, 834);
            this.leftPanel.TabIndex = 2;
            // 
            // btn_backToShop
            // 
            this.btn_backToShop.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_backToShop.Enabled = false;
            this.btn_backToShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backToShop.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_backToShop.Location = new System.Drawing.Point(0, 605);
            this.btn_backToShop.Name = "btn_backToShop";
            this.btn_backToShop.Size = new System.Drawing.Size(239, 104);
            this.btn_backToShop.TabIndex = 9;
            this.btn_backToShop.Text = "Resume Shoping";
            this.btn_backToShop.UseVisualStyleBackColor = false;
            this.btn_backToShop.Visible = false;
            this.btn_backToShop.Click += new System.EventHandler(this.btn_backToShop_Click);
            // 
            // btn_removeFromList
            // 
            this.btn_removeFromList.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_removeFromList.Enabled = false;
            this.btn_removeFromList.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeFromList.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_removeFromList.Location = new System.Drawing.Point(0, 727);
            this.btn_removeFromList.Name = "btn_removeFromList";
            this.btn_removeFromList.Size = new System.Drawing.Size(239, 104);
            this.btn_removeFromList.TabIndex = 8;
            this.btn_removeFromList.Text = "Remove";
            this.btn_removeFromList.UseVisualStyleBackColor = false;
            this.btn_removeFromList.Visible = false;
            this.btn_removeFromList.Click += new System.EventHandler(this.btn_removeFromList_Click);
            // 
            // btn_ViewList
            // 
            this.btn_ViewList.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_ViewList.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewList.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_ViewList.Location = new System.Drawing.Point(0, 624);
            this.btn_ViewList.Name = "btn_ViewList";
            this.btn_ViewList.Size = new System.Drawing.Size(239, 104);
            this.btn_ViewList.TabIndex = 7;
            this.btn_ViewList.Text = "OpenCart";
            this.btn_ViewList.UseVisualStyleBackColor = false;
            this.btn_ViewList.Click += new System.EventHandler(this.btn_ViewList_Click);
            // 
            // btn_Food
            // 
            this.btn_Food.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Food.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Food.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_Food.Location = new System.Drawing.Point(0, 368);
            this.btn_Food.Name = "btn_Food";
            this.btn_Food.Size = new System.Drawing.Size(239, 103);
            this.btn_Food.TabIndex = 6;
            this.btn_Food.Text = "Foods";
            this.btn_Food.UseVisualStyleBackColor = false;
            this.btn_Food.Click += new System.EventHandler(this.btn_Food_Click);
            // 
            // btn_Buy
            // 
            this.btn_Buy.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Buy.Enabled = false;
            this.btn_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buy.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_Buy.Location = new System.Drawing.Point(0, 489);
            this.btn_Buy.Name = "btn_Buy";
            this.btn_Buy.Size = new System.Drawing.Size(239, 104);
            this.btn_Buy.TabIndex = 2;
            this.btn_Buy.Text = "Buy";
            this.btn_Buy.UseVisualStyleBackColor = false;
            this.btn_Buy.Click += new System.EventHandler(this.btn_Buy_Click);
            // 
            // btn_Drinks
            // 
            this.btn_Drinks.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Drinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Drinks.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_Drinks.Location = new System.Drawing.Point(-3, 237);
            this.btn_Drinks.Name = "btn_Drinks";
            this.btn_Drinks.Size = new System.Drawing.Size(242, 109);
            this.btn_Drinks.TabIndex = 5;
            this.btn_Drinks.Text = "Drinks";
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
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbX.Location = new System.Drawing.Point(1333, 9);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(27, 26);
            this.lbX.TabIndex = 0;
            this.lbX.Text = "X";
            this.lbX.Click += new System.EventHandler(this.lbX_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1292, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "_";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.lab_status);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.lbX);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(239, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1372, 191);
            this.topPanel.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // lb_BasketCount
            // 
            this.lb_BasketCount.AutoSize = true;
            this.lb_BasketCount.Location = new System.Drawing.Point(1496, 744);
            this.lb_BasketCount.Name = "lb_BasketCount";
            this.lb_BasketCount.Size = new System.Drawing.Size(24, 26);
            this.lb_BasketCount.TabIndex = 5;
            this.lb_BasketCount.Text = "0";
            // 
            // lb_Shop
            // 
            this.lb_Shop.FormattingEnabled = true;
            this.lb_Shop.ItemHeight = 25;
            this.lb_Shop.Location = new System.Drawing.Point(928, 743);
            this.lb_Shop.Name = "lb_Shop";
            this.lb_Shop.Size = new System.Drawing.Size(502, 79);
            this.lb_Shop.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(1436, 702);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pb_rfid
            // 
            this.pb_rfid.Enabled = false;
            this.pb_rfid.Image = ((System.Drawing.Image)(resources.GetObject("pb_rfid.Image")));
            this.pb_rfid.Location = new System.Drawing.Point(377, 684);
            this.pb_rfid.Name = "pb_rfid";
            this.pb_rfid.Size = new System.Drawing.Size(161, 138);
            this.pb_rfid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_rfid.TabIndex = 9;
            this.pb_rfid.TabStop = false;
            this.pb_rfid.Visible = false;
            // 
            // lb_sum
            // 
            this.lb_sum.AutoSize = true;
            this.lb_sum.Location = new System.Drawing.Point(1513, 658);
            this.lb_sum.Name = "lb_sum";
            this.lb_sum.Size = new System.Drawing.Size(24, 26);
            this.lb_sum.TabIndex = 7;
            this.lb_sum.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1431, 658);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total ->";
            // 
            // pb_MainAnim
            // 
            this.pb_MainAnim.Enabled = false;
            this.pb_MainAnim.Location = new System.Drawing.Point(377, 684);
            this.pb_MainAnim.Name = "pb_MainAnim";
            this.pb_MainAnim.Size = new System.Drawing.Size(161, 138);
            this.pb_MainAnim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_MainAnim.TabIndex = 12;
            this.pb_MainAnim.TabStop = false;
            this.pb_MainAnim.Visible = false;
            // 
            // lab_status
            // 
            this.lab_status.AutoSize = true;
            this.lab_status.Location = new System.Drawing.Point(244, 82);
            this.lab_status.Name = "lab_status";
            this.lab_status.Size = new System.Drawing.Size(0, 26);
            this.lab_status.TabIndex = 13;
            // 
            // FStandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1611, 834);
            this.Controls.Add(this.pb_MainAnim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_sum);
            this.Controls.Add(this.pb_rfid);
            this.Controls.Add(this.lb_Shop);
            this.Controls.Add(this.lb_BasketCount);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "FStandForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoodStand";
            this.leftPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rfid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MainAnim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Food;
        private System.Windows.Forms.Button btn_Drinks;
        private System.Windows.Forms.Button btn_Buy;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbX;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb_BasketCount;
        private System.Windows.Forms.ListBox lb_Shop;
        private System.Windows.Forms.PictureBox pb_rfid;
        private System.Windows.Forms.Label lb_sum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pb_MainAnim;
        private System.Windows.Forms.Button btn_ViewList;
        private System.Windows.Forms.Button btn_removeFromList;
        private System.Windows.Forms.Button btn_backToShop;
        private System.Windows.Forms.Label lab_status;
    }
}

