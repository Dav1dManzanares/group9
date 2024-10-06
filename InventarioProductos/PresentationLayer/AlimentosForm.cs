using DataAccessLayer.ConeccionBD;
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
    public partial class AlimentosForm : Form
    {
        private AlimentosBD _alimentosBD;
        public AlimentosForm()
        {
            InitializeComponent();
            _alimentosBD = new AlimentosBD();
            CargarAlimentos();
        }

        private void CargarAlimentos()
        {
            dvgAlimentos.DataSource = _alimentosBD.ObtenerAlimentos();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            float precio = float.Parse(txtPrecio.Text);
            int cantidad = int.Parse(txtCantidad.Text);

            _alimentosBD.InsertarAlimentos(nombre, precio, cantidad);
            CargarAlimentos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void dvgAlimentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dvgAlimentos.Rows[e.RowIndex];
                txtId.Text = row.Cells["id"].Value.ToString();
                txtNombre.Text = row.Cells["nombre"].Value.ToString();
                txtPrecio.Text = row.Cells["precio"].Value.ToString();
                txtCantidad.Text = row.Cells["cantidad"].Value.ToString();
            }
        }
    }
}
