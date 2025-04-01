using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace CapaDatos
{
    public class DocumentacionConexion
    {
        public static string miConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\JoSoft\AppConsola\CapaDatos\DBDocumentacion.mdf;Integrated Security=True";
                                        
        public SqlConnection dbconection = new SqlConnection(miConexion);

    }
}
