using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Practica_2_Sunat
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        //Acceso a la cadena de conexion
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        private static SqlConnection conexion = new SqlConnection(cadena);

        [WebMethod(Description = "Listar Tabla Sunat")]
        public DataSet Listar()
        {
            string consulta = "select * from TEmpresa";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta,conexion);
            DataSet data = new DataSet();
            adapter.Fill(data);
            return data;
        }

        [WebMethod(Description = "Buscar Tabla Sunat")]
        public DataSet Buscar(string texto, string criterio)
        {
            SqlCommand comando = new SqlCommand("PA_BuscarEmpresa", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Buscar", texto);
            comando.Parameters.AddWithValue("@Criterio", criterio);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataSet data = new DataSet();
            adapter.Fill(data);
            return data;
        }
    }
}
