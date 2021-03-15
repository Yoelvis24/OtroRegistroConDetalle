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
        public ConsultaRoles()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var lista = new List<Roles>();


            //Si usarFecha se encuentra cortejado
            if (FiltroFechaCheckBox.Checked)
            {
                lista = RolesBLL.GetList(l => l.FechaCreacion >= DesdeDateTimePicker.Value && l.FechaCreacion <= HastaDateTimePicker.Value);
            }

            //Si se selecciona Filtro Activo
            if (FiltroActivoCheckBox.Checked)
            {
                //Si TodosRadioButton se encuentra seleccionado
                if (TodosRadioButton.Checked)
                {
                    //si CriterioTextBox no se encuentra vacio
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0: //RolId
                                lista = RolesBLL.GetList(r => r.RolId == Utilitarios.ToInt(CriterioTextBox.Text));
                                break;
                            case 1: //Descripcion
                                lista = RolesBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text));
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        lista = RolesBLL.GetList(r => true);
                }
                //Si ActivosRadioButton se encuentra seleccionado
                else if (ActivosRadioButton.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0: //RolId
                                lista = RolesBLL.GetList(r => r.RolId == Utilitarios.ToInt(CriterioTextBox.Text) && r.EsActivo);
                                break;
                            case 1: //Descripcion
                                lista = RolesBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text.ToUpper()) && r.EsActivo || r.Descripcion.Contains(CriterioTextBox.Text.ToLower()) && r.EsActivo);
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        lista = RolesBLL.GetList(r => r.EsActivo);
                }
                //Si InactivosRadioButton se encuentra seleccionado
                else if (InactivosRadioButton.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0: //RolId
                                lista = RolesBLL.GetList(r => r.RolId == Utilitarios.ToInt(CriterioTextBox.Text) && !r.EsActivo);
                                break;
                            case 1: //Descripcion
                                lista = RolesBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text.ToUpper()) && !r.EsActivo || r.Descripcion.Contains(CriterioTextBox.Text.ToLower()) && !r.EsActivo);
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        lista = RolesBLL.GetList(r => !r.EsActivo);
                }
            }
            else
            {
                //si CriterioTextBox no se encuentra vacio y FiltroActivo no se encuentra cortejado
                if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                {
                    switch (FiltroComboBox.SelectedIndex)
                    {
                        case 0: //RolId
                            lista = RolesBLL.GetList(r => r.RolId == Utilitarios.ToInt(CriterioTextBox.Text));
                            break;
                        case 1: //Descripcion
                            lista = RolesBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text));
                            break;
                        default:
                            break;
                    }
                }
                else
                    lista = RolesBLL.GetList(r => true);
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
