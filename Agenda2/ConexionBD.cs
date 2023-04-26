using System;
using Npgsql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Agenda2
{
    class ConexionBD
    {

        NpgsqlConnection conn = new NpgsqlConnection();

        String conexion = "server=localhost;port=5432;user id=postgres;password=postgres;database=agenda;";

        private NpgsqlConnection EstablecerConexion()
        {
            try
            {
                conn.ConnectionString = conexion;
                conn.Open();
            }
            catch(NpgsqlException)
            {
                MessageBox.Show("NO HAY CONEXION CON LA BASE DE DATOS");
            }

            return conn;
        }
        private void CerrarConexion()
        {
            conn.Close();
        }

        public DataTable BuscarContacto(string nombre)
        {
            EstablecerConexion();

            string query = "SELECT * FROM CONTACTOS WHERE NOMBRES='"+nombre+"'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            CerrarConexion();

            return tabla;
        }

        public bool EliminarContacto(string id)
        {
            EstablecerConexion();

            string query = "DELETE FROM CONTACTOS WHERE \"id\" = "+ id;
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            if(conector.ExecuteNonQuery() > 0)
            {
                CerrarConexion();
                return true;           
            }
            CerrarConexion();
            return false;        
        }
    }
}
