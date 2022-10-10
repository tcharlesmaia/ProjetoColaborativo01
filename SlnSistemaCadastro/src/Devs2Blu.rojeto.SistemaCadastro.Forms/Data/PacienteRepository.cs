using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.rojeto.SistemaCadastro.Forms.Data
{
    public class PacienteRepository //classe de objeto responsável por 'buscar' da base os registros dos pacientes
    {
        //*********************************************************
        public static object Pessoa_ID { get; set; }
        public int retornaIDpessoa(int pessoa_ID)
        {
            Pessoa_ID = pessoa_ID;
            return (int)Pessoa_ID;
        }
        
        //***********************************************************

        //passo um objeto da classe paciente para poder utilizar seus métodos e atributos
        public Paciente Save(Paciente paciente)
        {
            //estabelece conexão
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                //tenta realizar o salvamento dos dados do paciente, na propriedade Id do objeto pessoa
                paciente.Pessoa.Id = SavePessoa(paciente, conn);

                //*******************************
                int pessoa_ID = retornaIDpessoa(paciente.Pessoa.Id);
                //********************************

                return paciente;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        //função para 'salvar' os dados da base através de queries SQL
        private Int32 SavePessoa(Paciente paciente, MySqlConnection conn)
        {
            try
            {
                //comando para criar um objeto que contém a query 'SQL_INSERT_PESSOA' e a conexão
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_PESSOA, conn);

                //parâmetro Nome do objeto paciente.Pessoa adicionado ao valor @nome
                //o mesmo acontece para os parâmetros cgccpf e tiopo pessoa
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = paciente.Pessoa.Nome;
                cmd.Parameters.Add("@cgccpf", MySqlDbType.VarChar, 25).Value = paciente.Pessoa.CGCCPF;
                cmd.Parameters.Add("@tiopessoa", MySqlDbType.Enum).Value = paciente.Pessoa.TipoPessoa;

                //comando nativo do objeto MySQL para executar a query
                cmd.ExecuteNonQuery();

                //função que após a inserção do registro, retorna o último Ia gerado pela base
                return (Int32)cmd.LastInsertedId;
            }
            catch (MySqlException myExc)
            {
                //função para tratamento de erros
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        //Função para 'buscar' as pessoas que já estão salvas na base
        internal MySqlDataReader GetPessoas()

        {
            //conexão
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                //objeto com uma query e uma conexão
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_PESSOAS, conn);
                
                //objeto que executa a query e já retorna seus dados no objeto datareader
                MySqlDataReader dataReader = cmd.ExecuteReader();
                return dataReader;
            }
            catch (MySqlException myExc)
            {
                //tratamento de erro
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        // a partir deste ponto estão as queries SQL que serão executadas nas funções acima
        #region SQLs Tcharles   
        private const String SQL_INSERT_PESSOA = @"INSERT INTO pessoa
(nome,
cgccpf,
tiopessoa,
flstatus)
VALUES
(@nome,
@cgccpf,
@tiopessoa,
'A')";
        private const String SQL_INSERT_ENDERECO = @"INSERT INTO endereco
(id_pessoa,
cep,
rua,
numero,
bairro,
cidade,
uf)
VALUES
(@idPessoa,
@CEP,
@rua,
@numero,
@bairro,
@cidade,
@uf)";
        private const String SQL_INSERT_PACIENTE = @"INSERT INTO paciente
(id_pessoa,
id_convenio,
numero_prontuario,
paciente_risco,
flstatus,
flobito)
VALUES
(@id_pessoa,
@id_convenio,
@numero_prontuario,
@paciente_risco,
'A',
0)";
        private const String SQL_SELECT_PESSOAS = @"SELECT id, nome, cgccpf, flstatus from pessoa";

        #endregion


    }
}
