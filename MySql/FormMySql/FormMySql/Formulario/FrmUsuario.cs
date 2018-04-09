using FormMySql.Connection;
using FormMySql.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMySql.Formulario
{
    public partial class FrmUsuario : Form
    {
        private Usuario_controller controlador;

        public FrmUsuario()
        {
            InitializeComponent();
            controlador = new Usuario_controller();
            txtid.Text = "0";
            txtid.ReadOnly = true;
            dgvConsulta.ReadOnly = true;
            cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CenterToScreen();
        }

        private bool comprobar(bool id)
        {
            bool result = false;
            if (txtid.Text.Trim() !="")
            {
                controlador.Modelo.IdUsuario = int.Parse(txtid.Text.Trim());
                if (txtNombre.Text.Trim() != "")
                {
                    controlador.Modelo.Nombre = txtNombre.Text.Trim();
                    if (txtApellido.Text.Trim() != "")
                    {
                        controlador.Modelo.Apellido = txtApellido.Text.Trim();
                        if (txtCorreo.Text.Trim() != "")
                        {
                            controlador.Modelo.Correo = txtCorreo.Text.Trim();
                            if (txtTelefono.Text.Trim() != "")
                            {
                                controlador.Modelo.Telefono = txtTelefono.Text.Trim();
                                controlador.Modelo.IdTipo = int.Parse(cmbTipo.SelectedValue.ToString());
                                return true;
                            }
                        }
                    }
                }
            }
            if (!MetodoValidar.ValidarCorreo(txtCorreo.Text.Trim()))
            {
                MessageBox.Show("Correo incorrecto \n Escriba un correo valido ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                result = false;
            }
            if (id)
            {
                if (int.Parse(txtid.Text.Trim())<=0)
                {
                    result = false;
                }
            }
            else
            {
                if (int.Parse(txtid.Text.Trim()) > 0)
                {
                    result = false;
                }
            }
            if (!result)
            {
                MessageBox.Show("Datos incompletos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                
            }
            return result;
        }

        private void consultar()
        {
            controlador.Sql = "select * from usuario";
            dgvConsulta.DataSource = controlador.ConsultarTabla();
            dgvConsulta.Refresh();
        }

        private void seleccionar()
        {
            int fila = int.Parse(dgvConsulta.CurrentCell.RowIndex.ToString().Trim());
            if (dgvConsulta.Rows[fila].Cells[0].Value.ToString().Trim() != "")
            {
                txtid.Text = dgvConsulta.Rows[fila].Cells[0].Value.ToString().Trim();
                cmbTipo.SelectedIndex = int.Parse(dgvConsulta.Rows[fila].Cells[1].Value.ToString().Trim()) - 1;
                txtNombre.Text = dgvConsulta.Rows[fila].Cells[2].Value.ToString().Trim();
                txtApellido.Text = dgvConsulta.Rows[fila].Cells[3].Value.ToString().Trim();
                txtTelefono.Text = dgvConsulta.Rows[fila].Cells[4].Value.ToString().Trim();
                txtCorreo.Text = dgvConsulta.Rows[fila].Cells[5].Value.ToString().Trim();
            }
        }

        private void llenarCombo()
        {
            controlador.Sql = "select * from tipoUsuario";
            cmbTipo.DataSource = controlador.ConsultarTabla();
            cmbTipo.DisplayMember = "nombre".Trim();
            cmbTipo.ValueMember = "idTipoUsuario".Trim();
            cmbTipo.Refresh();

        }

        private void limpiar()
        {
            txtid.Text = "0";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";

        }

        private void guardar()
        {
            if (comprobar(false))
            {
                if (controlador.Guardar())
                {
                    limpiar();
                    consultar();
                }
                
            }
        }

        private void modificar()
        {
            if (comprobar(true))
            {
                if (controlador.Modificar())
                {
                    limpiar();
                    consultar();
                }
            }
        }

        private void eliminar()
        {
            if (comprobar(true))
            {
                if (controlador.Eliminar())
                {
                    limpiar();
                    consultar();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            consultar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dgvConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionar();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodoValidar.ValidarTexto(txtNombre, e, 25);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodoValidar.ValidarTexto(txtApellido, e, 25);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetodoValidar.ValidarNumero(txtTelefono, e, 8);
        }
    }
}
