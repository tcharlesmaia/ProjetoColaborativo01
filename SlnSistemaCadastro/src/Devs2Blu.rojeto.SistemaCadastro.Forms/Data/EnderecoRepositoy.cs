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
    public class EnderecoRepositoy
    {
        //********************************
        public Int32 paciente { get; set; }

        public void getIDPessoa(Int32 ID_pessoa)
        {
            paciente = ID_pessoa;
        }
        //************************************

        public Endereco Save(Endereco endereco, Int32 paciente_id)
        {
            //estabelece conexão
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            

            try
            {
                //************************************************
                endereco.Id_endereco = SaveEndereco(paciente_id, endereco, conn);
                return endereco;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }
        private Int32 SaveEndereco(Int32 paciente_id, Endereco endereco, MySqlConnection conn)
        {
            try
            {
               //******************************
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_ENDERECO, conn);

                cmd.Parameters.Add("@idPessoa", MySqlDbType.VarChar, 50).Value = paciente_id;
                cmd.Parameters.Add("@CEP", MySqlDbType.VarChar, 25).Value = endereco.CEP;
                cmd.Parameters.Add("@rua", MySqlDbType.Enum).Value = endereco.Rua;
                cmd.Parameters.Add("@numero", MySqlDbType.VarChar, 50).Value = endereco.Numero;
                cmd.Parameters.Add("@bairro", MySqlDbType.VarChar, 25).Value = endereco.Bairro;
                cmd.Parameters.Add("@cidade", MySqlDbType.Enum).Value = endereco.Cidade;
                cmd.Parameters.Add("@uf", MySqlDbType.Enum).Value = endereco.UF;

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
        #region SQL Tcharles
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
        #endregion

    }
}
