using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrearRegistroConDetalle.BLL;
using CrearRegistroConDetalle.Entidades;

namespace CrearRegistroConDetalle.UI.Consultas
{
    public partial class ConsultaRoles : Form
    {
        List<Roles> lista = new List<Roles>();
        public ConsultaRoles()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            
            //En caso de que TodosRadioButton se encuentre seleccionado
            if (TodosRadioButton.Checked)
            {
                //Si el filtro de la fecha se encuentra marcado, va a tomar en cuenta le rango de fecha
                if (FiltroFechaCheckBox.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0: //RolId
                                lista = RolesBLL.GetList(r => r.RolId == Utilitarios.ToInt(CriterioTextBox.Text) && (r.FechaCreacion >= DesdeDateTimePicker.Value && r.FechaCreacion <= HastaDateTimePicker.Value));
                                break;
                            case 1: //Descripcion
                                lista = RolesBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text) && (r.FechaCreacion >= DesdeDateTimePicker.Value && r.FechaCreacion <= HastaDateTimePicker.Value));
                                break;
                            default:
                                break;
                        }
                    }
                    //En caso de que no haya nada en el textBox, se imprimirán todos los Roles
                    else
                        lista = RolesBLL.GetList(r => (r.FechaCreacion >= DesdeDateTimePicker.Value && r.FechaCreacion <= HastaDateTimePicker.Value));
                }
                else
                {
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0: //UsuarioId
                                lista = RolesBLL.GetList(r => r.RolId == Utilitarios.ToInt(CriterioTextBox.Text));
                                break;
                            case 1: //Descripcion
                                lista = RolesBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text));
                                break;
                            default:
                                break;
                        }
                    }
                    //En caso de que no haya nada en el textBox, se imprimirán todos los Roles
                    else
                        lista = RolesBLL.GetList(r => true);
                }

            }
            //En caso de que ActivosRadioButton se encuentre seleccionado
            else if (ActivosRadioButton.Checked)
            {
                //Si el filtro de la fecha se encuentra marcado, va a tomar en cuenta le rango de fecha
                if (FiltroFechaCheckBox.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0: //RolId
                                lista = RolesBLL.GetList(r => r.RolId == Utilitarios.ToInt(CriterioTextBox.Text) && (r.FechaCreacion >= DesdeDateTimePicker.Value && r.FechaCreacion <= HastaDateTimePicker.Value) && r.EsActivo);
                                break;
                            case 1: //Descripcion
                                lista = RolesBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text) && (r.FechaCreacion >= DesdeDateTimePicker.Value && r.FechaCreacion <= HastaDateTimePicker.Value) && r.EsActivo);
                                break;
                            default:
                                break;
                        }
                    }
                    //En caso de que no haya nada en el textBox, se imprimirán todos los Roles
                    else
                        lista = RolesBLL.GetList(r => (r.FechaCreacion >= DesdeDateTimePicker.Value && r.FechaCreacion <= HastaDateTimePicker.Value) && r.EsActivo);
                }
                else
                {
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0: //RolId
                                lista = RolesBLL.GetList(r => r.RolId == Utilitarios.ToInt(CriterioTextBox.Text) && r.EsActivo);
                                break;
                            case 1: //Descripcion
                                lista = RolesBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text) && r.EsActivo);
                                break;
                            default:
                                break;
                        }
                    }
                    //En caso de que no haya nada en el textBox, se imprimirán todos los Roles
                    else
                        lista = RolesBLL.GetList(r => true && r.EsActivo);
                }

            }
            //En caso de que InactivosRadioButton se encuentre seleccionado
            else if (InactivosRadioButton.Checked)
            {
                //Si el filtro de la fecha se encuentra marcado, va a tomar en cuenta le rango de fecha
                if (FiltroFechaCheckBox.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0: //UsuarioId
                                lista = RolesBLL.GetList(r => r.RolId == Utilitarios.ToInt(CriterioTextBox.Text) && (r.FechaCreacion >= DesdeDateTimePicker.Value && r.FechaCreacion <= HastaDateTimePicker.Value) && !r.EsActivo);
                                break;
                            case 1: //Alias
                                lista = RolesBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text) && (r.FechaCreacion >= DesdeDateTimePicker.Value && r.FechaCreacion <= HastaDateTimePicker.Value) && !r.EsActivo);
                                break;
                            default:
                                break;
                        }
                    }
                    //En caso de que no haya nada en el textBox, se imprimirán todos los Roles
                    else
                        lista = RolesBLL.GetList(r => (r.FechaCreacion >= DesdeDateTimePicker.Value && r.FechaCreacion <= HastaDateTimePicker.Value) && !r.EsActivo);
                }
                else
                {
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0: //RolId
                                lista = RolesBLL.GetList(r => r.RolId == Utilitarios.ToInt(CriterioTextBox.Text) && !r.EsActivo);
                                break;
                            case 1: //Descripcion
                                lista = RolesBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text) && !r.EsActivo);
                                break;
                            default:
                                break;
                        }
                    }
                    //En caso de que no haya nada en el textBox, se imprimirán todos los Roles
                    else
                        lista = RolesBLL.GetList(r => true && !r.EsActivo);
                }

            }

            ConsultarRolesDataGridView.DataSource = null;
            ConsultarRolesDataGridView.DataSource = lista;
        }

        private void FiltroActivoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FiltroActivoCheckBox.Checked)
            {
                esActivoGroupBox.Enabled = true;
            }
            else
            {
                esActivoGroupBox.Enabled = false;
            }
        }
    }
}
