using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model;
using Devs2Blu.rojeto.SistemaCadastro.Forms.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.rojeto.SistemaCadastro.Forms
{
    public partial class Form1 : Form
    {
        //atributo de conexão
        public MySqlConnection Conn { get; set; }
        
        //criação de objeto da classe ConvenioRepository para utilizar seus métodos
        public ConvenioReository ConvenioReository = new ConvenioReository();

        //criação de objeto da classe PacienteRepository para utilizar seus métodos
        public PacienteRepository PacienteRepository = new PacienteRepository();
        
        public EnderecoRepositoy EnderecoRepositoy = new EnderecoRepositoy();

        public Form1()
        {
            //inicialização do formulário
            InitializeComponent();
        }

        //métodos próprios do objeto formulário
        #region Metodos Tcharles

        //função para 'puxar' a lista de convênios
        private void PopulaComboConvenios()
        {
            //aplica a função fetchAll criada na classe convenioRepository
            var listconvenios = ConvenioReository.FetchAll();

            //passa a lista de convênios capturadas no fetchall, como virão as duas colunas da tabela
            //todos os dados vão para a propriedade DataSource, o displayMember recebe os nomes
            //e a proriedade ValueMember os ids
            cboboxConvenio.DataSource = new BindingSource(listconvenios, null);
            cboboxConvenio.DisplayMember = "nome";
            cboboxConvenio.ValueMember = "id";
        }

        //função para pegar as informações dos pacientes para colocar no grid
        private void PopulaDataGridPessoa()
        {
            //aplica o getPessoas para pegar as pessoa da base
            var listpessoas = PacienteRepository.GetPessoas();
            //coloca as informações das pessoas no DataSource do objeto gridPacientes
            GridPacientes. DataSource = new BindingSource(listpessoas, null);
        }

        //função de referÊncia para validação de campos vazios do formulário
        private bool ValidaFormCadastro()
        {
            if (txtNome.Text.Equals(""))
                return false;
            if (mskCPF.Text.Equals(""))
                return false;
            if (txtBairro.Text.Equals(""))
                return false;
            if (txtCidade.Text.Equals(""))
                return false;
            if (txtNumero.Text.Equals(""))
                return false;
            if (txtRua.Text.Equals(""))
                return false;
            if (cboboxConvenio.SelectedIndex == -1)
                return false;
            /*if (mskCEP.Text.Equals(""))
                return false;
            if (cbUF.Text.Equals(""))
                return false;*/

            return true;
        }
        #endregion


        private void Form1_Load(object sender, EventArgs e)
        {
            #region TESTE conexão Tcharles
            /*Conn = ConnectionMySQL.GetConnection();

            if (Conn.State == ConnectionState.Open)
            {
                MessageBox.Show("Conexão efetuada com sucesso!", "Conexão ao MySQL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Conn.Close();
            }*/


            //ao carregar o formulário executa o carregamento do convenios e do grid de pessoas
            #endregion
            PopulaComboConvenios();
            PopulaDataGridPessoa();

            
        }
                            
        #region

        //altera propriedades dos objetos radiais quando alterar
        private void rdFisica_CheckedChanged(object sender, EventArgs e)
        {
                 lblCGCCF.Text = "CPF";
                lblCGCCF.Visible = true;

        }
        //altera propriedades dos objetos radiais quando alterar
        private void rdJuridica_CheckedChanged(object sender, EventArgs e)
        {
            
                lblCGCCF.Text = "CNPJ";
                lblCGCCF.Visible = true;

        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //faz a validação se não existe nenhum campo em branco no formulário
            if (ValidaFormCadastro())
            {
                //instancia um objeto da classe Pessoa para utilizar seus atributos
                Paciente paciente = new Paciente();
                //captura os atributos da caixa de texto para o objeto pessoa
                paciente.Pessoa.Nome = txtNome.Text;
                //captura os atributos da caixa de texto para o objeto pessoa
                paciente.Pessoa.CGCCPF = mskCPF.Text.Replace(',', '.');
                //captura o convênio selecionado na caixa de seleção
                paciente.Pessoa.Id = (int)cboboxConvenio.SelectedValue;



                //******************Bloco para salvar endereço
                Endereco endereco = new Endereco();
                endereco.Id = paciente.Pessoa.Id;
                endereco.Rua = txtRua.Text;
                endereco.Numero = int.Parse(txtNumero.Text);
                endereco.Bairro = txtBairro.Text;
                endereco.Cidade = txtCidade.Text;
                endereco.CEP = mskCEP.Text;
                endereco.UF = cbUF.Text;

                

                //função chamada em variável para salvar o paciente
                var pacienteResult = PacienteRepository.Save(paciente);

                //tentativa de pegar o ID da pessoa e salvar no endereço
                EnderecoRepositoy.getIDPessoa(paciente.Pessoa.Id);
                Endereco salvaEndereco = EnderecoRepositoy.Save(endereco, paciente.Pessoa.Id);
                //***********************************************************


                //validação para comaparar se o ID é maior que 0
                if (pacienteResult.Pessoa.Id>0)
                {
                    //mostra as informações de cadastro do paciente
                    MessageBox.Show($"Pessoa {paciente.Pessoa.Id} - {paciente.Pessoa.Nome} salva com sucesso!", "Adicionar Pessoa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                                               
            }

        }

        private void gbxLista_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
    #endregion
}
