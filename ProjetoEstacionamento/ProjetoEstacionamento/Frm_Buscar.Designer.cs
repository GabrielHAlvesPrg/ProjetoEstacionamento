
namespace ProjetoEstacionamento
{
    partial class Frm_Buscar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Buscar));
            this.Lbl_FiltroNome = new System.Windows.Forms.Label();
            this.Dg_TodosClientes = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomePai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeMae = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NaoTemPai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tB_ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetoEstacionamentoDataSet = new ProjetoEstacionamento.ProjetoEstacionamentoDataSet();
            this.tB_ClienteTableAdapter = new ProjetoEstacionamento.ProjetoEstacionamentoDataSetTableAdapters.TB_ClienteTableAdapter();
            this.tableAdapterManager = new ProjetoEstacionamento.ProjetoEstacionamentoDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.Txt_FiltroNome = new System.Windows.Forms.TextBox();
            this.Lbl_CadastrarVeiculo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Lbl_ExluirVeiculo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_TodosClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_ClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoEstacionamentoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_FiltroNome
            // 
            this.Lbl_FiltroNome.AutoSize = true;
            this.Lbl_FiltroNome.Location = new System.Drawing.Point(12, 14);
            this.Lbl_FiltroNome.Name = "Lbl_FiltroNome";
            this.Lbl_FiltroNome.Size = new System.Drawing.Size(35, 13);
            this.Lbl_FiltroNome.TabIndex = 3;
            this.Lbl_FiltroNome.Text = "label1";
            // 
            // Dg_TodosClientes
            // 
            this.Dg_TodosClientes.AllowUserToAddRows = false;
            this.Dg_TodosClientes.AllowUserToDeleteRows = false;
            this.Dg_TodosClientes.AllowUserToOrderColumns = true;
            this.Dg_TodosClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_TodosClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.NomePai,
            this.NomeMae,
            this.NaoTemPai,
            this.Cpf,
            this.Genero,
            this.Cep,
            this.Logradouro,
            this.Complemento,
            this.Numero,
            this.Bairro,
            this.Cidade,
            this.Estado,
            this.Telefone,
            this.Profissao,
            this.Placa,
            this.Marca,
            this.Modelo,
            this.Cor});
            this.Dg_TodosClientes.Location = new System.Drawing.Point(12, 60);
            this.Dg_TodosClientes.Name = "Dg_TodosClientes";
            this.Dg_TodosClientes.ReadOnly = true;
            this.Dg_TodosClientes.Size = new System.Drawing.Size(760, 421);
            this.Dg_TodosClientes.TabIndex = 4;
            this.Dg_TodosClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg_TodosClientes_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome do Cliente";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // NomePai
            // 
            this.NomePai.HeaderText = "Nome do Pai";
            this.NomePai.Name = "NomePai";
            this.NomePai.ReadOnly = true;
            // 
            // NomeMae
            // 
            this.NomeMae.HeaderText = "Nome da Mãe";
            this.NomeMae.Name = "NomeMae";
            this.NomeMae.ReadOnly = true;
            // 
            // NaoTemPai
            // 
            this.NaoTemPai.DataPropertyName = "Id";
            this.NaoTemPai.HeaderText = "Pai Desconhecido";
            this.NaoTemPai.Name = "NaoTemPai";
            this.NaoTemPai.ReadOnly = true;
            // 
            // Cpf
            // 
            this.Cpf.DataPropertyName = "Id";
            this.Cpf.HeaderText = "CPF";
            this.Cpf.Name = "Cpf";
            this.Cpf.ReadOnly = true;
            // 
            // Genero
            // 
            this.Genero.DataPropertyName = "Id";
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // Cep
            // 
            this.Cep.DataPropertyName = "Id";
            this.Cep.HeaderText = "CEP";
            this.Cep.Name = "Cep";
            this.Cep.ReadOnly = true;
            // 
            // Logradouro
            // 
            this.Logradouro.DataPropertyName = "Id";
            this.Logradouro.HeaderText = "Logradouro";
            this.Logradouro.Name = "Logradouro";
            this.Logradouro.ReadOnly = true;
            // 
            // Complemento
            // 
            this.Complemento.DataPropertyName = "Id";
            this.Complemento.HeaderText = "Complemento";
            this.Complemento.Name = "Complemento";
            this.Complemento.ReadOnly = true;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "Id";
            this.Numero.HeaderText = "Número";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Bairro
            // 
            this.Bairro.DataPropertyName = "Id";
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            // 
            // Cidade
            // 
            this.Cidade.DataPropertyName = "Id";
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Id";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Id";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // Profissao
            // 
            this.Profissao.DataPropertyName = "Id";
            this.Profissao.HeaderText = "Profissão";
            this.Profissao.Name = "Profissao";
            this.Profissao.ReadOnly = true;
            // 
            // Placa
            // 
            this.Placa.DataPropertyName = "Id";
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "Id";
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Id";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // Cor
            // 
            this.Cor.DataPropertyName = "Id";
            this.Cor.HeaderText = "Cor";
            this.Cor.Name = "Cor";
            this.Cor.ReadOnly = true;
            // 
            // tB_ClienteBindingSource
            // 
            this.tB_ClienteBindingSource.DataMember = "TB_Cliente";
            this.tB_ClienteBindingSource.DataSource = this.projetoEstacionamentoDataSet;
            // 
            // projetoEstacionamentoDataSet
            // 
            this.projetoEstacionamentoDataSet.DataSetName = "ProjetoEstacionamentoDataSet";
            this.projetoEstacionamentoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tB_ClienteTableAdapter
            // 
            this.tB_ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TB_ClienteTableAdapter = this.tB_ClienteTableAdapter;
            this.tableAdapterManager.Tb_EstacionadoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoEstacionamento.ProjetoEstacionamentoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(203, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 30);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txt_FiltroNome
            // 
            this.Txt_FiltroNome.Location = new System.Drawing.Point(15, 31);
            this.Txt_FiltroNome.Name = "Txt_FiltroNome";
            this.Txt_FiltroNome.Size = new System.Drawing.Size(182, 20);
            this.Txt_FiltroNome.TabIndex = 17;
            // 
            // Lbl_CadastrarVeiculo
            // 
            this.Lbl_CadastrarVeiculo.AutoSize = true;
            this.Lbl_CadastrarVeiculo.Location = new System.Drawing.Point(12, 494);
            this.Lbl_CadastrarVeiculo.Name = "Lbl_CadastrarVeiculo";
            this.Lbl_CadastrarVeiculo.Size = new System.Drawing.Size(35, 13);
            this.Lbl_CadastrarVeiculo.TabIndex = 18;
            this.Lbl_CadastrarVeiculo.Text = "label1";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(36, 510);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 39);
            this.button2.TabIndex = 19;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(706, 514);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 31);
            this.button3.TabIndex = 20;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Lbl_ExluirVeiculo
            // 
            this.Lbl_ExluirVeiculo.AutoSize = true;
            this.Lbl_ExluirVeiculo.Location = new System.Drawing.Point(684, 494);
            this.Lbl_ExluirVeiculo.Name = "Lbl_ExluirVeiculo";
            this.Lbl_ExluirVeiculo.Size = new System.Drawing.Size(35, 13);
            this.Lbl_ExluirVeiculo.TabIndex = 21;
            this.Lbl_ExluirVeiculo.Text = "label1";
            // 
            // Frm_Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Lbl_ExluirVeiculo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Lbl_CadastrarVeiculo);
            this.Controls.Add(this.Txt_FiltroNome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Dg_TodosClientes);
            this.Controls.Add(this.Lbl_FiltroNome);
            this.Name = "Frm_Buscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Buscar";
            ((System.ComponentModel.ISupportInitialize)(this.Dg_TodosClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_ClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoEstacionamentoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_FiltroNome;
        private ProjetoEstacionamentoDataSet projetoEstacionamentoDataSet;
        private System.Windows.Forms.BindingSource tB_ClienteBindingSource;
        private ProjetoEstacionamentoDataSetTableAdapters.TB_ClienteTableAdapter tB_ClienteTableAdapter;
        private ProjetoEstacionamentoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePai;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeMae;
        private System.Windows.Forms.DataGridViewTextBoxColumn NaoTemPai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Logradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Complemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cor;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox Txt_FiltroNome;
        private System.Windows.Forms.Label Lbl_CadastrarVeiculo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Lbl_ExluirVeiculo;
        public System.Windows.Forms.DataGridView Dg_TodosClientes;
    }
}