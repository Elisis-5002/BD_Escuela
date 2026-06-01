using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.IO; 
using System.Net;
using System.Windows.Forms;

//(description = (retry_count = 20)(retry_delay = 3)(address = (protocol = tcps)(port = 1522)(host = adb.us - ashburn - 1.oraclecloud.com))(connect_data = (service_name = ga1215d003b3ce9_databasetec2026_high.adb.oraclecloud.com))(security = (ssl_server_dn_match = yes)));

namespace BD_Escuela.Clases
{

    internal static class Conexion
    {
        // Ruta donde DEBEN estar los archivos extraídos del ZIP
        private static readonly string RutaWallet = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Wallet");

        // Cadena de conexión con ubicación de Wallet explícita original
        private static string ConnectionString =>
            $"User Id=usr_admin;" +
            $"Password=AdministradorBase123;" +
            $"Data Source=(description=(retry_count=20)(retry_delay=3)(address=(protocol=tcps)(port=1522)(host=adb.us-ashburn-1.oraclecloud.com))(connect_data=(service_name=ga1215d003b3ce9_databasetec2026_high.adb.oraclecloud.com))(security=(ssl_server_dn_match=yes)));" +
            $"WALLET_LOCATION=(SOURCE=(METHOD=FILE)(METHOD_DATA=(DIRECTORY={RutaWallet})));" +
            $"Pooling = true; Min Pool Size=1; Max Pool Size=10;";

        

        public static bool Ejecutar(string sql, out int filasAfectadas, out string mensaje)
        {
            filasAfectadas = 0;

            if (string.IsNullOrWhiteSpace(sql))
            {
                mensaje = "La sentencia SQL está vacía.";
                return false;
            }

            try
            {
                // 1. Ejecución Principal
                using (var conn = new OracleConnection(ConnectionString))
                {
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = sql;
                        filasAfectadas = cmd.ExecuteNonQuery();
                    }
                } // La conexión se cierra aquí, liberando el recurso de forma segura.

                // 2. Auditoría de Sesión (Se ejecuta solo si la operación principal fue exitosa)
                if (filasAfectadas >= 0 && !string.IsNullOrEmpty(Sesion.Token))
                {
                    try
                    {
                        using (var connAud = new OracleConnection(ConnectionString))
                        {
                            connAud.Open();
                            using (var cmdAud = connAud.CreateCommand())
                            {
                                cmdAud.CommandText = "UPDATE sesiones SET ses_ultima_actividad = SYSDATE WHERE ses_token = :token";
                                cmdAud.Parameters.Add("token", OracleDbType.Varchar2).Value = Sesion.Token;
                                cmdAud.ExecuteNonQuery();
                            }
                        }
                    }
                    catch
                    {
                        // La auditoría es silenciosa: si falla, no afecta la operación principal
                    }
                }

                mensaje = $"Sentencia ejecutada. Filas afectadas: {filasAfectadas}.";
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

        public static void EstablecerCadenaConexion(string cadena)
        {
            if (string.IsNullOrWhiteSpace(cadena)) throw new ArgumentException("La cadena de conexión no puede estar vacía.", nameof(cadena));
            Environment.SetEnvironmentVariable("ORACLE_CONNECTION_STRING", cadena);
        }

        public static DataTable Consultar(string consulta)
        {
            DataTable dt = new DataTable();
            try
            {
                using (OracleConnection conn = new OracleConnection(ConnectionString))
                {
                    conn.Open();
                    using (OracleDataAdapter da = new OracleDataAdapter(consulta, conn))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en Consulta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        public static bool RegistrarProfesorSP(string nombre, string apellido, string email, string contra, out int idUsuarioGenerado, out string mensaje)
        {
            idUsuarioGenerado = -1;
            try
            {
                using var conn = new OracleConnection(ConnectionString);
                conn.Open();

                using var cmd = conn.CreateCommand();
                cmd.CommandText = "dar_alta_profesor";
                cmd.CommandType = CommandType.StoredProcedure;

                // Parámetros de entrada (IN) correspondientes al procedimiento de Oracle
                cmd.Parameters.Add("nombreP", OracleDbType.Varchar2).Value = nombre;
                cmd.Parameters.Add("apellidoP", OracleDbType.Varchar2).Value = apellido;
                cmd.Parameters.Add("emailP", OracleDbType.Varchar2).Value = email;
                cmd.Parameters.Add("contraP", OracleDbType.Varchar2).Value = contra;

                // Parámetro de salida (OUT)
                var outParam = new OracleParameter("usuarioGeneradoID", OracleDbType.Int32)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outParam);

                cmd.ExecuteNonQuery();

                // Recuperamos el ID generado por la base de datos
                if (outParam.Value != DBNull.Value)
                {
                    idUsuarioGenerado = Convert.ToInt32(outParam.Value.ToString());
                }

                mensaje = "Profesor y Usuario creados correctamente mediante Procedimiento.";
                return true;
            }
            catch (OracleException oex)
            {
                mensaje = $"Error de Base de Datos ({oex.Number}): {oex.Message}";
                return false;
            }
            catch (Exception ex)
            {
                mensaje = $"Error de sistema: {ex.Message}";
                return false;
            }
        }

        public static bool RegistrarAlumnoSP(string nombre, string apellido, string email, string contra, out int idUsuarioGenerado, out string mensaje)
        {
            idUsuarioGenerado = -1;
            try
            {
                using var conn = new OracleConnection(ConnectionString);
                conn.Open();

                using var cmd = conn.CreateCommand();
                cmd.CommandText = "dar_alta_alumno";
                cmd.CommandType = CommandType.StoredProcedure;

                // Parámetros de entrada (IN) para Alumno
                cmd.Parameters.Add("nombreA", OracleDbType.Varchar2).Value = nombre;
                cmd.Parameters.Add("apellidoA", OracleDbType.Varchar2).Value = apellido;
                cmd.Parameters.Add("emailA", OracleDbType.Varchar2).Value = email;
                cmd.Parameters.Add("contraA", OracleDbType.Varchar2).Value = contra;

                // Parámetro de salida (OUT)
                var outParam = new OracleParameter("usuarioGeneradoID", OracleDbType.Int32)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outParam);

                cmd.ExecuteNonQuery();

                if (outParam.Value != DBNull.Value)
                {
                    idUsuarioGenerado = Convert.ToInt32(outParam.Value.ToString());
                }

                mensaje = "Alumno y Usuario creados correctamente mediante Procedimiento.";
                return true;
            }
            catch (OracleException oex)
            {
                mensaje = $"Error de Base de Datos ({oex.Number}): {oex.Message}";
                return false;
            }
            catch (Exception ex)
            {
                mensaje = $"Error de sistema: {ex.Message}";
                return false;
            }
        }


    }

 

    }

