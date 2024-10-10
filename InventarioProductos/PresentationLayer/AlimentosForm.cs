using BusinessLayer.servicios;
using CommonLayer.Entidades;
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
        private AlimentosServicios _alimentosServicios;
        bool nuevo = false;
        public AlimentosForm()
        {
            InitializeComponent();
            _alimentosBD = new AlimentosBD();
            _alimentosServicios = new AlimentosServicios();
            CargarAlimentos();
        }

        private void CargarAlimentos()
        {
            dvgAlimentos.DataSource = _alimentosBD.ObtenerAlimentos();

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

            EntidadesAlimentos entidadesAlimentos = new EntidadesAlimentos
            {
                nombre = nombre,
                precio = precio,
                cantidad = cantidad
            };

            if (nuevo)
            {
                _alimentosServicios.GuardarElectricos(entidadesAlimentos);
                MessageBox.Show("Registro guardado correctamente.");
            }
            else
            {
                if (dvgAlimentos.SelectedRows.Count > 0)
                {
                    int id = int.Parse(dvgAlimentos.CurrentRow.Cells[0].Value.ToString());
                    entidadesAlimentos.id = id;
                    _alimentosServicios.ModificarElectricos(entidadesAlimentos);
                    MessageBox.Show("Registro modificado correctamente.");
                }
            }

            CargarAlimentos();
            LimpiarCampos();
            nuevo = true;


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dvgAlimentos.SelectedRows.Count > 0)
            {
                txtNombre.Text = dvgAlimentos.CurrentRow.Cells[1].Value.ToString();
                txtPrecio.Text = dvgAlimentos.CurrentRow.Cells[2].Value.ToString();
                txtCantidad.Text = dvgAlimentos.CurrentRow.Cells[3].Value.ToString();

                nuevo = false;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes de editar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dvgAlimentos.SelectedRows.Count < 1)
            {
                MessageBox.Show("Selecciona una fila");
            }
            else
            {
                var borrarFila = new DialogResult();
                borrarFila = MessageBox.Show("Está seguro que desea eliminar el dato?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (borrarFila == DialogResult.Yes)
                {
                    int id = int.Parse(dvgAlimentos.CurrentRow.Cells[0].Value.ToString());
                    _alimentosBD.EliminarAlimento(id);
                    CargarAlimentos();
                }
            }
        }

        private void dvgAlimentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
