using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.rojeto.SistemaCadastro.Forms.Data
{
    public class ConvenioReository  // classe que vai buscar na base as opções de 'planos de saúde'
        //salvando as informações em um objeto que será utilizado para alimentar o campo do formulário.
        
    {

        public MySqlDataReader FetchAll()   // faz um 'fatiamento' das opções de planos presentes na base
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection(); // estabelece a conexão com a base de dados
            

            try
            {
                // faz uma tentativa de conexão passando a query do SQL e a conexão
                // na sequencia utiliza a função responsável por executar a query 'ExecuteReader'
                
                MySqlCommand cmd = new MySqlCommand(SQL_Selection_Convenio, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                
                // retorna a conexão se estabelecida, se não entra no tratamento de erro
                return dataReader;
            }
            catch (MySqlException   myExc)
            {
               // objeto da classe MySqlException faz um tratamento de erro
                MessageBox.Show(myExc.Message, "Erro de MySQL");
                throw;
            }

        }
        #region SQL_Tcharles
        //query SQL que busca os convênios disponíveis na tabela convênio
        private const String SQL_Selection_Convenio = "Select * From convenio";
    }
        #endregion
}
