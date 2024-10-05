using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class MueblesForm : Form
    {
        private MueblesBD _mueblesBD;

        public MueblesForm()
        {
            InitializeComponent();
            _mueblesBD = new MueblesBD();
            CargarMuebles();
        }

        
        private void CargarMuebles()
        {
            dvgMuebles.DataSource = _mueblesBD.ObtenerMuebles();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            float precio = float.Parse(txtPrecio.Text);
            int cantidad = int.Parse(txtCantidad.Text);

            _mueblesBD.InsertarMueble(nombre, precio, cantidad);
            CargarMuebles();
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string nombre = txtNombre.Text;
            float precio = float.Parse(txtPrecio.Text);
            int cantidad = int.Parse(txtCantidad.Text);

            _mueblesBD.ActualizarMueble(id, nombre, precio, cantidad);
            CargarMuebles();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);

            _mueblesBD.EliminarMueble(id);
            CargarMuebles();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
        }

        private void dvgMuebles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dvgMuebles.Rows[e.RowIndex];
                txtId.Text = row.Cells["id"].Value.ToString();
                txtNombre.Text = row.Cells["nombre"].Value.ToString();
                txtPrecio.Text = row.Cells["precio"].Value.ToString();
                txtCantidad.Text = row.Cells["cantidad"].Value.ToString();
            }
        }
    }
}
