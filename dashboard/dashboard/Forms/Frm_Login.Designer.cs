
namespace dashboard
{
    partial class Frm_Login
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
            this.Pnl_Login = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Chk_Pass = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Txt_UserN = new System.Windows.Forms.TextBox();
            this.Txt_Passw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Pnl_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Login
            // 
            this.Pnl_Login.Controls.Add(this.button1);
            this.Pnl_Login.Controls.Add(this.Chk_Pass);
            this.Pnl_Login.Controls.Add(this.label3);
            this.Pnl_Login.Controls.Add(this.Btn_Close);
            this.Pnl_Login.Controls.Add(this.Txt_UserN);
            this.Pnl_Login.Controls.Add(this.Txt_Passw);
            this.Pnl_Login.Controls.Add(this.label2);
            this.Pnl_Login.Controls.Add(this.label1);
            this.Pnl_Login.Controls.Add(this.Btn_Login);
            this.Pnl_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pnl_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Login.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Login.Name = "Pnl_Login";
            this.Pnl_Login.Size = new System.Drawing.Size(951, 577);
            this.Pnl_Login.TabIndex = 0;
            this.Pnl_Login.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_Login_Paint_1);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.Location = new System.Drawing.Point(369, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Don\'t have an account yet? register now";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Chk_Pass
            // 
            this.Chk_Pass.AutoSize = true;
            this.Chk_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Chk_Pass.ForeColor = System.Drawing.Color.White;
            this.Chk_Pass.Location = new System.Drawing.Point(403, 341);
            this.Chk_Pass.Name = "Chk_Pass";
            this.Chk_Pass.Size = new System.Drawing.Size(122, 20);
            this.Chk_Pass.TabIndex = 3;
            this.Chk_Pass.Text = "Show Password";
            this.Chk_Pass.UseVisualStyleBackColor = true;
            this.Chk_Pass.CheckedChanged += new System.EventHandler(this.Chk_Pass_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(331, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 40);
            this.label3.TabIndex = 18;
            this.label3.Text = "log into your account";
            // 
            // Btn_Close
            // 
            this.Btn_Close.FlatAppearance.BorderSize = 0;
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Close.ForeColor = System.Drawing.Color.White;
            this.Btn_Close.Location = new System.Drawing.Point(862, 31);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(46, 24);
            this.Btn_Close.TabIndex = 17;
            this.Btn_Close.Text = "X";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click_1);
            // 
            // Txt_UserN
            // 
            this.Txt_UserN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Txt_UserN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_UserN.Location = new System.Drawing.Point(403, 210);
            this.Txt_UserN.Name = "Txt_UserN";
            this.Txt_UserN.Size = new System.Drawing.Size(173, 23);
            this.Txt_UserN.TabIndex = 1;
            // 
            // Txt_Passw
            // 
            this.Txt_Passw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Txt_Passw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Passw.Location = new System.Drawing.Point(403, 311);
            this.Txt_Passw.Name = "Txt_Passw";
            this.Txt_Passw.PasswordChar = '*';
            this.Txt_Passw.Size = new System.Drawing.Size(173, 23);
            this.Txt_Passw.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label2.Location = new System.Drawing.Point(403, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "PassWord";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(403, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Username";
            // 
            // Btn_Login
            // 
            this.Btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Login.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Btn_Login.Location = new System.Drawing.Point(438, 372);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(101, 34);
            this.Btn_Login.TabIndex = 4;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click_1);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.Pnl_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Login";
            this.Pnl_Login.ResumeLayout(false);
            this.Pnl_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Login;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.TextBox Txt_UserN;
        private System.Windows.Forms.TextBox Txt_Passw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Chk_Pass;
        private System.Windows.Forms.Button button1;
    }
}