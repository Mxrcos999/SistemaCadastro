using dashboard.data;
using dashboard.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dashboard
{
    public partial class Frm_Login : Form
    {
        public string name { get; set; }
        public string pass { get; set; }
        
        public Frm_Login(string _name,string _senha)
        {
            InitializeComponent();
            name = _name;
            pass = _senha;

        }
       
   

        private void Btn_Login_Click_1(object sender, EventArgs e)
        {
            var log = new UserDAO();
        
            if(log.login(Txt_UserN.Text, Txt_Passw.Text))
            {
                this.Pnl_Login.Controls.Clear();
                Form1 frmDashboard_vrb = new Form1(Txt_UserN.Text) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
                Pnl_Login.Controls.Add(frmDashboard_vrb);
                frmDashboard_vrb.Show();
            }
            else
            {
                MessageBox.Show("Incorrect username or password", "Err", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }


        }
        
        private void Btn_Close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Chk_Pass_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Pass.Checked)
            {
                Txt_Passw.PasswordChar = '\0';
                Chk_Pass.Text = "hide password";



            }
            else
            {
                Txt_Passw.PasswordChar = '*';
                Chk_Pass.Text = "show password";
            }
        }

   
        private void button1_Click(object sender, EventArgs e)
        {
            this.Pnl_Login.Controls.Clear();
            Frm_UserRegistration frmDashboard_vrb = new Frm_UserRegistration() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.Pnl_Login.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();
        }


    }
}
