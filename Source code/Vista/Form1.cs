using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Parcial_2_POO.Controlador;

namespace Parcial_2_POO
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
      if (txtPassword.Text.Equals("") || txtUsername.Text.Equals(""))
      {
        MessageBox.Show("No puede dejar campos vacios", "Error", MessageBoxButtons.OK,
          MessageBoxIcon.Error);
      }
      else
      {
        APPUSER customer = new APPUSER();
        var users = ConsultaAPPUSER.getLista();
        foreach (var u in users)
        {
          if (txtUsername.Text.Equals(u.username))
          {
            customer = u;
            break;
          }
        }

        if (txtPassword.Text.Equals(customer.password))
        {
          MessageBox.Show("Acceso concedido, Binevenido", "Confirmacion", MessageBoxButtons.OK,
            MessageBoxIcon.Asterisk);
          if (customer.userType)
          {
            frmAdmin window = new frmAdmin();
            window.Appuser.fullname = customer.fullname;
            window.Appuser.password = customer.password;
            window.Appuser.username = customer.username;
            window.Appuser.idUser = customer.idUser;
            window.Appuser.userType = customer.userType;
            window.Show();
            this.Hide();
          }
          else
          {
            frmCustomer window = new frmCustomer();
            window.Appuser.fullname = customer.fullname;
            window.Appuser.password = customer.password;
            window.Appuser.username = customer.username;
            window.Appuser.idUser = customer.idUser;
            window.Appuser.userType = customer.userType;
            window.Show();
            this.Hide();
          }
        }
        else
        {
          MessageBox.Show("Acceso denegado, password y username incorrectos", "ERROR",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }
  }
}
