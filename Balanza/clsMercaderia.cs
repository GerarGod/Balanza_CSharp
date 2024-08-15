using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balanza
{
    public class clsMercaderia
    {
        
        public DataTable ObtenerMercaderia()
        {
            // Abrir la conexión
            ClsGlobalVariables.objDB.OpenConnection();
            string selectQuery = "SELECT * FROM Mercaderia";
            DataTable results = ClsGlobalVariables.objDB.ExecuteQuery(selectQuery);

            // Cerrar la conexión
            ClsGlobalVariables.objDB.CloseConnection();
            return results; // Retornar el DataTable

        }

    }
}
