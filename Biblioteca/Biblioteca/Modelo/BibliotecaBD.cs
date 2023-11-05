using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Modelo
{
    public class BibliotecaBD
    {
        public static SqlConnection conectar(string nomBD)
        {
            SqlConnection conectar = new SqlConnection("Data Source=localhost;Initial " +
                "Catalog = " + nomBD + "; Integrated Security = SSPI; ");
            try
            {
                conectar.Open();
                //MessageBox.Show("Se realizo la conexion...");
                return conectar;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falló la conexión " + ex.ToString());
                return null;
            }
        }
        public static SqlDataReader consulta(string conSQL, SqlConnection conector)
        {
            try
            {
                SqlCommand comando = new SqlCommand(conSQL, conector);
                SqlDataReader tabla = comando.ExecuteReader();
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falló la consulta " + ex.ToString());
                return null;
            }
        }
        public static int operar(string conSQL, SqlConnection conector)
        {
            int num = 0;
            try
            {
                SqlCommand comando = new SqlCommand(conSQL, conector);
                num = comando.ExecuteNonQuery();
                return num;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Falló la consulta" + e.ToString());
                return num;
            }
        }
        public static void cerrar(SqlConnection conector)
        {
            try
            {
                conector.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Falló la consulta" + e.ToString());

            }
        }
    }
}
