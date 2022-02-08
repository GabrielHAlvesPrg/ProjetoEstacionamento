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
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
            
            HoraTempoReal();
            

            Grp_TabelaPreços.Text = "Tabela de Preços";
            Lbl_1h.Text = "1 Hora: ";
            Lbl_2h.Text = "2 Horas: ";
            Lbl_3h.Text = "3 Horas: ";
            Lbl_4h.Text = "4 Horas: ";
            Lbl_5h.Text = "5 Horas: ";
            Lbl_6h.Text = "6 Horas: ";
            Lbl_7h.Text = "7 Horas: ";
            Lbl_Diaria.Text = "Diária: ";
            Lbl_Mensal.Text = "Mensal: ";

            Lbl_preco1h.Text = " $10.00 ";
            Lbl_preco2h.Text = " $15.00 ";
            Lbl_preco3h.Text = " $20.00 ";
            Lbl_preco4h.Text = " $25.00 ";
            Lbl_preco5h.Text = " $30.00 ";
            Lbl_preco6h.Text = " $35.00 ";
            Lbl_preco7h.Text = " $40.00 ";
            Lbl_precoDiaria.Text = " $60.00 ";
            Lbl_precoMensal.Text = " $340.00 ";

            Btn_Entrada.Enabled = false;
            Btn_Saida.Enabled = false;
            Btn_Registro.Enabled = false;
            DesconectarToolStripMenuItem.Enabled = false;
            funcionariosToolStripMenuItem.Enabled = false;
            ajudaToolStripMenuItem.Enabled = false;
            relatoriosToolStripMenuItem.Enabled = false;
            Dg_TodosEstacionados.Enabled = false;
     
            

        }

        private void HoraTempoReal()
        {
            var hora = DateTime.Now;
            Lbl_Hora.Text = hora.TimeOfDay.ToString();

            

            //var dataHora = DateTime.Now.ToString();
            //Lbl_Hora.Text = dataHora;
                
            
        }

        private void saidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Saida saida = new Frm_Saida();
            saida.ShowDialog();
        }

        private void entradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Entrada entrada = new Frm_Entrada();
            entrada.Show();
        }

        private void ConectarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Login F = new Frm_Login();
            F.ShowDialog();

            if (F.DialogResult == DialogResult.OK)
            {
                string login = F.login;
                string senha = F.senha;

                if(ProjetoEstacionamentoBliblioteca.Cls_Uteis.validaSenhaLogin(senha) == true) // Senha "projeto".
                {

                    Btn_Entrada.Enabled = true;
                    Btn_Saida.Enabled = true;
                    Btn_Registro.Enabled = true;
                    DesconectarToolStripMenuItem.Enabled = true;
                    ConectarToolStripMenuItem1.Enabled = false;
                    funcionariosToolStripMenuItem.Enabled = false;
                    ajudaToolStripMenuItem.Enabled = false;
                    relatoriosToolStripMenuItem.Enabled = false;
                    Dg_TodosEstacionados.Enabled = true;

                    AtualizaGridFrm_Pincipal();

                    MessageBox.Show("Bem vindo " + login + " !", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Login ou senha invalido!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void Btn_Entrada_Click(object sender, EventArgs e)
        {
            Frm_TipoCliente entrada = new Frm_TipoCliente();
            entrada.ShowDialog();
            

            AtualizaGridFrm_Pincipal();
           

        }

        private void Btn_Saida_Click(object sender, EventArgs e)
        {
            
            Frm_Saida saida = new Frm_Saida();
            saida.Txt_PlacaSaida.Text = Dg_TodosEstacionados.CurrentRow.Cells[1].Value.ToString();
            saida.Msk_HoraDaEntrada.Text = Dg_TodosEstacionados.CurrentRow.Cells[3].Value.ToString();
            saida.ShowDialog();

            AtualizaGridFrm_Pincipal();

        }

        private void Lbl_Consulta_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            Frm_CadastroCliente cadastrarCliente = new Frm_CadastroCliente();
            cadastrarCliente.ShowDialog();
        }

        private void Btn_Registro_Click(object sender, EventArgs e)
        {
            Frm_Registros registro = new Frm_Registros();
            registro.ShowDialog();
            AtualizaGridFrm_Pincipal();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void AtualizaGridFrm_Pincipal()
        {
            try
            {
                Veiculo.Unit C = new Veiculo.Unit();
                var ListaBusca = C.BuscarFicharioTodosVeiculoSQLREL();
                Dg_TodosEstacionados.Rows.Clear();
                for (int i = 0; i <= ListaBusca.Count - 1; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();//crio uma variavel do tipo linha de um datagrid
                    row.CreateCells(Dg_TodosEstacionados);// crio celulas nessa linha, baseada nas colunas desse datagrid view
                    row.Cells[0].Value = ListaBusca[i][4].ToString();
                    row.Cells[1].Value = ListaBusca[i][0].ToString();
                    row.Cells[2].Value = ListaBusca[i][1].ToString();
                    row.Cells[3].Value = ListaBusca[i][2].ToString();
                    row.Cells[4].Value = ListaBusca[i][3].ToString();



                    Dg_TodosEstacionados.Rows.Add(row);
                }

                //Cliente.Unit buscandoIdCliente = new Cliente.Unit();
                //var BuscaId = buscandoIdCliente.BuscarFicharioDBTodosSQLREL();
                //Dg_TodosEstacionados.Rows.Clear();
                //for (int i = 0; i <= ListaBusca.Count - 1; i++)
                //{
                //    DataGridViewRow row = new DataGridViewRow();
                //    row.CreateCells(Dg_TodosEstacionados);
                //    row.Cells[0].Value = ListaBusca[i][0].ToString();


                //    Dg_TodosEstacionados.Rows.Add(row);
                //}



            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
        }

        private void DesconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
