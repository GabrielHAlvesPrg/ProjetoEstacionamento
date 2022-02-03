using ProjetoEstacionamentoBliblioteca.Classes;
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
    public partial class Frm_Saida : Form
    {
        public Frm_Saida()
        {
            InitializeComponent();
            
            Btn_Cancelar.Text = "Cancelar";
            Btn_Ok.Text = "Ok";
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
           
             if (Txt_PlacaSaida.Text == "")
             {
                 MessageBox.Show("Código da placa vazio.", "Projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             else
             {
                 try
                 {
                    
                     Veiculo.Unit C = new Veiculo.Unit();
                     C = C.BuscarFicharioVeiculoEstacionadoSQLREL(Txt_PlacaSaida.Text);
                    if (C == null)
                    {
                        MessageBox.Show("Identificador não encontrado.", "Projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        
                        Frm_Questao Db = new Frm_Questao("icons8_question_mark_961", "Você quer Efetivar a saida do veiculo de placa: " + Txt_PlacaSaida.Text);
                         Db.ShowDialog();
                         if (Db.DialogResult == DialogResult.Yes)
                         {
                             C.SaidaEstacionado();
                             MessageBox.Show("OK: Saida efetuada com sucesso.", "Projeto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                         }
                    }
                 }
                 catch (Exception Ex)
                 {
                     MessageBox.Show(Ex.Message, "Projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }

               
             }
            
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
