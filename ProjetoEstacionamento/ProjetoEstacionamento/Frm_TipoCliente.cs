using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEstacionamento
{
    public partial class Frm_TipoCliente : Form
    {
        public Frm_TipoCliente()
        {
            InitializeComponent();
        }

        private void Btn_ClienteAvulso_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Entrada clienteAvulso = new Frm_Entrada();
            clienteAvulso.FormClosed += (s, args) => this.Close(); //NÃO SEI O QUE ESSE COMANDO FAZ EXATAMENTE, PODE ACARRETAR EM ERRO!!!
            clienteAvulso.ShowDialog();
            clienteAvulso.Close();
        }

        private void Btn_ClienteCadastrado_Click(object sender, EventArgs e)
        {
            Frm_Registros r = new Frm_Registros();
            r.ShowDialog();
        }
    }
}
