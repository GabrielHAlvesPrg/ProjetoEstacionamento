
namespace ProjetoEstacionamento
{
    partial class Frm_Registros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Registros));
            this.Btn_SelecionarCliente = new System.Windows.Forms.Button();
            this.Tsl_Principal = new System.Windows.Forms.ToolStrip();
            this.Tsl_Novo = new System.Windows.Forms.ToolStripButton();
            this.Dg_Clientes = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Consultar = new System.Windows.Forms.Button();
            this.Txt_FiltrarPlaca = new System.Windows.Forms.TextBox();
            this.Lbl_Filtro = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Tsl_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_SelecionarCliente
            // 
            this.Btn_SelecionarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_SelecionarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SelecionarCliente.Location = new System.Drawing.Point(12, 492);
            this.Btn_SelecionarCliente.Name = "Btn_SelecionarCliente";
            this.Btn_SelecionarCliente.Size = new System.Drawing.Size(582, 57);
            this.Btn_SelecionarCliente.TabIndex = 2;
            this.Btn_SelecionarCliente.Text = "Selecionar Cliente";
            this.Btn_SelecionarCliente.UseVisualStyleBackColor = false;
            this.Btn_SelecionarCliente.Click += new System.EventHandler(this.Btn_SelecionarCliente_Click);
            // 
            // Tsl_Principal
            // 
            this.Tsl_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsl_Novo});
            this.Tsl_Principal.Location = new System.Drawing.Point(0, 0);
            this.Tsl_Principal.Name = "Tsl_Principal";
            this.Tsl_Principal.Size = new System.Drawing.Size(784, 25);
            this.Tsl_Principal.TabIndex = 10;
            this.Tsl_Principal.Text = "toolStrip1";
            // 
            // Tsl_Novo
            // 
            this.Tsl_Novo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsl_Novo.Image = ((System.Drawing.Image)(resources.GetObject("Tsl_Novo.Image")));
            this.Tsl_Novo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsl_Novo.Name = "Tsl_Novo";
            this.Tsl_Novo.Size = new System.Drawing.Size(23, 22);
            this.Tsl_Novo.Text = "&Novo";
            this.Tsl_Novo.Click += new System.EventHandler(this.novoToolStripButton_Click);
            // 
            // Dg_Clientes
            // 
            this.Dg_Clientes.AllowUserToAddRows = false;
            this.Dg_Clientes.AllowUserToDeleteRows = false;
            this.Dg_Clientes.AllowUserToOrderColumns = true;
            this.Dg_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Placa,
            this.Marca,
            this.Nome});
            this.Dg_Clientes.Location = new System.Drawing.Point(12, 83);
            this.Dg_Clientes.Name = "Dg_Clientes";
            this.Dg_Clientes.ReadOnly = true;
            this.Dg_Clientes.Size = new System.Drawing.Size(760, 403);
            this.Dg_Clientes.TabIndex = 11;
            this.Dg_Clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg_Clientes_CellContentClick);
            this.Dg_Clientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg_Clientes_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Código Do Cliente";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa do Veículo";
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            this.Placa.Width = 150;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca do Veículo";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 150;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome Do Cliente";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 316;
            // 
            // Btn_Consultar
            // 
            this.Btn_Consultar.Location = new System.Drawing.Point(600, 492);
            this.Btn_Consultar.Name = "Btn_Consultar";
            this.Btn_Consultar.Size = new System.Drawing.Size(172, 57);
            this.Btn_Consultar.TabIndex = 12;
            this.Btn_Consultar.Text = "Consultar";
            this.Btn_Consultar.UseVisualStyleBackColor = true;
            this.Btn_Consultar.Click += new System.EventHandler(this.Btn_Consultar_Click);
            // 
            // Txt_FiltrarPlaca
            // 
            this.Txt_FiltrarPlaca.Location = new System.Drawing.Point(12, 57);
            this.Txt_FiltrarPlaca.Name = "Txt_FiltrarPlaca";
            this.Txt_FiltrarPlaca.Size = new System.Drawing.Size(115, 20);
            this.Txt_FiltrarPlaca.TabIndex = 13;
            // 
            // Lbl_Filtro
            // 
            this.Lbl_Filtro.AutoSize = true;
            this.Lbl_Filtro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Filtro.Location = new System.Drawing.Point(9, 38);
            this.Lbl_Filtro.Name = "Lbl_Filtro";
            this.Lbl_Filtro.Size = new System.Drawing.Size(86, 16);
            this.Lbl_Filtro.TabIndex = 14;
            this.Lbl_Filtro.Text = "Filtrar Placa";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(133, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 30);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_Registros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lbl_Filtro);
            this.Controls.Add(this.Txt_FiltrarPlaca);
            this.Controls.Add(this.Btn_Consultar);
            this.Controls.Add(this.Dg_Clientes);
            this.Controls.Add(this.Tsl_Principal);
            this.Controls.Add(this.Btn_SelecionarCliente);
            this.Name = "Frm_Registros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registros";
            this.Tsl_Principal.ResumeLayout(false);
            this.Tsl_Principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_SelecionarCliente;
        private System.Windows.Forms.ToolStrip Tsl_Principal;
        private System.Windows.Forms.ToolStripButton Tsl_Novo;
        private System.Windows.Forms.DataGridView Dg_Clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.Button Btn_Consultar;
        private System.Windows.Forms.Label Lbl_Filtro;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox Txt_FiltrarPlaca;
    }
}