using System;
using System.Windows.Forms;
using Parcial_2_POO.Controlador;

namespace Parcial_2_POO
{
    public partial class frmDeleteOrder : Form
    {
        
        public frmDeleteOrder()
        {
            InitializeComponent();
        }

        private void btnAddAddres_Click(object sender, EventArgs e)
        {
            if(txtAddAddress.Equals(""))
                MessageBox.Show("No puede dejar campos vacios", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
            {
                try
                {
                    int i = Convert.ToInt32(txtAddAddress.Text.ToString());
                    ConsultasORDER.Delete(i);
                    this.Close();
                    MessageBox.Show("Orden eliminada exitosamente", "Confirmacion", MessageBoxButtons.OK,
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