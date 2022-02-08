
namespace ProjetoEstacionamento
{
    partial class Frm_Login
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
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.Txt_Login = new System.Windows.Forms.TextBox();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.Lbl_Login = new System.Windows.Forms.Label();
            this.Pic_Login = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(198, 137);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 13;
            this.Btn_Cancel.Text = "Button2";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_OK
            // 
            this.Btn_OK.Location = new System.Drawing.Point(16, 137);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(75, 23);
            this.Btn_OK.TabIndex = 12;
            this.Btn_OK.Text = "Button1";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.Location = new System.Drawing.Point(126, 86);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.PasswordChar = '*';
            this.Txt_Senha.Size = new System.Drawing.Size(151, 20);
            this.Txt_Senha.TabIndex = 11;
            // 
            // Txt_Login
            // 
            this.Txt_Login.Location = new System.Drawing.Point(126, 38);
            this.Txt_Login.Name = "Txt_Login";
            this.Txt_Login.Size = new System.Drawing.Size(151, 20);
            this.Txt_Login.TabIndex = 10;
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Location = new System.Drawing.Point(123, 70);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(39, 13);
            this.Lbl_Password.TabIndex = 9;
            this.Lbl_Password.Text = "Label2";
            // 
            // Lbl_Login
            // 
            this.Lbl_Login.AutoSize = true;
            this.Lbl_Login.Location = new System.Drawing.Point(123, 22);
            this.Lbl_Login.Name = "Lbl_Login";
            this.Lbl_Login.Size = new System.Drawing.Size(39, 13);
            this.Lbl_Login.TabIndex = 8;
            this.Lbl_Login.Text = "Label1";
            // 
            // Pic_Login
            // 
            this.Pic_Login.Image = global::ProjetoEstacionamento.Properties.Resources.key;
            this.Pic_Login.Location = new System.Drawing.Point(16, 13);
            this.Pic_Login.Name = "Pic_Login";
            this.Pic_Login.Size = new System.Drawing.Size(100, 93);
            this.Pic_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Login.TabIndex = 7;
            this.Pic_Login.TabStop = false;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 173);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.Txt_Senha);
            this.Controls.Add(this.Txt_Login);
            this.Controls.Add(this.Lbl_Password);
            this.Controls.Add(this.Lbl_Login);
            this.Controls.Add(this.Pic_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Login";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.TextBox Txt_Senha;
        private System.Windows.Forms.TextBox Txt_Login;
        private System.Windows.Forms.Label Lbl_Password;
        private System.Windows.Forms.Label Lbl_Login;
        private System.Windows.Forms.PictureBox Pic_Login;
    }
}