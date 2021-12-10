using dashboard.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dashboard
{
    public partial class Form1 : Form
    {
     
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public string name { get; set; }
        public Form1(string _name )
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            name = _name;
         

        }
      

    
        public void Form1_Load(object sender, EventArgs e)
        {
            Txt_Search.PlaceholderText = "Search For Something";
            Lbl_Name.Text = name.Trim();

        }

    
        private void Btn_DashBoard_Leave(object sender, EventArgs e)
        {
            Btn_DashBoard.BackColor = Color.FromArgb(24, 30, 54);

        }

     

 


      

  
        private void Btn_Calender_Click_1(object sender, EventArgs e)
        {
            pnlNav.Height = Btn_Analytics.Height;
            pnlNav.Top = Btn_Analytics.Top;
            pnlNav.Left = Btn_Analytics.Left;
            Btn_Analytics.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Calender";
            this.PnlFormLoader.Controls.Clear();
            FrmCalender frmDashboard_vrb = new FrmCalender() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();
        }

        private void Btn_DashBoard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = Btn_DashBoard.Height;
            pnlNav.Top = Btn_DashBoard.Top;
            pnlNav.Left = Btn_DashBoard.Left;
            Btn_DashBoard.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Dashbord";
            this.PnlFormLoader.Controls.Clear();

            FrmDashBord frmDashboard_vrb = new FrmDashBord() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();
        }

     

        private void Btn_Analytics_Click_2(object sender, EventArgs e)
        {
            pnlNav.Height = Btn_Analytics.Height;
            pnlNav.Top = Btn_Analytics.Top;
            pnlNav.Left = Btn_Analytics.Left;
            Btn_Analytics.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Analytics";
            this.PnlFormLoader.Controls.Clear();
            FrmAnalytics frmDashboard_vrb = new FrmAnalytics() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();

        }

        private void Btn_Exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Contact_Click_1(object sender, EventArgs e)
        {
            pnlNav.Height = Btn_Analytics.Height;
            pnlNav.Top = Btn_Analytics.Top;
            pnlNav.Left = Btn_Analytics.Left;
            Btn_Analytics.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Contact";
            this.PnlFormLoader.Controls.Clear();
            FrmContact frmDashboard_vrb = new FrmContact() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();
        }

        private void Btn_Settings_Click_1(object sender, EventArgs e)
        {
            pnlNav.Height = Btn_Analytics.Height;
            pnlNav.Top = Btn_Analytics.Top;
            pnlNav.Left = Btn_Analytics.Left;
            Btn_Analytics.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Settings";
            this.PnlFormLoader.Controls.Clear();
            FrmSettings frmDashboard_vrb = new FrmSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();
        }

     
    }
}
