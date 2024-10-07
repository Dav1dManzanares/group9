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
    public class AlimentosBD
    {
        private readonly CconeccionBD _conexion;

        public AlimentosBD()
        {
            _conexion = new CconeccionBD();

        }

        public DataTable ObtenerAlimentos()
        {
            using (SqlConnection con = _conexion.GetCconeccion())
            {
                con.Open();
                string query = "SELECT * FROM Alimentos";
                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public void InsertarAlimentos(EntidadesAlimentos entidadesAlimentos)
        {
            using (SqlConnection con = _conexion.GetCconeccion())
            {
                string query = "INSERT INTO Alimentos VALUES (@nombre, @precio, @cantidad)";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@nombre", entidadesAlimentos.nombre);
                command.Parameters.AddWithValue("@precio", entidadesAlimentos.precio);
                command.Parameters.AddWithValue("@cantidad", entidadesAlimentos.cantidad);

                con.Open();
                command.ExecuteNonQuery();
            }
        }

        public void ActualizarAlimento(EntidadesAlimentos entidadesAlimentos)
        {
            using (SqlConnection con = _conexion.GetCconeccion())
            {
                con.Open();  // Asegúrate de abrir la conexión antes de ejecutar el comando
                string query = "UPDATE Alimentos SET nombre=@nombre, precio=@precio, cantidad=@cantidad WHERE id=@id";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@nombre", entidadesAlimentos.nombre);
                command.Parameters.AddWithValue("@precio", entidadesAlimentos.precio);
                command.Parameters.AddWithValue("@cantidad", entidadesAlimentos.cantidad);
                command.Parameters.AddWithValue("@id", entidadesAlimentos.id);
                command.ExecuteNonQuery();
            }
        }


        public void EliminarAlimento(int id)
        {
            using (SqlConnection con = _conexion.GetCconeccion())
            {
                con.Open();
                string query = "DELETE FROM Alimentos WHERE id=@id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

}

   

