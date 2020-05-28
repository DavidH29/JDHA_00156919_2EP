using System;
using System.Windows.Forms;

namespace Parcial_2_POO
{
   
    public partial class frmChangePassword : Form
    {
        public APPUSER user = new APPUSER();
        
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtCurrentPass.Text.Equals("") || txtNewPassword.Text.Equals("") || txtConfirm.Text.Equals(""))
            {
                MessageBox.Show("No puede dejar campos vacios", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                if (txtCurrentPass.Text.Equals(user.password))
                {
                    if (txtConfirm.Text.Equals(txtNewPassword.Text))
                    {
                        try
                        {
                            string sql = String.Format("UPDATE APPUSER SET password = '{0}' WHERE idUser = "
                                                        + user.idUser, txtConfirm.Text);
                            ConnectionDB.ExecuteNonQuery(sql);
                            this.Close();
                            MessageBox.Show("Password cambiado exitosamente", "Confirmacion",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show("Ha ocurrido un error", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    
                    }
                    
                }
                else{
                    MessageBox.Show("Password incorrecto, no espiar primer aviso", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}