
namespace ProjetoEstacionamento
{
    partial class Frm_Principal
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
            this.components = new System.ComponentModel.Container();
            this.Mnu_Principal = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConectarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DesconectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Entrada = new System.Windows.Forms.Button();
            this.Btn_Saida = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Hora = new System.Windows.Forms.Label();
            this.Btn_Registro = new System.Windows.Forms.Button();
            this.Grp_TabelaPreços = new System.Windows.Forms.GroupBox();
            this.Lbl_precoMensal = new System.Windows.Forms.Label();
            this.Lbl_precoDiaria = new System.Windows.Forms.Label();
            this.Lbl_preco7h = new System.Windows.Forms.Label();
            this.Lbl_preco6h = new System.Windows.Forms.Label();
            this.Lbl_preco5h = new System.Windows.Forms.Label();
            this.Lbl_preco4h = new System.Windows.Forms.Label();
            this.Lbl_preco3h = new System.Windows.Forms.Label();
            this.Lbl_preco2h = new System.Windows.Forms.Label();
            this.Lbl_preco1h = new System.Windows.Forms.Label();
            this.Lbl_Mensal = new System.Windows.Forms.Label();
            this.Lbl_Diaria = new System.Windows.Forms.Label();
            this.Lbl_7h = new System.Windows.Forms.Label();
            this.Lbl_6h = new System.Windows.Forms.Label();
            this.Lbl_5h = new System.Windows.Forms.Label();
            this.Lbl_4h = new System.Windows.Forms.Label();
            this.Lbl_3h = new System.Windows.Forms.Label();
            this.Lbl_2h = new System.Windows.Forms.Label();
            this.Lbl_1h = new System.Windows.Forms.Label();
            this.tb_EstacionadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetoEstacionamentoDataSet = new ProjetoEstacionamento.ProjetoEstacionamentoDataSet();
            this.tableAdapterManager = new ProjetoEstacionamento.ProjetoEstacionamentoDataSetTableAdapters.TableAdapterManager();
            this.Dg_TodosEstacionados = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mnu_Principal.SuspendLayout();
            this.Grp_TabelaPreços.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_EstacionadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoEstacionamentoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_TodosEstacionados)).BeginInit();
            this.SuspendLayout();
            // 
            // Mnu_Principal
            // 
            this.Mnu_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.relatoriosToolStripMenuItem});
            this.Mnu_Principal.Location = new System.Drawing.Point(0, 0);
            this.Mnu_Principal.Name = "Mnu_Principal";
            this.Mnu_Principal.Size = new System.Drawing.Size(784, 24);
            this.Mnu_Principal.TabIndex = 0;
            this.Mnu_Principal.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConectarToolStripMenuItem1,
            this.DesconectarToolStripMenuItem,
            this.funcionariosToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.loginToolStripMenuItem.Text = "Sistema";
            // 
            // ConectarToolStripMenuItem1
            // 
            this.ConectarToolStripMenuItem1.Name = "ConectarToolStripMenuItem1";
            this.ConectarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ConectarToolStripMenuItem1.Text = "Conectar";
            this.ConectarToolStripMenuItem1.Click += new System.EventHandler(this.ConectarToolStripMenuItem1_Click);
            // 
            // DesconectarToolStripMenuItem
            // 
            this.DesconectarToolStripMenuItem.Name = "DesconectarToolStripMenuItem";
            this.DesconectarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DesconectarToolStripMenuItem.Text = "Desconectar";
            this.DesconectarToolStripMenuItem.Click += new System.EventHandler(this.DesconectarToolStripMenuItem_Click);
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.funcionariosToolStripMenuItem.Text = "Funcionarios";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
            // 
            // Btn_Entrada
            // 
            this.Btn_Entrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Entrada.Location = new System.Drawing.Point(12, 485);
            this.Btn_Entrada.Name = "Btn_Entrada";
            this.Btn_Entrada.Size = new System.Drawing.Size(173, 64);
            this.Btn_Entrada.TabIndex = 1;
            this.Btn_Entrada.Text = "Entrada";
            this.Btn_Entrada.UseVisualStyleBackColor = false;
            this.Btn_Entrada.Click += new System.EventHandler(this.Btn_Entrada_Click);
            // 
            // Btn_Saida
            // 
            this.Btn_Saida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_Saida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Saida.Location = new System.Drawing.Point(599, 485);
            this.Btn_Saida.Name = "Btn_Saida";
            this.Btn_Saida.Size = new System.Drawing.Size(173, 64);
            this.Btn_Saida.TabIndex = 2;
            this.Btn_Saida.Text = "Saida";
            this.Btn_Saida.UseVisualStyleBackColor = false;
            this.Btn_Saida.Click += new System.EventHandler(this.Btn_Saida_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(430, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(342, 26);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // Lbl_Hora
            // 
            this.Lbl_Hora.AutoSize = true;
            this.Lbl_Hora.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Hora.Location = new System.Drawing.Point(12, 34);
            this.Lbl_Hora.Name = "Lbl_Hora";
            this.Lbl_Hora.Size = new System.Drawing.Size(256, 24);
            this.Lbl_Hora.TabIndex = 6;
            this.Lbl_Hora.Text = "DateTime.Now.ToString()";
            // 
            // Btn_Registro
            // 
            this.Btn_Registro.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Registro.Location = new System.Drawing.Point(191, 485);
            this.Btn_Registro.Name = "Btn_Registro";
            this.Btn_Registro.Size = new System.Drawing.Size(402, 64);
            this.Btn_Registro.TabIndex = 7;
            this.Btn_Registro.Text = "Registro";
            this.Btn_Registro.UseVisualStyleBackColor = false;
            this.Btn_Registro.Click += new System.EventHandler(this.Btn_Registro_Click);
            // 
            // Grp_TabelaPreços
            // 
            this.Grp_TabelaPreços.BackColor = System.Drawing.Color.Gainsboro;
            this.Grp_TabelaPreços.Controls.Add(this.Lbl_precoMensal);
            this.Grp_TabelaPreços.Controls.Add(this.Lbl_precoDiaria);
            this.Grp_TabelaPreços.Controls.Add(this.Lbl_preco7h);
            this.Grp_TabelaPreços.Controls.Add(this.Lbl_preco6h);
            this.Grp_TabelaPreços.Controls.Add(this.Lbl_preco5h);
            this.Grp_TabelaPreços.Controls.Add(this.Lbl_preco4h);
            this.Grp_TabelaPreços.Controls.Add(this.Lbl_preco3h);
            this.Grp_TabelaPreços.Controls.Add(this.Lbl_preco2h);
            this.Grp_TabelaPreços.Controls.Add(this.Lbl_preco1h);
            this.Grp_TabelaPreços.Controls.Add(this.Lbl_Mensal);
            this.Grp_TabelaPreços.Controls.Add(this.Lbl_Diaria);
            this.Grp_TabelaPreços.Controls.Add(this.Lbl_7h);
            this.Grp_TabelaPreços.Controls.Add(this.Lbl_6h);
            this.Grp_TabelaPreços.Controls.Add(this.Lbl_5h);
            this.Grp_TabelaPreços.Controls.Add(this.Lbl_4h);
            this.Grp_TabelaPreços.Controls.Add(this.Lbl_3h);
            this.Grp_TabelaPreços.Controls.Add(this.Lbl_2h);
            this.Grp_TabelaPreços.Controls.Add(this.Lbl_1h);
            this.Grp_TabelaPreços.Location = new System.Drawing.Point(16, 106);
            this.Grp_TabelaPreços.Name = "Grp_TabelaPreços";
            this.Grp_TabelaPreços.Size = new System.Drawing.Size(181, 334);
            this.Grp_TabelaPreços.TabIndex = 10;
            this.Grp_TabelaPreços.TabStop = false;
            this.Grp_TabelaPreços.Text = "groupBox1";
            // 
            // Lbl_precoMensal
            // 
            this.Lbl_precoMensal.AutoSize = true;
            this.Lbl_precoMensal.Location = new System.Drawing.Point(85, 309);
            this.Lbl_precoMensal.Name = "Lbl_precoMensal";
            this.Lbl_precoMensal.Size = new System.Drawing.Size(35, 13);
            this.Lbl_precoMensal.TabIndex = 17;
            this.Lbl_precoMensal.Text = "label9";
            // 
            // Lbl_precoDiaria
            // 
            this.Lbl_precoDiaria.AutoSize = true;
            this.Lbl_precoDiaria.Location = new System.Drawing.Point(85, 282);
            this.Lbl_precoDiaria.Name = "Lbl_precoDiaria";
            this.Lbl_precoDiaria.Size = new System.Drawing.Size(35, 13);
            this.Lbl_precoDiaria.TabIndex = 16;
            this.Lbl_precoDiaria.Text = "label8";
            // 
            // Lbl_preco7h
            // 
            this.Lbl_preco7h.AutoSize = true;
            this.Lbl_preco7h.Location = new System.Drawing.Point(85, 220);
            this.Lbl_preco7h.Name = "Lbl_preco7h";
            this.Lbl_preco7h.Size = new System.Drawing.Size(35, 13);
            this.Lbl_preco7h.TabIndex = 15;
            this.Lbl_preco7h.Text = "label7";
            // 
            // Lbl_preco6h
            // 
            this.Lbl_preco6h.AutoSize = true;
            this.Lbl_preco6h.Location = new System.Drawing.Point(85, 190);
            this.Lbl_preco6h.Name = "Lbl_preco6h";
            this.Lbl_preco6h.Size = new System.Drawing.Size(35, 13);
            this.Lbl_preco6h.TabIndex = 14;
            this.Lbl_preco6h.Text = "label6";
            // 
            // Lbl_preco5h
            // 
            this.Lbl_preco5h.AutoSize = true;
            this.Lbl_preco5h.Location = new System.Drawing.Point(85, 160);
            this.Lbl_preco5h.Name = "Lbl_preco5h";
            this.Lbl_preco5h.Size = new System.Drawing.Size(35, 13);
            this.Lbl_preco5h.TabIndex = 13;
            this.Lbl_preco5h.Text = "label5";
            // 
            // Lbl_preco4h
            // 
            this.Lbl_preco4h.AutoSize = true;
            this.Lbl_preco4h.Location = new System.Drawing.Point(85, 130);
            this.Lbl_preco4h.Name = "Lbl_preco4h";
            this.Lbl_preco4h.Size = new System.Drawing.Size(35, 13);
            this.Lbl_preco4h.TabIndex = 12;
            this.Lbl_preco4h.Text = "label4";
            // 
            // Lbl_preco3h
            // 
            this.Lbl_preco3h.AutoSize = true;
            this.Lbl_preco3h.Location = new System.Drawing.Point(85, 100);
            this.Lbl_preco3h.Name = "Lbl_preco3h";
            this.Lbl_preco3h.Size = new System.Drawing.Size(35, 13);
            this.Lbl_preco3h.TabIndex = 11;
            this.Lbl_preco3h.Text = "label3";
            // 
            // Lbl_preco2h
            // 
            this.Lbl_preco2h.AutoSize = true;
            this.Lbl_preco2h.Location = new System.Drawing.Point(85, 70);
            this.Lbl_preco2h.Name = "Lbl_preco2h";
            this.Lbl_preco2h.Size = new System.Drawing.Size(35, 13);
            this.Lbl_preco2h.TabIndex = 10;
            this.Lbl_preco2h.Text = "label2";
            // 
            // Lbl_preco1h
            // 
            this.Lbl_preco1h.AutoSize = true;
            this.Lbl_preco1h.Location = new System.Drawing.Point(85, 40);
            this.Lbl_preco1h.Name = "Lbl_preco1h";
            this.Lbl_preco1h.Size = new System.Drawing.Size(35, 13);
            this.Lbl_preco1h.TabIndex = 9;
            this.Lbl_preco1h.Text = "label1";
            // 
            // Lbl_Mensal
            // 
            this.Lbl_Mensal.AutoSize = true;
            this.Lbl_Mensal.Location = new System.Drawing.Point(6, 309);
            this.Lbl_Mensal.Name = "Lbl_Mensal";
            this.Lbl_Mensal.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Mensal.TabIndex = 8;
            this.Lbl_Mensal.Text = "label2";
            // 
            // Lbl_Diaria
            // 
            this.Lbl_Diaria.AutoSize = true;
            this.Lbl_Diaria.Location = new System.Drawing.Point(6, 282);
            this.Lbl_Diaria.Name = "Lbl_Diaria";
            this.Lbl_Diaria.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Diaria.TabIndex = 7;
            this.Lbl_Diaria.Text = "label1";
            // 
            // Lbl_7h
            // 
            this.Lbl_7h.AutoSize = true;
            this.Lbl_7h.Location = new System.Drawing.Point(6, 220);
            this.Lbl_7h.Name = "Lbl_7h";
            this.Lbl_7h.Size = new System.Drawing.Size(35, 13);
            this.Lbl_7h.TabIndex = 6;
            this.Lbl_7h.Text = "label7";
            // 
            // Lbl_6h
            // 
            this.Lbl_6h.AutoSize = true;
            this.Lbl_6h.Location = new System.Drawing.Point(6, 190);
            this.Lbl_6h.Name = "Lbl_6h";
            this.Lbl_6h.Size = new System.Drawing.Size(35, 13);
            this.Lbl_6h.TabIndex = 5;
            this.Lbl_6h.Text = "label6";
            // 
            // Lbl_5h
            // 
            this.Lbl_5h.AutoSize = true;
            this.Lbl_5h.Location = new System.Drawing.Point(6, 160);
            this.Lbl_5h.Name = "Lbl_5h";
            this.Lbl_5h.Size = new System.Drawing.Size(35, 13);
            this.Lbl_5h.TabIndex = 4;
            this.Lbl_5h.Text = "label5";
            // 
            // Lbl_4h
            // 
            this.Lbl_4h.AutoSize = true;
            this.Lbl_4h.Location = new System.Drawing.Point(6, 130);
            this.Lbl_4h.Name = "Lbl_4h";
            this.Lbl_4h.Size = new System.Drawing.Size(35, 13);
            this.Lbl_4h.TabIndex = 3;
            this.Lbl_4h.Text = "label4";
            // 
            // Lbl_3h
            // 
            this.Lbl_3h.AutoSize = true;
            this.Lbl_3h.Location = new System.Drawing.Point(6, 100);
            this.Lbl_3h.Name = "Lbl_3h";
            this.Lbl_3h.Size = new System.Drawing.Size(35, 13);
            this.Lbl_3h.TabIndex = 2;
            this.Lbl_3h.Text = "label3";
            // 
            // Lbl_2h
            // 
            this.Lbl_2h.AutoSize = true;
            this.Lbl_2h.Location = new System.Drawing.Point(6, 70);
            this.Lbl_2h.Name = "Lbl_2h";
            this.Lbl_2h.Size = new System.Drawing.Size(35, 13);
            this.Lbl_2h.TabIndex = 1;
            this.Lbl_2h.Text = "label2";
            // 
            // Lbl_1h
            // 
            this.Lbl_1h.AutoSize = true;
            this.Lbl_1h.Location = new System.Drawing.Point(6, 40);
            this.Lbl_1h.Name = "Lbl_1h";
            this.Lbl_1h.Size = new System.Drawing.Size(35, 13);
            this.Lbl_1h.TabIndex = 0;
            this.Lbl_1h.Text = "label1";
            // 
            // tb_EstacionadoBindingSource
            // 
            this.tb_EstacionadoBindingSource.DataMember = "Tb_Estacionado";
            this.tb_EstacionadoBindingSource.DataSource = this.projetoEstacionamentoDataSet;
            // 
            // projetoEstacionamentoDataSet
            // 
            this.projetoEstacionamentoDataSet.DataSetName = "ProjetoEstacionamentoDataSet";
            this.projetoEstacionamentoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.TB_ClienteTableAdapter = null;
            this.tableAdapterManager.Tb_EstacionadoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoEstacionamento.ProjetoEstacionamentoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Dg_TodosEstacionados
            // 
            this.Dg_TodosEstacionados.AllowUserToAddRows = false;
            this.Dg_TodosEstacionados.AllowUserToDeleteRows = false;
            this.Dg_TodosEstacionados.AllowUserToOrderColumns = true;
            this.Dg_TodosEstacionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_TodosEstacionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Placa,
            this.Modelo,
            this.Horario,
            this.Observacao});
            this.Dg_TodosEstacionados.Location = new System.Drawing.Point(221, 106);
            this.Dg_TodosEstacionados.Name = "Dg_TodosEstacionados";
            this.Dg_TodosEstacionados.ReadOnly = true;
            this.Dg_TodosEstacionados.Size = new System.Drawing.Size(551, 334);
            this.Dg_TodosEstacionados.TabIndex = 9;
            this.Dg_TodosEstacionados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "IdCliente";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 70;
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            this.Placa.Width = 70;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.Width = 130;
            // 
            // Horario
            // 
            this.Horario.HeaderText = "Horário";
            this.Horario.Name = "Horario";
            this.Horario.ReadOnly = true;
            this.Horario.Width = 60;
            // 
            // Observacao
            // 
            this.Observacao.HeaderText = "Observação";
            this.Observacao.Name = "Observacao";
            this.Observacao.ReadOnly = true;
            this.Observacao.Width = 247;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Grp_TabelaPreços);
            this.Controls.Add(this.Dg_TodosEstacionados);
            this.Controls.Add(this.Btn_Registro);
            this.Controls.Add(this.Lbl_Hora);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Btn_Saida);
            this.Controls.Add(this.Btn_Entrada);
            this.Controls.Add(this.Mnu_Principal);
            this.MainMenuStrip = this.Mnu_Principal;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estacionamento";
            this.Mnu_Principal.ResumeLayout(false);
            this.Mnu_Principal.PerformLayout();
            this.Grp_TabelaPreços.ResumeLayout(false);
            this.Grp_TabelaPreços.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_EstacionadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoEstacionamentoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_TodosEstacionados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Mnu_Principal;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DesconectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConectarToolStripMenuItem1;
        private System.Windows.Forms.Button Btn_Entrada;
        private System.Windows.Forms.Button Btn_Saida;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Lbl_Hora;
        private System.Windows.Forms.Button Btn_Registro;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private ProjetoEstacionamentoDataSet projetoEstacionamentoDataSet;
        private System.Windows.Forms.BindingSource tb_EstacionadoBindingSource;
        private ProjetoEstacionamentoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn horárioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox Grp_TabelaPreços;
        private System.Windows.Forms.Label Lbl_7h;
        private System.Windows.Forms.Label Lbl_6h;
        private System.Windows.Forms.Label Lbl_5h;
        private System.Windows.Forms.Label Lbl_4h;
        private System.Windows.Forms.Label Lbl_3h;
        private System.Windows.Forms.Label Lbl_2h;
        private System.Windows.Forms.Label Lbl_1h;
        private System.Windows.Forms.Label Lbl_Mensal;
        private System.Windows.Forms.Label Lbl_Diaria;
        private System.Windows.Forms.Label Lbl_precoMensal;
        private System.Windows.Forms.Label Lbl_precoDiaria;
        private System.Windows.Forms.Label Lbl_preco7h;
        private System.Windows.Forms.Label Lbl_preco6h;
        private System.Windows.Forms.Label Lbl_preco5h;
        private System.Windows.Forms.Label Lbl_preco4h;
        private System.Windows.Forms.Label Lbl_preco3h;
        private System.Windows.Forms.Label Lbl_preco2h;
        private System.Windows.Forms.Label Lbl_preco1h;
        private System.Windows.Forms.DataGridView Dg_TodosEstacionados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacao;
    }
}

