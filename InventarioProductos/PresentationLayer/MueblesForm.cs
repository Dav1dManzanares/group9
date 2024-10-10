using BusinessLayer.servicios;
using CommonLayer.Entidades;
using DataAccessLayer;
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
    public partial class MueblesForm : Form
    {
        private MueblesBD _mueblesBD;
        private MueblesServicios _mueblesServicio;
        bool nuevo = false;

        public MueblesForm()
        {
            InitializeComponent();
            _mueblesBD = new MueblesBD();
            _mueblesServicio = new MueblesServicios();
            CargarMuebles();
        }

        
        private void CargarMuebles()
        {
            dvgMuebles.DataSource = _mueblesBD.ObtenerMuebles();
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            float precio;
            int cantidad;

            if (System.Text.RegularExpressions.Regex.IsMatch(nombre, @"\d"))
            {
                MessageBox.Show("El nombre no puede contener números.");
                return;
            }

            if (!float.TryParse(txtPrecio.Text, out precio) || precio < 1 ||
                !int.TryParse(txtCantidad.Text, out cantidad) || cantidad < 1)
            {
                MessageBox.Show("precio o cantidad invalido");
                return;
            }

            EntidadesMuebles entidadesMuebles = new EntidadesMuebles
            {
                nombre = nombre,
                precio = precio,
                cantidad = cantidad
            };

            if (nuevo)
            {
                _mueblesServicio.GuardarElectricos(entidadesMuebles);
                MessageBox.Show("Registro guardado correctamente.");
            }
            else
            {
                if (dvgMuebles.SelectedRows.Count > 0)
                {
                    int id = int.Parse(dvgMuebles.CurrentRow.Cells[0].Value.ToString());
                    entidadesMuebles.id = id;
                    _mueblesServicio.ModificarElectricos(entidadesMuebles);
                    MessageBox.Show("Registro modificado correctamente.");
                }
            }

            CargarMuebles();
            LimpiarCampos();
            nuevo = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dvgMuebles.SelectedRows.Count > 0)
            {
                txtNombre.Text = dvgMuebles.CurrentRow.Cells[1].Value.ToString();
                txtPrecio.Text = dvgMuebles.CurrentRow.Cells[2].Value.ToString();
                txtCantidad.Text = dvgMuebles.CurrentRow.Cells[3].Value.ToString();

                nuevo = false;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes de editar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dvgMuebles.SelectedRows.Count < 1)
            {
                MessageBox.Show("Selecciona una fila");
            }
            else
            {
                var borrarFila = new DialogResult();
                borrarFila = MessageBox.Show("Está seguro que desea eliminar el dato?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (borrarFila == DialogResult.Yes)
                {
                    int id = int.Parse(dvgMuebles.CurrentRow.Cells[0].Value.ToString());
                    _mueblesBD.EliminarAlimento(id);
                    CargarMuebles();
                }
            }
        }

        

        private void dvgMuebles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
