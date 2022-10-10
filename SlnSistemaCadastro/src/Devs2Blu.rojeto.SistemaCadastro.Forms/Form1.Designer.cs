namespace Devs2Blu.rojeto.SistemaCadastro.Forms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpFormCadastro = new System.Windows.Forms.GroupBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gpEndereco = new System.Windows.Forms.GroupBox();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCGCCF = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdJuridica = new System.Windows.Forms.RadioButton();
            this.rdFisica = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cboboxConvenio = new System.Windows.Forms.ComboBox();
            this.gbxLista = new System.Windows.Forms.GroupBox();
            this.GridPacientes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpFormCadastro.SuspendLayout();
            this.gpEndereco.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPacientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpFormCadastro
            // 
            this.gpFormCadastro.Controls.Add(this.mskCPF);
            this.gpFormCadastro.Controls.Add(this.btnLimpar);
            this.gpFormCadastro.Controls.Add(this.gpEndereco);
            this.gpFormCadastro.Controls.Add(this.txtNome);
            this.gpFormCadastro.Controls.Add(this.lblCGCCF);
            this.gpFormCadastro.Controls.Add(this.label2);
            this.gpFormCadastro.Controls.Add(this.groupBox2);
            this.gpFormCadastro.Controls.Add(this.label1);
            this.gpFormCadastro.Controls.Add(this.cboboxConvenio);
            this.gpFormCadastro.Location = new System.Drawing.Point(6, 34);
            this.gpFormCadastro.Name = "gpFormCadastro";
            this.gpFormCadastro.Size = new System.Drawing.Size(372, 306);
            this.gpFormCadastro.TabIndex = 2;
            this.gpFormCadastro.TabStop = false;
            this.gpFormCadastro.Text = "Formulário Cadastro";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(67, 84);
            this.mskCPF.Mask = "000.000.000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(107, 20);
            this.mskCPF.TabIndex = 24;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Yellow;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpar.Location = new System.Drawing.Point(143, 277);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(86, 22);
            this.btnLimpar.TabIndex = 23;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // gpEndereco
            // 
            this.gpEndereco.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gpEndereco.Controls.Add(this.cbUF);
            this.gpEndereco.Controls.Add(this.mskCEP);
            this.gpEndereco.Controls.Add(this.txtCidade);
            this.gpEndereco.Controls.Add(this.txtBairro);
            this.gpEndereco.Controls.Add(this.txtNumero);
            this.gpEndereco.Controls.Add(this.txtRua);
            this.gpEndereco.Controls.Add(this.label8);
            this.gpEndereco.Controls.Add(this.label7);
            this.gpEndereco.Controls.Add(this.label6);
            this.gpEndereco.Controls.Add(this.label5);
            this.gpEndereco.Controls.Add(this.label4);
            this.gpEndereco.Controls.Add(this.label3);
            this.gpEndereco.Location = new System.Drawing.Point(25, 120);
            this.gpEndereco.Name = "gpEndereco";
            this.gpEndereco.Size = new System.Drawing.Size(325, 156);
            this.gpEndereco.TabIndex = 13;
            this.gpEndereco.TabStop = false;
            this.gpEndereco.Text = "Endereço/Contato";
            // 
            // cbUF
            // 
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Location = new System.Drawing.Point(207, 19);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(55, 21);
            this.cbUF.TabIndex = 21;
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(59, 18);
            this.mskCEP.Mask = "00.000-000";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(84, 20);
            this.mskCEP.TabIndex = 20;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(60, 123);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(116, 20);
            this.txtCidade.TabIndex = 19;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(60, 95);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(116, 20);
            this.txtBairro.TabIndex = 18;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(59, 70);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(48, 20);
            this.txtNumero.TabIndex = 16;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(59, 45);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(241, 20);
            this.txtRua.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(181, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "UF:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Cidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Rua:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Número:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bairro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CEP:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(66, 56);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(284, 20);
            this.txtNome.TabIndex = 10;
            // 
            // lblCGCCF
            // 
            this.lblCGCCF.AutoSize = true;
            this.lblCGCCF.Location = new System.Drawing.Point(27, 84);
            this.lblCGCCF.Name = "lblCGCCF";
            this.lblCGCCF.Size = new System.Drawing.Size(30, 13);
            this.lblCGCCF.TabIndex = 9;
            this.lblCGCCF.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdJuridica);
            this.groupBox2.Controls.Add(this.rdFisica);
            this.groupBox2.Location = new System.Drawing.Point(222, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 49);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tioessoa";
            // 
            // rdJuridica
            // 
            this.rdJuridica.AutoSize = true;
            this.rdJuridica.Location = new System.Drawing.Point(68, 21);
            this.rdJuridica.Name = "rdJuridica";
            this.rdJuridica.Size = new System.Drawing.Size(63, 17);
            this.rdJuridica.TabIndex = 8;
            this.rdJuridica.Text = "Jurídica";
            this.rdJuridica.UseVisualStyleBackColor = true;
            this.rdJuridica.CheckedChanged += new System.EventHandler(this.rdJuridica_CheckedChanged);
            // 
            // rdFisica
            // 
            this.rdFisica.AutoSize = true;
            this.rdFisica.Checked = true;
            this.rdFisica.Location = new System.Drawing.Point(11, 19);
            this.rdFisica.Name = "rdFisica";
            this.rdFisica.Size = new System.Drawing.Size(54, 17);
            this.rdFisica.TabIndex = 7;
            this.rdFisica.TabStop = true;
            this.rdFisica.Text = "Física";
            this.rdFisica.UseVisualStyleBackColor = true;
            this.rdFisica.CheckedChanged += new System.EventHandler(this.rdFisica_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Convênio:";
            // 
            // cboboxConvenio
            // 
            this.cboboxConvenio.FormattingEnabled = true;
            this.cboboxConvenio.Location = new System.Drawing.Point(66, 23);
            this.cboboxConvenio.Name = "cboboxConvenio";
            this.cboboxConvenio.Size = new System.Drawing.Size(153, 21);
            this.cboboxConvenio.TabIndex = 2;
            // 
            // gbxLista
            // 
            this.gbxLista.Controls.Add(this.GridPacientes);
            this.gbxLista.Location = new System.Drawing.Point(390, 34);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Size = new System.Drawing.Size(323, 306);
            this.gbxLista.TabIndex = 3;
            this.gbxLista.TabStop = false;
            this.gbxLista.Enter += new System.EventHandler(this.gbxLista_Enter);
            // 
            // GridPacientes
            // 
            this.GridPacientes.AllowUserToAddRows = false;
            this.GridPacientes.AllowUserToOrderColumns = true;
            this.GridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPacientes.Location = new System.Drawing.Point(0, 31);
            this.GridPacientes.Name = "GridPacientes";
            this.GridPacientes.ReadOnly = true;
            this.GridPacientes.Size = new System.Drawing.Size(323, 306);
            this.GridPacientes.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bntCancelar);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Location = new System.Drawing.Point(6, 364);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 76);
            this.panel1.TabIndex = 4;
            // 
            // bntCancelar
            // 
            this.bntCancelar.BackgroundImage = global::Devs2Blu.rojeto.SistemaCadastro.Forms.Properties.Resources.baixados;
            this.bntCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntCancelar.Location = new System.Drawing.Point(113, 8);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(61, 55);
            this.bntCancelar.TabIndex = 1;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::Devs2Blu.rojeto.SistemaCadastro.Forms.Properties.Resources.imagesInterogation;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.Location = new System.Drawing.Point(16, 8);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(74, 55);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbxLista);
            this.Controls.Add(this.gpFormCadastro);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "+Desvs 2 Blu Sistema cadastro Hosital";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpFormCadastro.ResumeLayout(false);
            this.gpFormCadastro.PerformLayout();
            this.gpEndereco.ResumeLayout(false);
            this.gpEndereco.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridPacientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpFormCadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboboxConvenio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdJuridica;
        private System.Windows.Forms.RadioButton rdFisica;
        private System.Windows.Forms.Label lblCGCCF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbUF;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox gbxLista;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView GridPacientes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.MaskedTextBox mskCEP;
    }
}

