using Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Data;
using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Enum;
using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms
{
    public partial class Form1 : Form
    {
        public MySqlConnection Conn { get; set; }
        
        public ConvenioRepository ConvenioRepository = new ConvenioRepository();
        
        public PacienteRepository PacienteRepository = new PacienteRepository();
        
        public PessoaRepository PessoaRepository = new PessoaRepository();
        
        public EnderecoRepository EnderecoRepository = new EnderecoRepository();
        
        public Paciente PacienteForm = new Paciente();
        
        public Pessoa PessoaForm = new Pessoa();
        
        public Endereco EnderecoForm = new Endereco();
        int idPessoa;

        public Form1()
        {
            InitializeComponent();
        }

        #region Methods

        private void PopulaComboConvenio()
        {
            var listConvenios = ConvenioRepository.FetchAll();
            cboConvenio.DataSource = new BindingSource(listConvenios, null);
            cboConvenio.DisplayMember = "nome";
            cboConvenio.ValueMember = "id";
        }

        private void PopulaDataGridPessoa()
        {
            var listPessoas = PessoaRepository.GetPessoas();
            dvgPacientes.DataSource = new BindingSource(listPessoas, null);
        }

        /*private bool ValidaFormCadastro()
        {
            if (txtNome.Text.Equals(""))
                return false;
            if (txtCGCCPF.Text.Equals(""))
                return false;
            if (cboConvenio.SelectedIndex == -1)
                return false;
            if (mskCep.Text.Equals(""))
                return false;
            if (cboUf.SelectedIndex == -1)
                return false;
            if (txtCidade.Text.Equals(""))
                return false;
            if (txtRua.Text.Equals(""))
                return false;
            if (txtNumero.Text.Equals(""))
                return false;
            if (txtBairro.Text.Equals(""))
                return false;

            return true;
        }*/
        private bool ValidaFormCadastro()
        {
            if (txtNome.Text.Equals(""))
            {
                MessageBox.Show("Revise o Nome");
                return false;
            }
            if (txtCGCCPF.Text.Equals(""))
            {
                MessageBox.Show("Revise o CGC/CPF");
                return false;
            }
            if (cboConvenio.SelectedIndex == -1)
            {
                MessageBox.Show("Revise o Convenio");
                return false;
            }
            if (mskCep.Text.Equals(""))
            {
                MessageBox.Show("Revise o Cep");
                return false;
            }
            if (cboUf.SelectedIndex == -1)
            {
                MessageBox.Show("Revise a UF");
                return false;
            }
            if (txtCidade.Text.Equals(""))
            {
                MessageBox.Show("Revise a cidade");
                return false;
            }
            if (txtRua.Text.Equals(""))
            {
                MessageBox.Show("Revise a rua");
                return false;
            }
            if (txtNumero.Text.Equals(""))
            {
                MessageBox.Show("Revise o numero do endereço");
                return false;
            }
            if (txtBairro.Text.Equals(""))
            {
                MessageBox.Show("Revise o o bairro");
                return false;
            }
            return true;
        }
        private void AtualizaCamposForm()
        {
            PacienteForm.Pessoa.Nome = txtNome.Text;
            PacienteForm.Pessoa.CGCCPF = txtCGCCPF.Text.Replace(',', '.');
            PacienteForm.Convenio.Id = (int)cboConvenio.SelectedValue;

            EnderecoForm.CEP = mskCep.Text;
            EnderecoForm.Rua = txtRua.Text;
            EnderecoForm.Numero = Int32.Parse(txtNumero.Text);
            EnderecoForm.Bairro = txtBairro.Text;
            EnderecoForm.Cidade = txtCidade.Text;
        }

        #endregion



        #region Events
        
        private void Form1_Load(object sender, EventArgs e)
        {
            #region Teste Conexão
            /*Conn = ConnectionMySQL.GetConnection();

            if (Conn.State == ConnectionState.Open)
            {
                MessageBox.Show("Conexão efetuada com sucesso!", "Conexão ao MySQL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Conn.Close();
            }*/
            #endregion
            PopulaComboConvenio();
            PopulaDataGridPessoa();
        }

        #region Events

        private void btnSalvar_MouseEnter(object sender, EventArgs e)
        {

        }
        private void btnSalvar_MouseLeave(object sender, EventArgs e)
        {

        }


        private void rdFisica_CheckedChanged(object sender, EventArgs e)
        {
            lblCGCCPF.Text = "CPF:";
        }

        private void rdJuridica_CheckedChanged(object sender, EventArgs e)
        {
            lblCGCCPF.Text = "CNPJ:";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaFormCadastro())
            {
               

                    AtualizaCamposForm();

                    var pacienteResult = PacienteRepository.Save(PacienteForm, EnderecoForm);
                    if (pacienteResult.Id > 0)
                    {
                        MessageBox.Show($"Paciente {pacienteResult.Pessoa.Id} - {pacienteResult.Pessoa.Nome}", "Adicionar pessoa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PopulaDataGridPessoa();
                    }
            }

        }

        #endregion

        private void btnLimparPessoa_Click(object sender, EventArgs e)
        {
                txtNome.Clear();
                txtCGCCPF.Clear();
                cboConvenio.SelectedIndex = -1;
                txtRisco.Clear();
                txtProntuario.Clear();
            
        }

        private void btnLimparEndereco_Click(object sender, EventArgs e)
        {
            mskCep.Clear();
            cboUf.SelectedIndex = -1;
            txtCidade.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            var index = dvgPacientes.CurrentCell.RowIndex;
            int idPessoa = (int)dvgPacientes.Rows[index].Cells["id"].Value;
            if (PacienteRepository.Delete(idPessoa))
            {
                if (EnderecoRepository.Delete(idPessoa))
                {
                    if (PessoaRepository.Delete(idPessoa))
                    {
                        MessageBox.Show($"Pessoa {idPessoa} excluída com sucesso!", "Excluir Pessoa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            PopulaDataGridPessoa();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            PopulaDataGridPessoa();
        }

        private void dvgPacientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idPessoa = (int)dvgPacientes.Rows[e.RowIndex].Cells["id"].Value;
            MySqlDataReader readerPaciente = PacienteRepository.GetPacienteById(idPessoa);

            
            while (readerPaciente.Read())
            {
                
                txtNome.Text = readerPaciente.GetString("nome");
                txtCGCCPF.Text = readerPaciente.GetString("cgccpf");
                mskCep.Text = readerPaciente.GetString("CEP");
                txtRua.Text = readerPaciente.GetString("rua");
                txtNumero.Text = readerPaciente.GetString("numero");
                txtBairro.Text = readerPaciente.GetString("bairro");
                txtCidade.Text = readerPaciente.GetString("cidade");
                
            }
            // para puxar id MessageBox.Show($"{idPessoa}");
        }
        #endregion

        private void gpFormCadastro_Enter(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (idPessoa > 0)
            {
                    EnderecoForm.CEP = mskCep.Text;
                    EnderecoForm.Rua = txtRua.Text;
                    EnderecoForm.Numero = Int32.Parse(txtNumero.Text);
                    EnderecoForm.Bairro = txtBairro.Text;
                    EnderecoForm.Cidade = txtCidade.Text;

                if (EnderecoRepository.UPDATE(idPessoa, EnderecoForm))
                {
                    
                    /*if (PacienteRepository.UPDATE(idPessoa, PacienteForm))
                    {*/
                        PessoaForm.Nome = txtNome.Text;
                        PacienteForm.Convenio.Id = (int)cboConvenio.SelectedValue;

                        if (PessoaRepository.UPDATE(idPessoa,PessoaForm))
                        {
                            MessageBox.Show($"Informações atualizadas com sucesso!", "Excluir Pessoa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    //}
                }
                PopulaDataGridPessoa();
            }
            
        }
    }
}