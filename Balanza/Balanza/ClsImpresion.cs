using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.ComponentModel.Design.ObjectSelectorEditor;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Balanza
{
    public class ClsImpresion: ClsTicketEntidad
    {


        public bool CargarDatosEmpresa()
        {
            try
            {
                // Abrir la conexión
                ClsGlobalVariables.objDB.OpenConnection();

                // Ejecutar una consulta y obtener resultados
                string selectQuery = "SELECT * FROM Empresa";
                DataTable results = ClsGlobalVariables.objDB.ExecuteQuery(selectQuery);
                foreach (DataRow row in results.Rows)
                {
                    IdEmpresa=long.Parse(row["IdEmpresa"].ToString());
                    RazonSocial=row["RazonSocial"].ToString();
                    CUIT=row["RazonSocial"].ToString();
                }

                /*
                // Ejecutar un comando que no devuelve resultados
                string insertCommand = "INSERT INTO TuTabla (Nombre) VALUES ('Nuevo Nombre')";
                int rowsAffected = ClsGlobalVariables.objDB.ExecuteNonQuery(insertCommand);
                Console.WriteLine($"Filas afectadas: {rowsAffected}");
                */
                // Cerrar la conexión
                ClsGlobalVariables.objDB.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Error al cargar los datos de Empresa. Error:{0},{1}", Environment.NewLine, ex.Message)
                , "Inicio de Datos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
               );
                return false;

            }
            

        }
        
        
        public bool ObtenerParametros()
        {

            try
            {
                // Abrir la conexión
                ClsGlobalVariables.objDB.OpenConnection();

                // Ejecutar una consulta y obtener resultados
                string selectQuery = "SELECT * FROM Parametros where CodParametro in('Certificado','ValidadCert','CodigoAduana','LotPlanta','LotBalanza')";
                DataTable results = ClsGlobalVariables.objDB.ExecuteQuery(selectQuery);
                foreach (DataRow row in results.Rows)
                {
                    switch (row["CodParametro"].ToString())
                    {
                        case "Certificado":
                            Certificado = row["ValorText"].ToString();
                            break;
                        case "ValidadCert":
                            ValidadCert = row["ValorText"].ToString();
                            break;
                        case "CodigoAduana":
                            CodigoAduana = row["ValorText"].ToString();
                            break;
                        case "LotPlanta":
                            LotPlanta = row["ValorText"].ToString();
                            break;
                        case "LotBalanza":
                            LotBalanza = row["ValorText"].ToString();
                            break;
                    }
                }
                // Cerrar la conexión
                ClsGlobalVariables.objDB.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Error al cargar los datos de Parametros. Error:{0},{1}", Environment.NewLine, ex.Message)
                , "Inicio de Datos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
               );
                return false;

            }
        }
        public bool ObtenerProximoNroTk()
        {
            try
            {
                // Abrir la conexión
                ClsGlobalVariables.objDB.OpenConnection();

                // Ejecutar una consulta y obtener resultados
                string selectQuery = "SELECT * FROM Cons_UltimoNroTk";
                DataTable results = ClsGlobalVariables.objDB.ExecuteQuery(selectQuery);
                foreach (DataRow row in results.Rows)
                {

                    if (DBNull.Value.Equals(row["Ultimo"]) )
                    {
                        NroTk = 1;
                    }
                    else
                    {
                        NroTk = long.Parse(row["Ultimo"].ToString()) + 1;
                    }
                }
                // Cerrar la conexión
                ClsGlobalVariables.objDB.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Error al obtener el proximo Nro de Ticket. Error:{0},{1}", Environment.NewLine, ex.Message)
                , "Obtener Nro de Ticket",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
               );
                return false;

            }
        }
        public DataTable ObtenerImpresiones(string selectQuery)
        {
            // Abrir la conexión
            ClsGlobalVariables.objDB.OpenConnection();
            DataTable results = ClsGlobalVariables.objDB.ExecuteQuery(selectQuery);
            // Cerrar la conexión
            ClsGlobalVariables.objDB.CloseConnection();
            return results; // Retornar el DataTable

        }
        public bool InsertarImpresion() {
            string strSql;
            try
            {
                strSql = "INSERT INTO Impresiones (";
                strSql += "NroTk,";
                strSql += "FechaHora,";
                strSql += "IdEmpresa,";
                strSql += "CodigoAduana,";
                strSql += "LotPlanta,";
                strSql += "LotBalanza,";
                strSql += "Certificado,";
                strSql += "ValidadCert,";
                strSql += "NroPermEmbarque,";
                strSql += "IdContenedor,";
                strSql += "IdentificadorBulto,";
                strSql += "IdMercaderia,";
                strSql += "Peso) VALUES (";
                strSql += NroTk.ToString() + ",";
                strSql += "'" + FechaHora + "',"; /// Format(FechaHora, "yyyy-mm-dd hh:nn:ss") + "',";
                strSql += IdEmpresa + ",'";
                strSql += CodigoAduana + "','";
                strSql += LotPlanta + "','";
                strSql += LotBalanza + "','";
                strSql += Certificado + "','";
                strSql += ValidadCert + "','";
                strSql += NroPermEmbarque + "','";
                strSql += IdContenedor + "','";
                strSql += IdentificadorBulto + "',";
                strSql += IdMercaderia + ",";
                strSql += Peso + ")";
                // Abrir la conexión
                ClsGlobalVariables.objDB.OpenConnection();
                int resultado=ClsGlobalVariables.objDB.ExecuteNonQuery(strSql);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Error guardando la Impresion en la base de datos . Error:{0},{1}", Environment.NewLine, ex.Message)
                , "Insertar Impresion",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
               );
                return false;

            }
            finally {
                // Cerrar la conexión
                ClsGlobalVariables.objDB.CloseConnection();
            }
        }

        public bool GurdarParametros()
        {
            string strSql;
            int resultado;
            try
            {
                // Abrir la conexión
                ClsGlobalVariables.objDB.OpenConnection();

                strSql = $"update Parametros set ValorText='{Certificado}' where CodParametro ='Certificado'";
                resultado = ClsGlobalVariables.objDB.ExecuteNonQuery(strSql);

                strSql = $"update Parametros set ValorText='{ValidadCert}' where CodParametro ='ValidadCert'";
                resultado = ClsGlobalVariables.objDB.ExecuteNonQuery(strSql);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Error guardando datos en la  base de datos . Error:{0},{1}", Environment.NewLine, ex.Message)
                , "Insertar Impresion",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
               );
                return false;

            }
            finally
            {
                // Cerrar la conexión
                ClsGlobalVariables.objDB.CloseConnection();
            }
        }
        


    }
}
