using ProjetoEstacionamentoBliblioteca.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEstacionamento
{
    public partial class Frm_Entrada : Form
    {
        public Frm_Entrada()
        {
            InitializeComponent();

            Btn_Ok.Text = "Dar Entrada";
            Btn_Cancelar.Text = "Cancelar";

            //Pega a hora do sistema----------------
            var hora = DateTime.Now;
            Msk_Horario.Text = hora.TimeOfDay.ToString();


        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            try
            {
                Veiculo.Unit c = new Veiculo.Unit();
                c = LeituraFormulario();
                c.IncluirFicharioSQLRELEntrada();
                MessageBox.Show("Entrada realizada com sucesso!", "Projeto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (ValidationException Ex)
            {
                MessageBox.Show(Ex.Message, "Projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
            

        }

        Veiculo.Unit LeituraFormulario()
        {
            var hora = DateTime.Now;

            Veiculo.Unit v = new Veiculo.Unit();
            v.Placa = Txt_Placa.Text;
            v.Modelo = Txt_Modelo.Text;
            v.Horario = hora.TimeOfDay.ToString();
            v.Observacao = Txb_Observação.Text;
            v.IdCliente = Txt_IdCliente.Text.ToString();

            return v;
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
