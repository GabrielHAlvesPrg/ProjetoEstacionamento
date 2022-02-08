
namespace ProjetoEstacionamento
{
    partial class Frm_TipoCliente
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
            this.Btn_ClienteCadastrado = new System.Windows.Forms.Button();
            this.Btn_ClienteAvulso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_ClienteCadastrado
            // 
            this.Btn_ClienteCadastrado.Location = new System.Drawing.Point(12, 42);
            this.Btn_ClienteCadastrado.Name = "Btn_ClienteCadastrado";
            this.Btn_ClienteCadastrado.Size = new System.Drawing.Size(151, 68);
            this.Btn_ClienteCadastrado.TabIndex = 0;
            this.Btn_ClienteCadastrado.Text = "Cliente Cadastrado";
            this.Btn_ClienteCadastrado.UseVisualStyleBackColor = true;
            this.Btn_ClienteCadastrado.Click += new System.EventHandler(this.Btn_ClienteCadastrado_Click);
            // 
            // Btn_ClienteAvulso
            // 
            this.Btn_ClienteAvulso.Location = new System.Drawing.Point(173, 42);
            this.Btn_ClienteAvulso.Name = "Btn_ClienteAvulso";
            this.Btn_ClienteAvulso.Size = new System.Drawing.Size(151, 68);
            this.Btn_ClienteAvulso.TabIndex = 1;
            this.Btn_ClienteAvulso.Text = "Cliente Avulso";
            this.Btn_ClienteAvulso.UseVisualStyleBackColor = true;
            this.Btn_ClienteAvulso.Click += new System.EventHandler(this.Btn_ClienteAvulso_Click);
            // 
            // Frm_TipoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 138);
            this.Controls.Add(this.Btn_ClienteAvulso);
            this.Controls.Add(this.Btn_ClienteCadastrado);
            this.Name = "Frm_TipoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_TipoCliente";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_ClienteCadastrado;
        private System.Windows.Forms.Button Btn_ClienteAvulso;
    }
}