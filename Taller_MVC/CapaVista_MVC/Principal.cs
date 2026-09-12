using CapaControlador_MVC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_MVC
{
    public partial class Principal : Form
    {
        private ModeloProveedor modeloProveedor = new ModeloProveedor();

        public Principal()
        {
            InitializeComponent();
            panIngresoDatos.Enabled = false;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            CargarComboInteligente();
            ListarProveedores();
        }

        private void CargarComboInteligente()
        {
            try
            {
                comboI1.llenarCombo("proveedor", "id_proveedor", "nombre");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Combo Inteligente: " + ex.Message, "Error DLL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ListarProveedores()
        {
            try
            {
                dgbConsultaTabla.DataSource = null;
                dgbConsultaTabla.DataSource = modeloProveedor.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgbConsultaTabla.DataSource = modeloProveedor.FindbyId(txtSearch.Text);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgbConsultaTabla.DataSource = modeloProveedor.FindbyId(txtSearch.Text);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            panIngresoDatos.Enabled = true;
            modeloProveedor.Estado = EstadoEntidad.Added;
            LimpiarCampos();
            txtNombre.Focus();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                modeloProveedor.Nombre = txtNombre.Text.Trim();
                modeloProveedor.Telefono = txtTelefono.Text.Trim();

                int idDir = 1;
                if (!string.IsNullOrWhiteSpace(txtIdDireccion.Text))
                {
                    int.TryParse(txtIdDireccion.Text.Trim(), out idDir);
                }
                modeloProveedor.IdDireccion = idDir > 0 ? idDir : 1;

                bool valido = new Ayudas.ValidacionDatos(modeloProveedor).Validar();
                if (valido)
                {
                    string resultado = modeloProveedor.GrabarCambios();
                    MessageBox.Show(resultado, "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarProveedores();
                    CargarComboInteligente();
                    Reinicio();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgbConsultaTabla.SelectedRows.Count > 0)
            {
                panIngresoDatos.Enabled = true;
                modeloProveedor.Estado = EstadoEntidad.Modified;

                var fila = dgbConsultaTabla.CurrentRow;
                modeloProveedor.IdProveedor = Convert.ToInt32(fila.Cells["IdProveedor"].Value);
                txtIdProveedor.Text = fila.Cells["IdProveedor"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value != null ? fila.Cells["Nombre"].Value.ToString() : "";
                txtTelefono.Text = fila.Cells["Telefono"].Value != null ? fila.Cells["Telefono"].Value.ToString() : "";
                txtIdDireccion.Text = fila.Cells["IdDireccion"].Value != null ? fila.Cells["IdDireccion"].Value.ToString() : "1";
                txtNombre.Focus();
            }
            else
            {
                MessageBox.Show("Por favor seleccione un proveedor de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgbConsultaTabla.SelectedRows.Count > 0)
            {
                var confirmacion = MessageBox.Show("¿Está seguro de eliminar el registro seleccionado?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    modeloProveedor.Estado = EstadoEntidad.Deleted;
                    modeloProveedor.IdProveedor = Convert.ToInt32(dgbConsultaTabla.CurrentRow.Cells["IdProveedor"].Value);
                    string resultado = modeloProveedor.GrabarCambios();
                    MessageBox.Show(resultado, "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarProveedores();
                    CargarComboInteligente();
                    Reinicio();
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un proveedor de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            ListarProveedores();
            CargarComboInteligente();
        }

        private void LimpiarCampos()
        {
            txtIdProveedor.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtIdDireccion.Text = "1";
        }

        private void Reinicio()
        {
            panIngresoDatos.Enabled = false;
            LimpiarCampos();
        }
    }
}
