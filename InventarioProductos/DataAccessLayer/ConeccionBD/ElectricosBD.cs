using CommonLayer.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.ConeccionBD
{
    public class ElectricosBD
    {
        private readonly CconeccionBD _conexion;
        
        public ElectricosBD()
        {
            _conexion = new CconeccionBD();
        }

        public DataTable ObtenerElectricos()
        {
            using (SqlConnection con = _conexion.GetCconeccion())
            {
                con.Open();
                string query = "SELECT * FROM ProductosElectronics";
                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public void InsertarElectricos(EntidadesElectricos entidadesElectricos)
        {
            using (SqlConnection con = _conexion.GetCconeccion())
            {
                string query = "INSERT INTO ProductosElectronics VALUES (@nombre, @precio, @cantidad)";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@nombre", entidadesElectricos.nombre);
                command.Parameters.AddWithValue("@precio", entidadesElectricos.precio);
                command.Parameters.AddWithValue("@cantidad", entidadesElectricos.cantidad);

                con.Open();
                command.ExecuteNonQuery();
            }
        }


        public void ActualizarElectricos(EntidadesElectricos entidadesElectricos)
        {
            using (SqlConnection con = _conexion.GetCconeccion())
            {
                con.Open();  // Asegúrate de abrir la conexión antes de ejecutar el comando
                string query = "UPDATE ProductosElectronics SET nombre=@nombre, precio=@precio, cantidad=@cantidad WHERE id=@id";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@nombre", entidadesElectricos.nombre);
                command.Parameters.AddWithValue("@precio", entidadesElectricos.precio);
                command.Parameters.AddWithValue("@cantidad", entidadesElectricos.cantidad);
                command.Parameters.AddWithValue("@id", entidadesElectricos.id);

                command.ExecuteNonQuery();  
            }
        }


        public void EliminarElectricos(int id)
        {
            using (SqlConnection con = _conexion.GetCconeccion())
            {
                con.Open();
                string query = "DELETE FROM ProductosElectronics WHERE id=@id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

}
