using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace BD_Escuela.Clases
{

    internal static class Conexion
    {

        //Revisar los datos de la base de datos y ajustar la cadena de conexión según sea necesario.
        private const string DefaultConnectionString = "User Id=SYSTEM;Password=1234;" +
                                                        "Data Source=localhost:1521/FREEPDB1";

        private static string ConnectionString =>
            Environment.GetEnvironmentVariable("ORACLE_CONNECTION_STRING") ?? DefaultConnectionString;


        public static OracleConnection Abrir()
        {
            var conn = new OracleConnection(ConnectionString);
            conn.Open();
            return conn;
        }

        //Ejecuta una sentencia SQL (INSERT, UPDATE, DELETE) y
        //devuelve true si fue exitosa, junto con el número de filas afectadas y un mensaje descriptivo.
        public static bool Ejecutar(string sql, out int filasAfectadas, out string mensaje)
        {
            if (string.IsNullOrWhiteSpace(sql))
            {
                filasAfectadas = 0;
                mensaje = "La sentencia SQL está vacía.";
                return false;
            }

            try
            {
                using var conn = new OracleConnection(ConnectionString);
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                int afectadas = cmd.ExecuteNonQuery();
                filasAfectadas = afectadas;
                mensaje = $"Sentencia ejecutada. Filas afectadas: {afectadas}.";
                return true;
            }
            catch (OracleException oex)
            {
                filasAfectadas = -1;
                mensaje = $"Error Oracle ({oex.Number}): {oex.Message}";
                return false;
            }
            catch (Exception ex)
            {
                filasAfectadas = -1;
                mensaje = ex.Message;
                return false;
            }
        }


        public static bool ComprobarConexion(out string mensaje)
        {
            try
            {
                using var conn = new OracleConnection(ConnectionString);
                conn.Open();
                conn.Close();
                mensaje = "Conexión exitosa.";
                return true;
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                return false;
            }
        }


        //Permite establecer la cadena de conexión en tiempo de ejecución
        // para escenarios de prueba o configuración manual.
        public static void EstablecerCadenaConexion(string cadena)
        {
            if (string.IsNullOrWhiteSpace(cadena)) throw new ArgumentException("La cadena de conexión no puede estar vacía.", nameof(cadena));
            Environment.SetEnvironmentVariable("ORACLE_CONNECTION_STRING", cadena);
        }

        //Ejecuta una consulta SQL (SELECT) y devuelve los resultados en un DataTable.
        public static DataTable Consultar(string consulta)
        {
            DataTable dt = new DataTable();
            try
            {
                using (OracleConnection conn = new OracleConnection(ConnectionString))
                {
                    conn.Open();

                    using (OracleDataAdapter da =
                           new OracleDataAdapter(consulta, conn))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dt;
        }

    }
}
