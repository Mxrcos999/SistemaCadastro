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
using System.ComponentModel.DataAnnotations;
using dashboard.data;

namespace dashboard
{
    public partial class Frm_UserRegistration : Form
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

        public Frm_UserRegistration()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }
     
        private void Frm_UserRegistration_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Btn_Register_Click(object sender, EventArgs e)
        {
            try
            {
                
                var _user = new UserRegistration();
                _user.TrataDados(Txt_UserName.Text, Txt_Passworld.Text);

                if ((Lbl_ResultPassword.Text == "Inaceitavel" | Lbl_ResultPassword.Text == "Fraca"))
                {
                    MessageBox.Show("ERR: Enter a valid password", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (_user._status == true)
                {
                    MessageBox.Show("Registration successfully Complete! Login to continue", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Pnl_Register.Controls.Clear();
                    Frm_Login frmDashboard_vrb = new Frm_Login(Txt_UserName.Text, Txt_Passworld.Text) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
                    this.Pnl_Register.Controls.Add(frmDashboard_vrb);
                    frmDashboard_vrb.Show();
                }
                else
                {
                    MessageBox.Show("ERR: Inclusion not allowed because the username is already used", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                //  _user.usuario();
                /*
                        string clienteJson = UserRegistration.SerializedClassUnit(_user);
                        var f = new Fichario(@"C:\Users\marco\source\repos\dashboard\dashboard\bin\Debug\net5.0-windows\Fichario");


                
                     */
            }
            catch (ValidationException Ex)
            {
                MessageBox.Show(Ex.Message);
               
            }
  
           
       
        }

        private void Txt_Passworld_KeyDown(object sender, KeyEventArgs e)
        {
            ChecaForcaSenha verifica = new ChecaForcaSenha();
            ChecaForcaSenha.ForcaDaSenha forca;
            forca = verifica.GetForcaDaSenha(Txt_Passworld.Text);
            Lbl_ResultPassword.Text = forca.ToString();

            if (Lbl_ResultPassword.Text == "Inaceitavel" | Lbl_ResultPassword.Text == "Fraca")
            {
                Lbl_ResultPassword.ForeColor = Color.Red;
            }
            if (Lbl_ResultPassword.Text == "Aceitavel")
            {
                Lbl_ResultPassword.ForeColor = Color.Blue;
            }
            if (Lbl_ResultPassword.Text == "Forte" | Lbl_ResultPassword.Text == "Segura")
            {
                Lbl_ResultPassword.ForeColor = Color.Green;
            }
        }

        private void Btn_ChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog Db = new OpenFileDialog();
            Db.InitialDirectory = "C:\\WindowsForms\\Curso\\CursoWindowsForms\\CursoWindowsForms\\Imagens";
            Db.Filter = "PNG|*.PNG";
            Db.Title = "Escolha a Imagem";
            Db.ShowDialog();
            var userimage = Db.FileName; 
            Pct_Profile.Image = Image.FromFile(userimage);


         

        }


        private void Chk_Pass_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Pass.Checked)
            {
                Txt_Passworld.PasswordChar = '\0';
                Chk_Pass.Text = "hide password";

               

            }
            else
            {
                Txt_Passworld.PasswordChar = '*';
                Chk_Pass.Text = "show password";
            }
        }

   
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Pnl_Register.Controls.Clear();
            Frm_Login frmDashboard_vrb = new Frm_Login(Txt_UserName.Text, Txt_Passworld.Text) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.Pnl_Register.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();
        }

        private void Pnl_Register_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
