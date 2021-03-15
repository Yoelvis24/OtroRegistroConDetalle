using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrearRegistroConDetalle.UI.Registros;
using CrearRegistroConDetalle.UI.Consultas;

namespace CrearRegistroConDetalle
{
    public partial class MenuInicio : Form
    {
        public MenuInicio()
        {
            InitializeComponent();

            //Registros
            this.UsuarioToolStripMenuItem.Click += new EventHandler(this.UsuarioToolStripMenuItemClicked);
            this.RolesToolStripMenuItem.Click += new EventHandler(this.RolesToolStripMenuItemClicked);

            //Consultas
            this.CRolesToolStripMenuItem.Click += new EventHandler(this.CRolesToolStripMenuItem_ItemClicked);
            this.CUsuariosToolStripMenuItem.Click += new EventHandler(this.CUsuariosToolStripMenuItem_ItemClicked);
        }

        private void CUsuariosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var  cUsuarios = new ConsultaUsuarios();
            cUsuarios.MdiParent = this;
            cUsuarios.Show();
        }

        private void CRolesToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var cRoles = new ConsultaRoles();
            cRoles.MdiParent = this;
            cRoles.Show();
        }

        private void RolesToolStripMenuItemClicked(object sender, EventArgs e)
        {
            var rRoles = new RegistroRoles();
            rRoles.MdiParent = this;
            rRoles.Show();
        }

        private void UsuarioToolStripMenuItemClicked(object sender, EventArgs e)
        {
            var rUsuarios = new RegistroUsuarios();
            rUsuarios.MdiParent = this;
            rUsuarios.Show();
        }
        private void RegistrarRolesButton_Click(object sender, EventArgs e)
        {
            
        }

        private void RegistrarUsuariosButton_Click(object sender, EventArgs e)
        {
            
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
