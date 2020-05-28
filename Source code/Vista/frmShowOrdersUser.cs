using System;
using System.Windows.Forms;
using Parcial_2_POO.Controlador;

namespace Parcial_2_POO
{
    public partial class frmShowOrdersUser : Form
    {
        public APPUSER user = new APPUSER();
        public frmShowOrdersUser()
        {
            InitializeComponent();
            //Tabla();
        }

        public void Tabla()
        {
            int f = user.idUser;
            //dgvOrders.DataSource = null;
            dgvOrders.DataSource = ConsultaAPPUSER.getLista();
        }
    }
}