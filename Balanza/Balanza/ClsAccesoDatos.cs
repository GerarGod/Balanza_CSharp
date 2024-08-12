using System;
using System.Data;
using System.Data.OleDb;

namespace Balanza
{
    public class ClsAccesoDatos
    {
        private string _connectionString;
        private OleDbConnection _connection;

        public ClsAccesoDatos() { }


        public ClsAccesoDatos(string strDatabasePath,string strProvider)
        {
            if (strProvider == "default" || strProvider.Length==0 ) {
                strProvider= System.Windows.Forms.Application.StartupPath;
            }
            strProvider = strProvider + "\\DB_BASSO.accdb";

            _connectionString = $@"Provider={strProvider};Data Source={strDatabasePath};Persist Security Info=False;"; // Using recommended version 12.0 for Access 2010

            // Ensure the System.Data.OleDb reference is added to your project
            _connection = new OleDbConnection(_connectionString);

            OpenConnection();


            /*
             
             
                         try
            {
                string aceProvider = GetAccessVersion();
                if (aceProvider != null)
                {
                    Console.WriteLine($"Microsoft Access está instalado. Utiliza el proveedor: {aceProvider}");
                }
                else
                {
                    Console.WriteLine("No se detectó Microsoft Access instalado.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error al detectar la versión de Access: {ex.Message}");
            }
             
             */



        }

        // Abre la conexión a la base de datos
        public void OpenConnection()
        {
            try
            {
                if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                    Console.WriteLine("Conexión abierta exitosamente.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al abrir la conexión: {ex.Message}");
            }
        }

        // Cierra la conexión a la base de datos
        public void CloseConnection()
        {
            try
            {
                if (_connection.State != ConnectionState.Closed)
                {
                    _connection.Close();
                    Console.WriteLine("Conexión cerrada exitosamente.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cerrar la conexión: {ex.Message}");
            }
        }

        // Ejecuta una consulta y devuelve un DataTable con los resultados
        public DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (OleDbCommand command = new OleDbCommand(query, _connection)) // Using OleDbCommand
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(command)) // Using OleDbDataAdapter
                    {
                        adapter.Fill(dataTable);
                    }
                }
                Console.WriteLine("Consulta ejecutada exitosamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al ejecutar la consulta: {ex.Message}");
            }
            return dataTable;
        }

        // Ejecuta un comando SQL que no devuelve resultados (INSERT, UPDATE, DELETE)
        public int ExecuteNonQuery(string commandText)
        {
            int affectedRows = 0;
            try
            {
                using (OleDbCommand command = new OleDbCommand(commandText, _connection)) // Using OleDbCommand
                {
                    affectedRows = command.ExecuteNonQuery();
                }
                Console.WriteLine("Comando ejecutado exitosamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al ejecutar el comando: {ex.Message}");
            }
            return affectedRows;
        }
    }
    /*

        private static string GetAccessVersion()
        {
            string[] registryPaths = {
            @"SOFTWARE\Microsoft\Office",
            @"SOFTWARE\WOW6432Node\Microsoft\Office"
        };

            string aceProvider = null;

            foreach (string path in registryPaths)
            {
                using (RegistryKey officeKey = Registry.LocalMachine.OpenSubKey(path))
                {
                    if (officeKey == null) continue;

                    foreach (string subKeyName in officeKey.GetSubKeyNames())
                    {
                        // Verificamos que la subclave sea numérica (ejemplo: 14.0, 16.0, etc.)
                        if (double.TryParse(subKeyName, out _))
                        {
                            using (RegistryKey accessKey = officeKey.OpenSubKey($"{subKeyName}\\Access"))
                            {
                                if (accessKey != null)
                                {
                                    // Determinamos el proveedor en base a la versión
                                    switch (subKeyName)
                                    {
                                        case "12.0":
                                            aceProvider = "Microsoft.ACE.OLEDB.12.0";
                                            break;
                                        case "14.0":
                                            aceProvider = "Microsoft.ACE.OLEDB.14.0";
                                            break;
                                        case "15.0":
                                            aceProvider = "Microsoft.ACE.OLEDB.15.0";
                                            break;
                                        case "16.0":
                                            aceProvider = "Microsoft.ACE.OLEDB.16.0";
                                            break;

                                    }
                                    return aceProvider;
                                }
                            }
                        }
                    }
                }
            }

            return aceProvider;
        }     
     
     
     */
}