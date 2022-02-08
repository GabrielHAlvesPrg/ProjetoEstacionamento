
namespace ProjetoEstacionamento
{
    partial class Frm_Saida
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
            this.Txt_PlacaSaida = new System.Windows.Forms.TextBox();
            this.Lbl_Placa = new System.Windows.Forms.Label();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.LblHoraDaEntrada = new System.Windows.Forms.Label();
            this.Msk_HoraDaEntrada = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Txt_PlacaSaida
            // 
            this.Txt_PlacaSaida.Location = new System.Drawing.Point(92, 25);
            this.Txt_PlacaSaida.Name = "Txt_PlacaSaida";
            this.Txt_PlacaSaida.Size = new System.Drawing.Size(165, 20);
            this.Txt_PlacaSaida.TabIndex = 10;
            // 
            // Lbl_Placa
            // 
            this.Lbl_Placa.AutoSize = true;
            this.Lbl_Placa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Placa.Location = new System.Drawing.Point(21, 25);
            this.Lbl_Placa.Name = "Lbl_Placa";
            this.Lbl_Placa.Size = new System.Drawing.Size(51, 19);
            this.Lbl_Placa.TabIndex = 9;
            this.Lbl_Placa.Text = "Placa";
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(151, 146);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancelar.TabIndex = 8;
            this.Btn_Cancelar.Text = "button2";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.Location = new System.Drawing.Point(40, 146);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ok.TabIndex = 7;
            this.Btn_Ok.Text = "button1";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // LblHoraDaEntrada
            // 
            this.LblHoraDaEntrada.AutoSize = true;
            this.LblHoraDaEntrada.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHoraDaEntrada.Location = new System.Drawing.Point(21, 69);
            this.LblHoraDaEntrada.Name = "LblHoraDaEntrada";
            this.LblHoraDaEntrada.Size = new System.Drawing.Size(133, 19);
            this.LblHoraDaEntrada.TabIndex = 11;
            this.LblHoraDaEntrada.Text = "Hora da Entrada";
            // 
            // Msk_HoraDaEntrada
            // 
            this.Msk_HoraDaEntrada.Location = new System.Drawing.Point(160, 68);
            this.Msk_HoraDaEntrada.Mask = "00:00";
            this.Msk_HoraDaEntrada.Name = "Msk_HoraDaEntrada";
            this.Msk_HoraDaEntrada.Size = new System.Drawing.Size(52, 20);
            this.Msk_HoraDaEntrada.TabIndex = 12;
            this.Msk_HoraDaEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // Frm_Saida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 181);
            this.Controls.Add(this.Msk_HoraDaEntrada);
            this.Controls.Add(this.LblHoraDaEntrada);
            this.Controls.Add(this.Txt_PlacaSaida);
            this.Controls.Add(this.Lbl_Placa);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Ok);
            this.Name = "Frm_Saida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Saida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Placa;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Ok;
        public System.Windows.Forms.TextBox Txt_PlacaSaida;
        private System.Windows.Forms.Label LblHoraDaEntrada;
        public System.Windows.Forms.MaskedTextBox Msk_HoraDaEntrada;
    }
}