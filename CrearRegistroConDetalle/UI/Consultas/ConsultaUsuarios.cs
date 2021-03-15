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
    public partial class ConsultaUsuarios : Form
    {
        public List<Usuarios> lista = new List<Usuarios>();
        public ConsultaUsuarios()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            
            //Si se selecciona el usarFecha
            if (FiltroFechaCheckBox.Checked)
            {
                lista = UsuariosBLL.GetList(l => l.FechaIngreso >= DesdeDateTimePicker.Value && l.FechaIngreso <= HastaDateTimePicker.Value);
            }


            //Si algun radioButton se encuentra seleccionado
            if (FiltroActivoCheckBox.Checked)
            {
                if (TodosRadioButton.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0: //UsuarioId
                                lista = UsuariosBLL.GetList(r => r.UsuarioId == Utilitarios.ToInt(CriterioTextBox.Text));
                                break;
                            case 1: //Alias
                                lista = UsuariosBLL.GetList(r => r.Alias.Contains(CriterioTextBox.Text.ToUpper()) || r.Alias.Contains(CriterioTextBox.Text.ToLower()));
                                break;
                            case 2: //Nombres
                                lista = UsuariosBLL.GetList(r => r.Nombres.Contains(CriterioTextBox.Text.ToUpper()) || r.Nombres.Contains(CriterioTextBox.Text.ToLower()));
                                break;
                            case 3: //Email
                                lista = UsuariosBLL.GetList(r => r.Email.Contains(CriterioTextBox.Text.ToUpper()) || r.Email.Contains(CriterioTextBox.Text.ToLower()));
                                break;
                            case 4: //RolId
                                lista = UsuariosBLL.GetList(r => r.RolId == Utilitarios.ToInt(CriterioTextBox.Text));
                                break;
                            default:
                                break;
                        }
                    }
                }
                else if (ActivosRadioButton.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0: //UsuarioId
                                lista = UsuariosBLL.GetList(r => r.UsuarioId == Utilitarios.ToInt(CriterioTextBox.Text) && r.Activo);
                                break;
                            case 1: //Alias
                                lista = UsuariosBLL.GetList(r => (r.Alias.Contains(CriterioTextBox.Text.ToUpper()) && r.Activo) || (r.Alias.Contains(CriterioTextBox.Text.ToLower()) && r.Activo));
                                break;
                            case 2: //Nombres
                                lista = UsuariosBLL.GetList(r => (r.Nombres.Contains(CriterioTextBox.Text.ToUpper()) && r.Activo) || (r.Nombres.Contains(CriterioTextBox.Text.ToLower()) && r.Activo));
                                break;
                            case 3: //Email
                                lista = UsuariosBLL.GetList(r => (r.Email.Contains(CriterioTextBox.Text.ToUpper()) && r.Activo) || (r.Email.Contains(CriterioTextBox.Text.ToLower()) && r.Activo));
                                break;
                            case 4: //RolId
                                lista = UsuariosBLL.GetList(r => r.RolId == Utilitarios.ToInt(CriterioTextBox.Text) && r.Activo);
                                break;
                            default:
                                break;
                        }
                    }
                }
                else if (InactivosRadioButton.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0: //UsuarioId
                                lista = UsuariosBLL.GetList(r => r.UsuarioId == Utilitarios.ToInt(CriterioTextBox.Text) && !r.Activo);
                                break;
                            case 1: //Alias
                                lista = UsuariosBLL.GetList(r => (r.Alias.Contains(CriterioTextBox.Text.ToUpper()) && !r.Activo) || (r.Alias.Contains(CriterioTextBox.Text.ToLower()) && !r.Activo));
                                break;
                            case 2: //Nombres
                                lista = UsuariosBLL.GetList(r => (r.Nombres.Contains(CriterioTextBox.Text.ToUpper()) && !r.Activo) || (r.Nombres.Contains(CriterioTextBox.Text.ToLower()) && !r.Activo));
                                break;
                            case 3: //Email
                                lista = UsuariosBLL.GetList(r => (r.Email.Contains(CriterioTextBox.Text.ToUpper()) && !r.Activo) || (r.Email.Contains(CriterioTextBox.Text.ToLower()) && !r.Activo));
                                break;
                            case 4: //RolId
                                lista = UsuariosBLL.GetList(r => r.RolId == Utilitarios.ToInt(CriterioTextBox.Text) && !r.Activo);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            else
            {
                //si CriterioTextBox no esta vacio
                if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                {
                    switch (FiltroComboBox.SelectedIndex)
                    {
                        case 0: //UsuarioId
                            lista = UsuariosBLL.GetList(r => r.UsuarioId == Utilitarios.ToInt(CriterioTextBox.Text));
                            break;
                        case 1: //Alias
                            lista = UsuariosBLL.GetList(r => r.Alias.Contains(CriterioTextBox.Text.ToUpper()) || r.Alias.Contains(CriterioTextBox.Text.ToLower()));
                            break;
                        case 2: //Nombres
                            lista = UsuariosBLL.GetList(r => r.Nombres.Contains(CriterioTextBox.Text.ToUpper()) || r.Nombres.Contains(CriterioTextBox.Text.ToLower()));
                            break;
                        case 3: //Email
                            lista = UsuariosBLL.GetList(r => r.Email.Contains(CriterioTextBox.Text.ToUpper()) || r.Email.Contains(CriterioTextBox.Text.ToLower()));
                            break;
                        case 4: //RolId
                            lista = UsuariosBLL.GetList(r => r.RolId == Utilitarios.ToInt(CriterioTextBox.Text));
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    lista = UsuariosBLL.GetList(r => true);
                }
            }

            ConsultarUsuariosDataGridView.DataSource = null;
            ConsultarUsuariosDataGridView.DataSource = lista;
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            if(lista.Count == 0)
            {
                MessageBox.Show("No existen datos a imprimir");
            }
        }

        private void FiltroActivoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FiltroActivoCheckBox.Checked)
                esActivoGroupBox.Enabled = true;
            else
                esActivoGroupBox.Enabled = false;
        }
    }
}
