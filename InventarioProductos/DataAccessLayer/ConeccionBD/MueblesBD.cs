using Microsoft.Data.SqlClient;
using System.Data;
using DataAccessLayer.ConeccionBD;

namespace DataAccessLayer
{
    public class MueblesBD
    {
        private readonly CconeccionBD _conexion;

        public MueblesBD()
        {
            _conexion = new CconeccionBD();
        }

        
        public DataTable ObtenerMuebles()
        {
            using (SqlConnection con = _conexion.GetCconeccion())
            {
                con.Open();
                string query = "SELECT * FROM Muebles";
                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        
        public void InsertarMueble(string nombre, float precio, int cantidad)
        {
            using (SqlConnection con = _conexion.GetCconeccion())
            {
                con.Open();
                string query = "INSERT INTO Muebles (nombre, precio, cantidad) VALUES (@nombre, @precio, @cantidad)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        
        public void ActualizarMueble(int id, string nombre, float precio, int cantidad)
        {
            using (SqlConnection con = _conexion.GetCconeccion())
            {
                con.Open();
                string query = "UPDATE Muebles SET nombre=@nombre, precio=@precio, cantidad=@cantidad WHERE id=@id";
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

        
        public void EliminarMueble(int id)
        {
            using (SqlConnection con = _conexion.GetCconeccion())
            {
                con.Open();
                string query = "DELETE FROM Muebles WHERE id=@id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
