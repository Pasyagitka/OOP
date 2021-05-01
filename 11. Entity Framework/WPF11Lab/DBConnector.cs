using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.IO;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.SqlServer.Management;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Management.SqlParser.SqlCodeDom;

namespace WPF11Lab
{
    public class DBConnector 
    {
        // private const string DataBaseScriptPath = "../../Resources/10.sql";
        // private static SqlConnection _connection;
        //
        // public DBConnector()
        // {
        //     try
        //     {
        //         CreateConnection();
        //     }
        //     catch (Exception e)
        //     {
        //         MessageBox.Show("Невозможно использовать БД");
        //     }
        // }

        public static SqlConnection GetConnection(string connectionstring)
        {
            return  new SqlConnection(ConfigurationManager.ConnectionStrings[connectionstring].ConnectionString);
        }

        // public void CreateConnection()
        // {
        //     try
        //     {
        //         _connection = DBConnector.GetConnection("connectASUS");
        //     }
        //     catch (SqlException)
        //     {
        //         _connection = DBConnector.GetConnection("connectASUSmaster");
        //         ExecuteScriptFile(DataBaseScriptPath);
        //     }
        // }
        //
        // public static void ExecuteScriptFile(string scriptfile)
        // {
        //     string script = File.ReadAllText(Path.GetFullPath(scriptfile));
        //     Server server = new Server(new ServerConnection(_connection));
        //     server.ConnectionContext.ExecuteNonQuery(script);
        // }

    }
}
