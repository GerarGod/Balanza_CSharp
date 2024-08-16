using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balanza
{
    public class ClsTicketEntidad
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
    }
}
