using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrearRegistroConDetalle.BLL;
using CrearRegistroConDetalle.DAL;
using CrearRegistroConDetalle.Entidades;

namespace CrearRegistroConDetalle.UI.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void EntrarButton_Click(object sender, EventArgs e)
        {
            if (!UsuariosBLL.ExisteCorreo(CorreoTextBox.Text, CLaveTextBox.Text))
            {
                var ventana = new MenuInicio();
                ventana.Show();
            }
            else
            {
                MessageBox.Show("Correo o clave incorrectas, vuelve a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CLaveTextBox.Clear();
            }
        }
    }
}
