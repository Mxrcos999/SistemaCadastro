
namespace dashboard
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Pnl_Ofc = new System.Windows.Forms.Panel();
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.Btn_Settings = new System.Windows.Forms.Button();
            this.Btn_Contact = new System.Windows.Forms.Button();
            this.Btn_Calender = new System.Windows.Forms.Button();
            this.Btn_Analytics = new System.Windows.Forms.Button();
            this.Btn_DashBoard = new System.Windows.Forms.Button();
            this.Pnlla = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Txt_Search = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Pnl_Ofc.SuspendLayout();
            this.pnlNav.SuspendLayout();
            this.Pnlla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Ofc
            // 
            this.Pnl_Ofc.Controls.Add(this.PnlFormLoader);
            this.Pnl_Ofc.Controls.Add(this.pnlNav);
            this.Pnl_Ofc.Controls.Add(this.Btn_Exit);
            this.Pnl_Ofc.Controls.Add(this.Txt_Search);
            this.Pnl_Ofc.Controls.Add(this.lblTitle);
            this.Pnl_Ofc.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Ofc.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Ofc.Name = "Pnl_Ofc";
            this.Pnl_Ofc.Size = new System.Drawing.Size(951, 577);
            this.Pnl_Ofc.TabIndex = 0;
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFormLoader.Location = new System.Drawing.Point(186, 93);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(765, 484);
            this.PnlFormLoader.TabIndex = 9;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlNav.Controls.Add(this.button1);
            this.pnlNav.Controls.Add(this.Btn_Settings);
            this.pnlNav.Controls.Add(this.Btn_Contact);
            this.pnlNav.Controls.Add(this.Btn_Calender);
            this.pnlNav.Controls.Add(this.Btn_Analytics);
            this.pnlNav.Controls.Add(this.Btn_DashBoard);
            this.pnlNav.Controls.Add(this.Pnlla);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(186, 577);
            this.pnlNav.TabIndex = 5;
            // 
            // Btn_Settings
            // 
            this.Btn_Settings.FlatAppearance.BorderSize = 0;
            this.Btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Settings.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn_Settings.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Settings.Image")));
            this.Btn_Settings.Location = new System.Drawing.Point(0, 318);
            this.Btn_Settings.Name = "Btn_Settings";
            this.Btn_Settings.Size = new System.Drawing.Size(186, 42);
            this.Btn_Settings.TabIndex = 5;
            this.Btn_Settings.Text = "Settings";
            this.Btn_Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_Settings.UseVisualStyleBackColor = true;
            this.Btn_Settings.Click += new System.EventHandler(this.Btn_Settings_Click_1);
            // 
            // Btn_Contact
            // 
            this.Btn_Contact.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Contact.FlatAppearance.BorderSize = 0;
            this.Btn_Contact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Contact.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Contact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn_Contact.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Contact.Image")));
            this.Btn_Contact.Location = new System.Drawing.Point(0, 270);
            this.Btn_Contact.Name = "Btn_Contact";
            this.Btn_Contact.Size = new System.Drawing.Size(186, 42);
            this.Btn_Contact.TabIndex = 4;
            this.Btn_Contact.Text = "Contact Us";
            this.Btn_Contact.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_Contact.UseVisualStyleBackColor = true;
            this.Btn_Contact.Click += new System.EventHandler(this.Btn_Contact_Click_1);
            // 
            // Btn_Calender
            // 
            this.Btn_Calender.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Calender.FlatAppearance.BorderSize = 0;
            this.Btn_Calender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Calender.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Calender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn_Calender.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Calender.Image")));
            this.Btn_Calender.Location = new System.Drawing.Point(0, 228);
            this.Btn_Calender.Name = "Btn_Calender";
            this.Btn_Calender.Size = new System.Drawing.Size(186, 42);
            this.Btn_Calender.TabIndex = 3;
            this.Btn_Calender.Text = "Calender";
            this.Btn_Calender.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_Calender.UseVisualStyleBackColor = true;
            this.Btn_Calender.Click += new System.EventHandler(this.Btn_Calender_Click_1);
            // 
            // Btn_Analytics
            // 
            this.Btn_Analytics.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Analytics.FlatAppearance.BorderSize = 0;
            this.Btn_Analytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Analytics.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Analytics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn_Analytics.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Analytics.Image")));
            this.Btn_Analytics.Location = new System.Drawing.Point(0, 186);
            this.Btn_Analytics.Name = "Btn_Analytics";
            this.Btn_Analytics.Size = new System.Drawing.Size(186, 42);
            this.Btn_Analytics.TabIndex = 2;
            this.Btn_Analytics.Text = "Analytics";
            this.Btn_Analytics.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_Analytics.UseVisualStyleBackColor = true;
            this.Btn_Analytics.Click += new System.EventHandler(this.Btn_Analytics_Click_2);
            // 
            // Btn_DashBoard
            // 
            this.Btn_DashBoard.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_DashBoard.FlatAppearance.BorderSize = 0;
            this.Btn_DashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DashBoard.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_DashBoard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn_DashBoard.Image = ((System.Drawing.Image)(resources.GetObject("Btn_DashBoard.Image")));
            this.Btn_DashBoard.Location = new System.Drawing.Point(0, 144);
            this.Btn_DashBoard.Name = "Btn_DashBoard";
            this.Btn_DashBoard.Size = new System.Drawing.Size(186, 42);
            this.Btn_DashBoard.TabIndex = 1;
            this.Btn_DashBoard.Text = "Dashbord";
            this.Btn_DashBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_DashBoard.UseVisualStyleBackColor = true;
            this.Btn_DashBoard.Click += new System.EventHandler(this.Btn_DashBoard_Click);
            // 
            // Pnlla
            // 
            this.Pnlla.Controls.Add(this.label2);
            this.Pnlla.Controls.Add(this.Lbl_Name);
            this.Pnlla.Controls.Add(this.pictureBox1);
            this.Pnlla.Cursor = System.Windows.Forms.Cursors.Default;
            this.Pnlla.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnlla.Location = new System.Drawing.Point(0, 0);
            this.Pnlla.Name = "Pnlla";
            this.Pnlla.Size = new System.Drawing.Size(186, 144);
            this.Pnlla.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label2.Location = new System.Drawing.Point(60, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "logged in user";
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.Lbl_Name.Location = new System.Drawing.Point(60, 93);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(82, 16);
            this.Lbl_Name.TabIndex = 1;
            this.Lbl_Name.Text = "User name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.FlatAppearance.BorderSize = 0;
            this.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Exit.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Exit.ForeColor = System.Drawing.Color.White;
            this.Btn_Exit.Location = new System.Drawing.Point(914, 27);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(25, 27);
            this.Btn_Exit.TabIndex = 8;
            this.Btn_Exit.Text = "X";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click_1);
            // 
            // Txt_Search
            // 
            this.Txt_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.Txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Search.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Search.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Txt_Search.Location = new System.Drawing.Point(609, 45);
            this.Txt_Search.Multiline = true;
            this.Txt_Search.Name = "Txt_Search";
            this.Txt_Search.Size = new System.Drawing.Size(292, 27);
            this.Txt_Search.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblTitle.Location = new System.Drawing.Point(226, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(148, 32);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "DashBord";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Logout";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.Pnl_Ofc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Pnl_Ofc.ResumeLayout(false);
            this.Pnl_Ofc.PerformLayout();
            this.pnlNav.ResumeLayout(false);
            this.Pnlla.ResumeLayout(false);
            this.Pnlla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Ofc;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button Btn_Settings;
        private System.Windows.Forms.Button Btn_Contact;
        private System.Windows.Forms.Button Btn_Calender;
        private System.Windows.Forms.Button Btn_Analytics;
        private System.Windows.Forms.Button Btn_DashBoard;
        private System.Windows.Forms.Panel Pnlla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.TextBox Txt_Search;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel PnlFormLoader;
        private System.Windows.Forms.Button button1;
    }
}

