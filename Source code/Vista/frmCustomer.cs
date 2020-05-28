using System;
using System.Windows.Forms;

namespace Parcial_2_POO
{
    public partial class frmCustomer : Form
    {
        public APPUSER Appuser = new APPUSER(); 
            
        public frmCustomer()
        {
            InitializeComponent();
        }
        
        private void frmCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            this.Text = "Usuario: " + Appuser.username + Appuser.idUser.ToString();
        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            frmAddAddress window = new frmAddAddress();
            window.usuario = Appuser;
            window.ShowDialog();
        }

        private void btnDeleteAddress_Click(object sender, EventArgs e)
        {
            int jk = Appuser.idUser;
            frmDeleteAddress window = new frmDeleteAddress();
            window.user.fullname = Appuser.fullname;
            window.user.password = Appuser.password;
            window.user.username = Appuser.username;
            window.user.idUser = Appuser.idUser;
            window.user.userType = Appuser.userType;
            window.LoadCombo(jk);
            window.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
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

        private void btnUpdateAddres_Click(object sender, EventArgs e)
        {
            int jk = Appuser.idUser;
            frmUpdateAddress window = new frmUpdateAddress();
            window.user.fullname = Appuser.fullname;
            window.user.password = Appuser.password;
            window.user.username = Appuser.username;
            window.user.idUser = Appuser.idUser;
            window.user.userType = Appuser.userType;
            window.LoadCombo(jk);
            window.ShowDialog();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            int jk = Appuser.idUser;
            frmAddOrder window = new frmAddOrder();
            window.user.fullname = Appuser.fullname;
            window.user.password = Appuser.password;
            window.user.username = Appuser.username;
            window.user.idUser = Appuser.idUser;
            window.user.userType = Appuser.userType;
            window.LoadCombo(jk);
            window.ShowDialog();
        }

        private void btnShowOrders_Click(object sender, EventArgs e)
        {
            int jk = Appuser.idUser;
            frmShowOrdersUser window = new frmShowOrdersUser();
            window.user.fullname = Appuser.fullname;
            window.user.password = Appuser.password;
            window.user.username = Appuser.username;
            window.user.idUser = Appuser.idUser;
            window.user.userType = Appuser.userType;
            window.Tabla();
            window.Show();
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            frmDeleteOrder window = new frmDeleteOrder();
            window.Show();
        }
    }
}