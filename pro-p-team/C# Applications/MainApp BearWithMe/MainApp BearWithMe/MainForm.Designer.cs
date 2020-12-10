namespace MainApp_BearWithMe
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Camping_Init = new System.Windows.Forms.Button();
            this.btn_SD_Init = new System.Windows.Forms.Button();
            this.btn_PayPal_Init = new System.Windows.Forms.Button();
            this.btn_Food_Init = new System.Windows.Forms.Button();
            this.lbX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Entrance_Init = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.leftPanel.Controls.Add(this.button1);
            this.leftPanel.Controls.Add(this.logoPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(239, 727);
            this.leftPanel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Honeydew;
            this.button1.Location = new System.Drawing.Point(0, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 104);
            this.button1.TabIndex = 10;
            this.button1.Text = "Client Entrance App";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // btn_Camping_Init
            // 
            this.btn_Camping_Init.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Camping_Init.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Camping_Init.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_Camping_Init.Location = new System.Drawing.Point(791, 251);
            this.btn_Camping_Init.Name = "btn_Camping_Init";
            this.btn_Camping_Init.Size = new System.Drawing.Size(247, 103);
            this.btn_Camping_Init.TabIndex = 6;
            this.btn_Camping_Init.Text = "CampingSight App";
            this.btn_Camping_Init.UseVisualStyleBackColor = false;
            this.btn_Camping_Init.Click += new System.EventHandler(this.btn_Camping_Init_Click);
            // 
            // btn_SD_Init
            // 
            this.btn_SD_Init.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_SD_Init.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SD_Init.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_SD_Init.Location = new System.Drawing.Point(365, 425);
            this.btn_SD_Init.Name = "btn_SD_Init";
            this.btn_SD_Init.Size = new System.Drawing.Size(247, 104);
            this.btn_SD_Init.TabIndex = 2;
            this.btn_SD_Init.Text = "SD App";
            this.btn_SD_Init.UseVisualStyleBackColor = false;
            this.btn_SD_Init.Click += new System.EventHandler(this.btn_SD_Init_Click);
            // 
            // btn_PayPal_Init
            // 
            this.btn_PayPal_Init.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_PayPal_Init.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PayPal_Init.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_PayPal_Init.Location = new System.Drawing.Point(362, 245);
            this.btn_PayPal_Init.Name = "btn_PayPal_Init";
            this.btn_PayPal_Init.Size = new System.Drawing.Size(250, 109);
            this.btn_PayPal_Init.TabIndex = 5;
            this.btn_PayPal_Init.Text = "PayPal App";
            this.btn_PayPal_Init.UseVisualStyleBackColor = false;
            this.btn_PayPal_Init.Click += new System.EventHandler(this.btn_PayPal_Init_Click);
            // 
            // btn_Food_Init
            // 
            this.btn_Food_Init.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Food_Init.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Food_Init.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_Food_Init.Location = new System.Drawing.Point(791, 425);
            this.btn_Food_Init.Name = "btn_Food_Init";
            this.btn_Food_Init.Size = new System.Drawing.Size(247, 104);
            this.btn_Food_Init.TabIndex = 3;
            this.btn_Food_Init.Text = "Food Stand App";
            this.btn_Food_Init.UseVisualStyleBackColor = false;
            this.btn_Food_Init.Click += new System.EventHandler(this.btn_Food_Init_Click);
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbX.Location = new System.Drawing.Point(772, 21);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(27, 26);
            this.lbX.TabIndex = 0;
            this.lbX.Text = "X";
            this.lbX.Click += new System.EventHandler(this.lbX_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(731, 12);
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
            this.topPanel.Size = new System.Drawing.Size(831, 191);
            this.topPanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 39.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 64);
            this.label2.TabIndex = 10;
            this.label2.Text = "Choose your app";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // btn_Entrance_Init
            // 
            this.btn_Entrance_Init.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Entrance_Init.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Entrance_Init.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_Entrance_Init.Location = new System.Drawing.Point(365, 586);
            this.btn_Entrance_Init.Name = "btn_Entrance_Init";
            this.btn_Entrance_Init.Size = new System.Drawing.Size(247, 104);
            this.btn_Entrance_Init.TabIndex = 7;
            this.btn_Entrance_Init.Text = "Entrance App";
            this.btn_Entrance_Init.UseVisualStyleBackColor = false;
            this.btn_Entrance_Init.Click += new System.EventHandler(this.btn_Entrance_Init_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Honeydew;
            this.button2.Location = new System.Drawing.Point(791, 586);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 104);
            this.button2.TabIndex = 9;
            this.button2.Text = "History App";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1070, 727);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Entrance_Init);
            this.Controls.Add(this.btn_Camping_Init);
            this.Controls.Add(this.btn_Food_Init);
            this.Controls.Add(this.btn_SD_Init);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.btn_PayPal_Init);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main app";
            this.leftPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Food_Init;
        private System.Windows.Forms.Button btn_Camping_Init;
        private System.Windows.Forms.Button btn_PayPal_Init;
        private System.Windows.Forms.Button btn_SD_Init;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbX;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Entrance_Init;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

