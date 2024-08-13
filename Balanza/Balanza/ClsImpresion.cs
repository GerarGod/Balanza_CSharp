using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Balanza
{
    public class ClsImpresion
    {
        private long nroTk;// As Long
        private long idImpresion;//  As Long
        private DateTime fechaHora;// As Date
        private long idEmpresa;//  As Long
        private string razonSocial;//  As String

        private string cUIT;//  As String
        private string codigoAduana;//  As String
        private string lotPlanta;//  As String
        private string lotBalanza;//  As String

        private string certificado;//  As String
        private string validadCert;//  As String
        private string nroPermEmbarque;//  As String
        private string idContenedor;//  As String
        private string identificadorBulto;//  As String
        private string idMercaderia;//  As Long
        private string mercaderia;//  As String
        private string peso;//  As Long

        public long NroTk { get => nroTk; set => nroTk = value; }
        public long IdImpresion { get => idImpresion; set => idImpresion = value; }
        public DateTime FechaHora { get => fechaHora; set => fechaHora = value; }
        public long IdEmpresa { get => idEmpresa; set => idEmpresa = value; }
        public string RazonSocial { get => razonSocial; set => razonSocial = value; }

        public string CUIT { get => cUIT; set => cUIT = value; }
        public string CodigoAduana { get => codigoAduana; set => codigoAduana = value; }
        public string LotPlanta { get => lotPlanta; set => lotPlanta = value; }
        public string LotBalanza { get => lotBalanza; set => lotBalanza = value; }

        public string Certificado { get => certificado; set => certificado = value; }
        public string ValidadCert { get => validadCert; set => validadCert = value; }
        public string NroPermEmbarque { get => nroPermEmbarque; set => nroPermEmbarque = value; }
        public string IdContenedor { get => idContenedor; set => idContenedor = value; }
        public string IdentificadorBulto { get => identificadorBulto; set => identificadorBulto = value; }
        public string IdMercaderia { get => idMercaderia; set => idMercaderia = value; }
        public string Mercaderia { get => mercaderia; set => mercaderia = value; }
        public string Peso { get => peso; set => peso = value; }

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
                    idEmpresa=long.Parse(row["IdEmpresa"].ToString());
                    razonSocial=row["RazonSocial"].ToString();
                    cUIT=row["RazonSocial"].ToString();
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
                            certificado = row["ValorText"].ToString();
                            break;
                        case "ValidadCert":
                            validadCert = row["ValorText"].ToString();
                            break;
                        case "CodigoAduana":
                            codigoAduana = row["ValorText"].ToString();
                            break;
                        case "LotPlanta":
                            lotPlanta = row["ValorText"].ToString();
                            break;
                        case "LotBalanza":
                            lotBalanza = row["ValorText"].ToString();
                            break;
                    }
                }
                // Cerrar la conexión
                ClsGlobalVariables.objDB.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
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
                        nroTk = 1;
                    }
                    else
                    {
                        nroTk = long.Parse(row["Ultimo"].ToString()) + 1;
                    }
                }
                // Cerrar la conexión
                ClsGlobalVariables.objDB.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }
        }

  


    }
}
