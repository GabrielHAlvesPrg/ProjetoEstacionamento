
namespace ProjetoEstacionamento
{
    partial class Frm_Entrada
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
            this.Txt_Placa = new System.Windows.Forms.TextBox();
            this.Lbl_Placa = new System.Windows.Forms.Label();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.Lbl_Modelo = new System.Windows.Forms.Label();
            this.Lbl_Observação = new System.Windows.Forms.Label();
            this.Txb_Observação = new System.Windows.Forms.TextBox();
            this.Lbl_Hora = new System.Windows.Forms.Label();
            this.Msk_Horario = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Modelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_IdCliente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Txt_Placa
            // 
            this.Txt_Placa.Location = new System.Drawing.Point(92, 25);
            this.Txt_Placa.Name = "Txt_Placa";
            this.Txt_Placa.Size = new System.Drawing.Size(165, 20);
            this.Txt_Placa.TabIndex = 16;
            // 
            // Lbl_Placa
            // 
            this.Lbl_Placa.AutoSize = true;
            this.Lbl_Placa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Placa.Location = new System.Drawing.Point(21, 25);
            this.Lbl_Placa.Name = "Lbl_Placa";
            this.Lbl_Placa.Size = new System.Drawing.Size(51, 19);
            this.Lbl_Placa.TabIndex = 15;
            this.Lbl_Placa.Text = "Placa";
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(182, 258);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancelar.TabIndex = 14;
            this.Btn_Cancelar.Text = "button2";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.Location = new System.Drawing.Point(25, 258);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ok.TabIndex = 13;
            this.Btn_Ok.Text = "button1";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // Lbl_Modelo
            // 
            this.Lbl_Modelo.AutoSize = true;
            this.Lbl_Modelo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Modelo.Location = new System.Drawing.Point(21, 68);
            this.Lbl_Modelo.Name = "Lbl_Modelo";
            this.Lbl_Modelo.Size = new System.Drawing.Size(65, 19);
            this.Lbl_Modelo.TabIndex = 12;
            this.Lbl_Modelo.Text = "Modelo";
            // 
            // Lbl_Observação
            // 
            this.Lbl_Observação.AutoSize = true;
            this.Lbl_Observação.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Observação.Location = new System.Drawing.Point(22, 149);
            this.Lbl_Observação.Name = "Lbl_Observação";
            this.Lbl_Observação.Size = new System.Drawing.Size(86, 16);
            this.Lbl_Observação.TabIndex = 18;
            this.Lbl_Observação.Text = "Observação:";
            // 
            // Txb_Observação
            // 
            this.Txb_Observação.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_Observação.Location = new System.Drawing.Point(25, 168);
            this.Txb_Observação.Multiline = true;
            this.Txb_Observação.Name = "Txb_Observação";
            this.Txb_Observação.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txb_Observação.Size = new System.Drawing.Size(232, 74);
            this.Txb_Observação.TabIndex = 19;
            // 
            // Lbl_Hora
            // 
            this.Lbl_Hora.AutoSize = true;
            this.Lbl_Hora.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Hora.Location = new System.Drawing.Point(21, 115);
            this.Lbl_Hora.Name = "Lbl_Hora";
            this.Lbl_Hora.Size = new System.Drawing.Size(66, 19);
            this.Lbl_Hora.TabIndex = 22;
            this.Lbl_Hora.Text = "Horário";
            // 
            // Msk_Horario
            // 
            this.Msk_Horario.Location = new System.Drawing.Point(93, 114);
            this.Msk_Horario.Mask = "00:00";
            this.Msk_Horario.Name = "Msk_Horario";
            this.Msk_Horario.Size = new System.Drawing.Size(58, 20);
            this.Msk_Horario.TabIndex = 24;
            this.Msk_Horario.ValidatingType = typeof(System.DateTime);
            // 
            // Txt_Modelo
            // 
            this.Txt_Modelo.Location = new System.Drawing.Point(92, 69);
            this.Txt_Modelo.Name = "Txt_Modelo";
            this.Txt_Modelo.Size = new System.Drawing.Size(165, 20);
            this.Txt_Modelo.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "Id ";
            // 
            // Txt_IdCliente
            // 
            this.Txt_IdCliente.Location = new System.Drawing.Point(197, 113);
            this.Txt_IdCliente.Name = "Txt_IdCliente";
            this.Txt_IdCliente.Size = new System.Drawing.Size(79, 20);
            this.Txt_IdCliente.TabIndex = 27;
            // 
            // Frm_Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 293);
            this.Controls.Add(this.Txt_IdCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Modelo);
            this.Controls.Add(this.Msk_Horario);
            this.Controls.Add(this.Lbl_Hora);
            this.Controls.Add(this.Txb_Observação);
            this.Controls.Add(this.Lbl_Observação);
            this.Controls.Add(this.Txt_Placa);
            this.Controls.Add(this.Lbl_Placa);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Ok);
            this.Controls.Add(this.Lbl_Modelo);
            this.Name = "Frm_Entrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Entrada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Placa;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Ok;
        private System.Windows.Forms.Label Lbl_Modelo;
        private System.Windows.Forms.Label Lbl_Observação;
        private System.Windows.Forms.TextBox Txb_Observação;
        private System.Windows.Forms.Label Lbl_Hora;
        private System.Windows.Forms.MaskedTextBox Msk_Horario;
        public System.Windows.Forms.TextBox Txt_Placa;
        public System.Windows.Forms.TextBox Txt_Modelo;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Txt_IdCliente;
    }
}