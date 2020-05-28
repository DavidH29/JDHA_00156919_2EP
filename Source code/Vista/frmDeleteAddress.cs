using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Parcial_2_POO.Controlador;

namespace Parcial_2_POO
{
    public partial class frmDeleteAddress : Form
    {
        public APPUSER user = new APPUSER();
        public List<ADDRESS> list = new List<ADDRESS>();
        public List<string> list1 = new List<string>();
        public frmDeleteAddress()
        {
            InitializeComponent();
            //LoadCombo();
            /*int id = user.idUser;
            List<ADDRESS> combo = new List<ADDRESS>();
            combo = ConsultaADDRESS.getLista(id);
            List<string> adds = new List<string>();
            foreach (var a in combo)
            {
                adds.Add(a.address);
            }

            cmbAddress.DataSource = adds;*/
        }


        private void frmDeleteAddress_Load(object sender, EventArgs e)
        {
           
            /*List<ADDRESS> combo = new List<ADDRESS>();
            combo = ConsultaADDRESS.getLista(user.idUser);
            cmbAddress.DataSource = combo;                    //POR QUE NO SIRVE????
            cmbAddress.DisplayMember = "address";
            cmbAddress.ValueMember = "idAddress";
            cmbAddress.Text = cmbAddress.DisplayMember;*/

            /*List<ADDRESS> combo = new List<ADDRESS>();
            combo = ConsultaADDRESS.getLista(user.idUser);
            List<string> adds = new List<string>();
            foreach (var a in combo)
            {
                adds.Add(a.address);
            }

            cmbAddress.DataSource = adds;*/
            
            /*int id = user.idUser;
            List<ADDRESS> combo = new List<ADDRESS>();
            combo = ConsultaADDRESS.getLista(id);
            List<string> adds = new List<string>();
            foreach (var a in combo)
            {
                adds.Add(a.address);
            }

            cmbAddress.DataSource = adds;*/
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

        private void btnDeleteAddress_Click(object sender, EventArgs e)
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
                string sql = "DELETE FROM ADDRESS WHERE idAddress = " + ad.idAddress;
                ConnectionDB.ExecuteNonQuery(sql);
                this.Close();
                MessageBox.Show("Direccion eliminada con exito", "Confirmacion", MessageBoxButtons.OK,
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