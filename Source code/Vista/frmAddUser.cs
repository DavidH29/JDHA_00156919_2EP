using System;
using System.Windows.Forms;

namespace Parcial_2_POO
{
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void btnAddAddres_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = String.Format("INSERT INTO APPUSER(fullname, username, password, userType) " +
                "VALUES('{0}', '{1}', '{1}', false);", txtName.Text, txtUsername.Text);
                ConnectionDB.ExecuteNonQuery(sql);
                this.Close();
                MessageBox.Show("Usuario agregado exitosamente", "Confirmacion", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);

            }
            catch (Exception exception)
            {
                MessageBox.Show("Ha ocurrido un error", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
        }
    }
}