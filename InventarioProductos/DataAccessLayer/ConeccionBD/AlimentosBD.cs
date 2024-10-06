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
            using(SqlConnection con = _conexion.GetCconeccion())
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

        public void InsertarAlimentos(string nombre,float precio, int cantidad)
        {
            using (SqlConnection con = _conexion.GetCconeccion())
            {
                con.Open();
                string query = "INSERT INTO Alimentos (nombre, precio, cantidad) VALUES (@nombre, @precio, @cantidad)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarAlimentos(int id, string nombre, float precio, int cantidad)
        {
            using (SqlConnection con = _conexion.GetCconeccion())
            {
                con.Open();
                string query = "UPDATE Alimentos SET nombre=@nombre, precio=@precio, cantidad=@cantidad WHERE id=@id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.ExecuteNonQuery();

                }
            }
        }

        public void EliminarAlimentos(int id)
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
