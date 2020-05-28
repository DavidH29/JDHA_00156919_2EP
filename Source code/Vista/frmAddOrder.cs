using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Parcial_2_POO.Controlador;

namespace Parcial_2_POO
{
    public partial class frmAddOrder : Form
    {
        public APPUSER user = new APPUSER();
        public List<ADDRESS> list = new List<ADDRESS>();
        public List<string> list1 = new List<string>();
        
        public List<PRODUCT> lista = new List<PRODUCT>();
        public List<string> list1a = new List<string>();
        
        public frmAddOrder()
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
                    
            cmbSAddress.DataSource = list1;
            
            lista = new List<PRODUCT>();
            list1a = new List<string>();
            lista = ConsultaPRODUCT.getLista();
            foreach (var x in lista)
            {
                list1a.Add(x.name);
            }
                    
            cmbProducts.DataSource = list1a;
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            string dir = (string) cmbSAddress.SelectedItem;
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
            
            string dira = (string) cmbProducts.SelectedItem;
            PRODUCT ada = new PRODUCT();
            foreach (var d in lista)
            {
                if (d.name.Equals(dira))
                {
                    ada.idProduct = d.idProduct;
                    ada.idBusiness = d.idBusiness;
                    ada.name = d.name;
                }
            }
            
            APPORDER NOrder = new APPORDER();
            DateTime today = DateTime.Today;
            string fecha = today.ToString("yyyy/MM/dd");
            NOrder.createDate = DateTime.Today;
            NOrder.idProduct = ada.idProduct;
            NOrder.idAddress = ad.idAddress;

            try
            {

                string sql = String.Format("INSERT INTO APPORDER(createDate, idProduct, idAddress) " +
                                           "VALUES('{0}', {1}, {2});", fecha, NOrder.idProduct, NOrder.idAddress);
                ConnectionDB.ExecuteNonQuery(sql);
                this.Close();
                MessageBox.Show("Orden agregada exitosamente", "Confirmacion", MessageBoxButtons.OK,
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