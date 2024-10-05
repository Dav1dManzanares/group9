using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.ConeccionBD
{
    public class CconeccionBD
    {
        private readonly string _connectionString;

        public CconeccionBD()
        {
            _connectionString = "Data Source=MANZANARES\\SQLEXPRESS;Initial Catalog=InventarioProductos;Integrated Security=True;Trust Server Certificate=True";
        }

        public SqlConnection GetCconeccion()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
