using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Parcial_2_POO.Controlador;

namespace Parcial_2_POO
{
    public partial class frmUpdateAddress : Form
    {
        public APPUSER user = new APPUSER();
        public List<ADDRESS> list = new List<ADDRESS>();
        public List<string> list1 = new List<string>();
        
        public frmUpdateAddress()
        {
            InitializeComponent();
        }
        
        public void LoadCombo(int id)
        {
            list = new List<ADDRESS>();
            list1 = new List<string>();
            list = ConsultaADDRESS.getLista(id);
            foreach (var x in list)
            {
                list1.Add(x.address);
            }
                    
            cmbAddress.DataSource = list1;
        }

        private void btnUpdateAddress_Click(object sender, EventArgs e)
        {
            if(txtNewA.Text.Equals(""))
                MessageBox.Show("No puede dejar campos vacios", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
            {
                string dir = (string) cmbAddress.SelectedItem;
                ADDRESS ad = new ADDRESS();
                foreach (var d in list)
                {
                    if (d.address.Equals(dir))
                    {
                        ad.address = d.address;
                        ad.idAddress = d.idAddress;
                        ad.idUser = d.idUser;
                    }

                }

                try
                {
                    string sql = String.Format("UPDATE ADDRESS SET address = '{0}' WHERE idAddress = "
                                               + ad.idAddress, txtNewA.Text).ToString();
                    ConnectionDB.ExecuteNonQuery(sql);
                    this.Close();
                    MessageBox.Show("Direccion actualizada con exito", "Confirmacion", MessageBoxButtons.OK,
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