using Microsoft.Data.SqlClient;
using System.Data;
using DataAccessLayer.ConeccionBD;
using CommonLayer.Entidades;

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

        public void InsertarMuebles(EntidadesMuebles entidadesMuebles)
        {
            using (SqlConnection con = _conexion.GetCconeccion())
            {
                string query = "INSERT INTO Muebles VALUES (@nombre, @precio, @cantidad)";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@nombre", entidadesMuebles.nombre);
                command.Parameters.AddWithValue("@precio", entidadesMuebles.precio);
                command.Parameters.AddWithValue("@cantidad", entidadesMuebles.cantidad);

                con.Open();
                command.ExecuteNonQuery();
            }
        }

        public void ActualizarMuebles(EntidadesMuebles entidadesMuebles)
        {
            using (SqlConnection con = _conexion.GetCconeccion())
            {
                con.Open();  // Asegúrate de abrir la conexión antes de ejecutar el comando
                string query = "UPDATE Muebles SET nombre=@nombre, precio=@precio, cantidad=@cantidad WHERE id=@id";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@nombre", entidadesMuebles.nombre);
                command.Parameters.AddWithValue("@precio", entidadesMuebles.precio);
                command.Parameters.AddWithValue("@cantidad", entidadesMuebles.cantidad);
                command.Parameters.AddWithValue("@id", entidadesMuebles.id);
                command.ExecuteNonQuery();
            }
        }


        public void EliminarAlimento(int id)
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
