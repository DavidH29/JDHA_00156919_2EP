using System;
using System.Windows.Forms;

namespace Parcial_2_POO
{
    public partial class frmAdmin : Form
    {
        public APPUSER Appuser = new APPUSER(); 
        
        public frmAdmin()
        {
            InitializeComponent();
        }


        private void frmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            frmChangePassword window = new frmChangePassword();
            window.user.fullname = Appuser.fullname;
            window.user.password = Appuser.password;
            window.user.username = Appuser.username;
            window.user.idUser = Appuser.idUser;
            window.user.userType = Appuser.userType;
            window.Show();
        }

        private void btnSingout_Click(object sender, EventArgs e)
        {
            Form1 window = new Form1();
            window.Show();
            this.Hide();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUser window = new frmAddUser();
            window.Show();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            
        }
    }
}