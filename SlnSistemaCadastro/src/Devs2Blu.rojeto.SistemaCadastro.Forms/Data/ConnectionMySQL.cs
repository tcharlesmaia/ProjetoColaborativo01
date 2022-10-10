using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.rojeto.SistemaCadastro.Forms.Data
{
    public class ConnectionMySQL
    {
        public static String ConnectionString { get; set; }
        public static String Server { get; set; }
        public static String Database { get; set; }
        public static String User { get; set; }
        public static String Password { get; set; }

        public static MySqlConnection GetConnection()
        {
            Server = "localhost";
            Database = "sistemacadastro";
            User = "root";
            Password = "root";
            ConnectionString = $"Persist Security Info=False;server={Server};database={Database};uid={User};server={Server};database={Database};uid={User};pwd='{Password}'";
            var conn = new MySqlConnection(ConnectionString);



            try
            {
                conn.Open();
            }
            catch (MySqlException myex)
        
            {
                MessageBox.Show(myex.Message, "Erro ao Conectar");
                throw;
            }
            // observar esse retorno, não há no código do professor
            return conn;

        }
    }
}   
   


