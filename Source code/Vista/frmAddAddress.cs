using System;
using System.Windows.Forms;
using Parcial_2_POO.Controlador;

namespace Parcial_2_POO
{
    public partial class frmAddAddress : Form
    {
        public APPUSER usuario = new APPUSER();
        public frmAddAddress()
        {
            InitializeComponent();
        }

        private void btnAddAddres_Click(object sender, EventArgs e)
        {
            if(txtAddAddress.Text.Equals(""))
                MessageBox.Show("Direccion agregada con exito", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
            {
                ADDRESS address = new ADDRESS();
                address.idUser = usuario.idUser;
                address.address = txtAddAddress.Text;
                try
                {
                    ConsultaADDRESS.Add(address);
                    this.Close();
                    MessageBox.Show("Acceso concedido, Binevenido", "Confirmacion", MessageBoxButtons.OK,
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
}