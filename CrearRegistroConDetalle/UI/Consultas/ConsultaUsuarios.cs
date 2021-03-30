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
                            case 0: //UsuarioId
                                lista = UsuariosBLL.GetList(r => r.UsuarioId == Utilitarios.ToInt(CriterioTextBox.Text) && (r.FechaIngreso >= DesdeDateTimePicker.Value && r.FechaIngreso <= HastaDateTimePicker.Value));
                                break;
                            case 1: //Alias
                                lista = UsuariosBLL.GetList(r => r.Alias.Contains(CriterioTextBox.Text) && (r.FechaIngreso >= DesdeDateTimePicker.Value && r.FechaIngreso <= HastaDateTimePicker.Value));
                                break;
                            case 2: //Nombres
                                lista = UsuariosBLL.GetList(r => r.Nombres.Contains(CriterioTextBox.Text) && (r.FechaIngreso >= DesdeDateTimePicker.Value && r.FechaIngreso <= HastaDateTimePicker.Value));
                                break;
                            case 3: //Email
                                lista = UsuariosBLL.GetList(r => r.Email.Contains(CriterioTextBox.Text) && (r.FechaIngreso >= DesdeDateTimePicker.Value && r.FechaIngreso <= HastaDateTimePicker.Value));
                                break;
                            case 4: //RolId
                                lista = UsuariosBLL.GetList(r => r.RolId == Utilitarios.ToInt(CriterioTextBox.Text) && (r.FechaIngreso >= DesdeDateTimePicker.Value && r.FechaIngreso <= HastaDateTimePicker.Value));
                                break;
                            default:
                                break;
                        }
                    }
                    //En caso de que no haya nada en el textBox, se imprimirán todos los usuarios
                    else
                        lista = UsuariosBLL.GetList(r => (r.FechaIngreso >= DesdeDateTimePicker.Value && r.FechaIngreso <= HastaDateTimePicker.Value));
                }
                else
                {
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0: //UsuarioId
                                lista = UsuariosBLL.GetList(r => r.UsuarioId == Utilitarios.ToInt(CriterioTextBox.Text));
                                break;
                            case 1: //Alias
                                lista = UsuariosBLL.GetList(r => r.Alias.Contains(CriterioTextBox.Text));
                                break;
                            case 2: //Nombres
                                lista = UsuariosBLL.GetList(r => r.Nombres.Contains(CriterioTextBox.Text));
                                break;
                            case 3: //Email
                                lista = UsuariosBLL.GetList(r => r.Email.Contains(CriterioTextBox.Text));
                                break;
                            case 4: //RolId
                                lista = UsuariosBLL.GetList(r => r.RolId == Utilitarios.ToInt(CriterioTextBox.Text));
                                break;
                            default:
                                break;
                        }
                    }
                    //En caso de que no haya nada en el textBox, se imprimirán todos los usuarios
                    else
                        lista = UsuariosBLL.GetList(r => true);
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
                            case 0: //UsuarioId
                                lista = UsuariosBLL.GetList(r => r.UsuarioId == Utilitarios.ToInt(CriterioTextBox.Text) && (r.FechaIngreso >= DesdeDateTimePicker.Value && r.FechaIngreso <= HastaDateTimePicker.Value) && r.Activo);
                                break;
                            case 1: //Alias
                                lista = UsuariosBLL.GetList(r => r.Alias.Contains(CriterioTextBox.Text) && (r.FechaIngreso >= DesdeDateTimePicker.Value && r.FechaIngreso <= HastaDateTimePicker.Value) && r.Activo);
                                break;
                            case 2: //Nombres
                                lista = UsuariosBLL.GetList(r => r.Nombres.Contains(CriterioTextBox.Text) && (r.FechaIngreso >= DesdeDateTimePicker.Value && r.FechaIngreso <= HastaDateTimePicker.Value) && r.Activo);
                                break;
                            case 3: //Email
                                lista = UsuariosBLL.GetList(r => r.Email.Contains(CriterioTextBox.Text) && (r.FechaIngreso >= DesdeDateTimePicker.Value && r.FechaIngreso <= HastaDateTimePicker.Value) && r.Activo);
                                break;
                            case 4: //RolId
                                lista = UsuariosBLL.GetList(r => r.RolId == Utilitarios.ToInt(CriterioTextBox.Text) && (r.FechaIngreso >= DesdeDateTimePicker.Value && r.FechaIngreso <= HastaDateTimePicker.Value) && r.Activo);
                                break;
                            default:
                                break;
                        }
                    }
                    //En caso de que no haya nada en el textBox, se imprimirán todos los usuarios
                    else
                        lista = UsuariosBLL.GetList(r => (r.FechaIngreso >= DesdeDateTimePicker.Value && r.FechaIngreso <= HastaDateTimePicker.Value) && r.Activo);
                }
                else
                {
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0: //UsuarioId
                                lista = UsuariosBLL.GetList(r => r.UsuarioId == Utilitarios.ToInt(CriterioTextBox.Text) && r.Activo);
                                break;
                            case 1: //Alias
                                lista = UsuariosBLL.GetList(r => r.Alias.Contains(CriterioTextBox.Text) && r.Activo);
                                break;
                            case 2: //Nombres
                                lista = UsuariosBLL.GetList(r => r.Nombres.Contains(CriterioTextBox.Text) && r.Activo);
                                break;
                            case 3: //Email
                                lista = UsuariosBLL.GetList(r => r.Email.Contains(CriterioTextBox.Text) && r.Activo);
                                break;
                            case 4: //RolId
                                lista = UsuariosBLL.GetList(r => r.RolId == Utilitarios.ToInt(CriterioTextBox.Text) && r.Activo);
                                break;
                            default:
                                break;
                        }
                    }
                    //En caso de que no haya nada en el textBox, se imprimirán todos los usuarios
                    else
                        lista = UsuariosBLL.GetList(r => true && r.Activo);
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
                                lista = UsuariosBLL.GetList(r => r.UsuarioId == Utilitarios.ToInt(CriterioTextBox.Text) && (r.FechaIngreso >= DesdeDateTimePicker.Value && r.FechaIngreso <= HastaDateTimePicker.Value) && !r.Activo);
                                break;
                            case 1: //Alias
                                lista = UsuariosBLL.GetList(r => r.Alias.Contains(CriterioTextBox.Text) && (r.FechaIngreso >= DesdeDateTimePicker.Value && r.FechaIngreso <= HastaDateTimePicker.Value) && !r.Activo);
                                break;
                            case 2: //Nombres
                                lista = UsuariosBLL.GetList(r => r.Nombres.Contains(CriterioTextBox.Text) && (r.FechaIngreso >= DesdeDateTimePicker.Value && r.FechaIngreso <= HastaDateTimePicker.Value) && !r.Activo);
                                break;
                            case 3: //Email
                                lista = UsuariosBLL.GetList(r => r.Email.Contains(CriterioTextBox.Text) && (r.FechaIngreso >= DesdeDateTimePicker.Value && r.FechaIngreso <= HastaDateTimePicker.Value) && !r.Activo);
                                break;
                            case 4: //RolId
                                lista = UsuariosBLL.GetList(r => r.RolId == Utilitarios.ToInt(CriterioTextBox.Text) && (r.FechaIngreso >= DesdeDateTimePicker.Value && r.FechaIngreso <= HastaDateTimePicker.Value) && !r.Activo);
                                break;
                            default:
                                break;
                        }
                    }
                    //En caso de que no haya nada en el textBox, se imprimirán todos los usuarios
                    else
                        lista = UsuariosBLL.GetList(r => (r.FechaIngreso >= DesdeDateTimePicker.Value && r.FechaIngreso <= HastaDateTimePicker.Value) && !r.Activo);
                }
                else
                {
                    if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
                    {
                        switch (FiltroComboBox.SelectedIndex)
                        {
                            case 0: //UsuarioId
                                lista = UsuariosBLL.GetList(r => r.UsuarioId == Utilitarios.ToInt(CriterioTextBox.Text) && !r.Activo);
                                break;
                            case 1: //Alias
                                lista = UsuariosBLL.GetList(r => r.Alias.Contains(CriterioTextBox.Text) && !r.Activo);
                                break;
                            case 2: //Nombres
                                lista = UsuariosBLL.GetList(r => r.Nombres.Contains(CriterioTextBox.Text) && !r.Activo);
                                break;
                            case 3: //Email
                                lista = UsuariosBLL.GetList(r => r.Email.Contains(CriterioTextBox.Text) && !r.Activo);
                                break;
                            case 4: //RolId
                                lista = UsuariosBLL.GetList(r => r.RolId == Utilitarios.ToInt(CriterioTextBox.Text) && !r.Activo);
                                break;
                            default:
                                break;
                        }
                    }
                    //En caso de que no haya nada en el textBox, se imprimirán todos los usuarios
                    else
                        lista = UsuariosBLL.GetList(r => true && !r.Activo);
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
