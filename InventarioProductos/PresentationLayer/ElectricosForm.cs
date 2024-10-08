using BusinessLayer.servicios;
using CommonLayer.Entidades;
using DataAccessLayer.ConeccionBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ElectricosForm : Form
    {
        private ElectricosBD _electricosBD;
        private ElectricosServicios _electricosServicios;
        bool nuevo = false;
        public ElectricosForm()
        {
            InitializeComponent();
            _electricosBD = new ElectricosBD();
            _electricosServicios = new ElectricosServicios();
            CargarElectricos();
        }

        private void CargarElectricos()
        {
            dvgElectricos.DataSource = _electricosBD.ObtenerElectricos();

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

            // Validaciones
            if (string.IsNullOrEmpty(nombre) ||
                !float.TryParse(txtPrecio.Text, out precio) ||
                !int.TryParse(txtCantidad.Text, out cantidad))
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente");
                return;
            }

            EntidadesElectricos entidadesElectricos = new EntidadesElectricos
            {
                nombre = nombre,
                precio = precio,
                cantidad = cantidad
            };

            if (nuevo)
            {
                _electricosServicios.GuardarElectricos(entidadesElectricos);
                MessageBox.Show("Registro guardado correctamente.");
            }
            else
            {

                if (dvgElectricos.SelectedRows.Count > 0)
                {
                    int id = int.Parse(dvgElectricos.CurrentRow.Cells[0].Value.ToString());
                    entidadesElectricos.id = id;
                    _electricosServicios.ModificarElectricos(entidadesElectricos);
                    MessageBox.Show("Registro modificado correctamente.");
                }
            }

            CargarElectricos();
            LimpiarCampos();
            nuevo = true;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dvgElectricos.SelectedRows.Count > 0)
            {
                txtNombre.Text = dvgElectricos.CurrentRow.Cells[1].Value.ToString();
                txtPrecio.Text = dvgElectricos.CurrentRow.Cells[2].Value.ToString();
                txtCantidad.Text = dvgElectricos.CurrentRow.Cells[3].Value.ToString();

                nuevo = false;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes de editar");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dvgElectricos.SelectedRows.Count < 1)
            {
                MessageBox.Show("Selecciona una fila");
            }
            else
            {
                var borrarFila = new DialogResult();
                borrarFila = MessageBox.Show("Está seguro que desea eliminar el dato?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (borrarFila == DialogResult.Yes)
                {
                    int id = int.Parse(dvgElectricos.CurrentRow.Cells[0].Value.ToString());
                    _electricosBD.EliminarElectricos(id);
                    CargarElectricos();
                }
            }
        }

        private void dvgElectricos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
