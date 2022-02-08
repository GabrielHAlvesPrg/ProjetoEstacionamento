using ProjetoEstacionamentoBliblioteca.Classes;
using ProjetoEstacionamentoBliblioteca.DataBases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEstacionamento
{
    public partial class Frm_Registros : Form
    {
        public Frm_Registros()
        {
            InitializeComponent();

            AtualizaGrid();
            Tsl_Principal.Items[0].ToolTipText = "Incluir na base de dados um novo cliente";

        }

        private void novoToolStripButton_Click(object sender, EventArgs e)
        {
            Frm_CadastroCliente c = new Frm_CadastroCliente();
            c.Btn_Excluir.Enabled = false;
            c.Btn_Atualizar.Enabled = false;
            c.ShowDialog();
            AtualizaGrid();
        }

        public void AtualizaGrid()
        {
            try
            {
                Cliente.Unit C = new Cliente.Unit();
                var ListaBusca = C.BuscarFicharioDBTodosSQLREL();
                Dg_Clientes.Rows.Clear();
                for (int i = 0; i <= ListaBusca.Count - 1; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(Dg_Clientes);
                    row.Cells[0].Value = ListaBusca[i][0].ToString();
                    row.Cells[1].Value = ListaBusca[i][16].ToString();
                    row.Cells[2].Value = ListaBusca[i][17].ToString();
                    row.Cells[3].Value = ListaBusca[i][1].ToString();



                    Dg_Clientes.Rows.Add(row);
                }

            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
        }

        public void AtualizaGridFiltroPlaca()
        {
            try
            {
               
                var ListaBusca = FiltrarPorPlaca();
                Dg_Clientes.Rows.Clear();
                for (int i = 0; i <= ListaBusca.Count - 1; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(Dg_Clientes);
                    row.Cells[0].Value = ListaBusca[i][0].ToString();
                    row.Cells[1].Value = ListaBusca[i][1].ToString();
                    row.Cells[2].Value = ListaBusca[i][2].ToString();
                    row.Cells[3].Value = ListaBusca[i][3].ToString();



                    Dg_Clientes.Rows.Add(row);
                }

            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
        }

        private void ApagatoolStripButton_Click(object sender, EventArgs e)
        {
            var selecionado = Dg_Clientes.SelectedRows;
            

            if (selecionado == null)
            {
                MessageBox.Show("Não há cliente selecionado", "ProjetoEstacionamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Cliente.Unit C = new Cliente.Unit();
                    C = C.BuscarFicharioSQLREL(Dg_Clientes.SelectedRows.ToString());
                    if (C == null)
                    {
                        MessageBox.Show("Identificador não encontrado.", "ProjetoEstacionamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //EscreveFormulario(C);
                        //Frm_Questao Db = new Frm_Questao("icons8_question_mark_961", "Você quer excluir o cliente?");
                        //Db.ShowDialog();
                        //if (Db.DialogResult == DialogResult.Yes)
                        //{
                        //    C.ApagarFicharioSQLREL();
                        //    MessageBox.Show("OK: Indentificador apagado com sucesso", "ProjetoEstacionamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //    AtualizaGrid();
                        //    LimparFormulario();
                        //}
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "ProjetoEstacionamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            this.Close();

            Frm_Buscar b = new Frm_Buscar();
            b.ShowDialog();
        }

        private void Dg_Clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Dg_Clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Frm_Entrada darentrada = new Frm_Entrada();
            //darentrada.Txt_IdCliente.Text = Dg_Clientes.CurrentRow.Cells[0].Value.ToString();
            //darentrada.Txt_Placa.Text = Dg_Clientes.CurrentRow.Cells[1].Value.ToString();
            //darentrada.Txt_Modelo.Text = Dg_Clientes.CurrentRow.Cells[2].Value.ToString();
            //darentrada.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Txt_FiltrarPlaca.Text == "")
            {
                AtualizaGrid();
            }else
            {
                AtualizaGridFiltroPlaca();

            }



            
        }

        public List<List<string>> FiltrarPorPlaca()
        {
            List<List<string>> ListaBusca = new List<List<string>>();
            try
            {
                var SQL = "SELECT * FROM TB_Cliente WHERE Placa = '" + Txt_FiltrarPlaca.Text + "' ";
                var db = new SQLServerClass();
                var Dt = db.SQLQuery(SQL);
                for (int i = 0; i <= Dt.Rows.Count - 1; i++)
                {
                    ListaBusca.Add(new List<string> {

                                Dt.Rows[i]["Id"].ToString(),
                                Dt.Rows[i]["Placa"].ToString(),
                                Dt.Rows[i]["Marca"].ToString(),
                                Dt.Rows[i]["Nome"].ToString(),
                              
                    });

                }
                return ListaBusca;

            }
            catch (Exception ex)
            {
                throw new Exception("Conexão com a base ocasionou um erro: " + ex.Message);
            }
        }

        private void Btn_SelecionarCliente_Click(object sender, EventArgs e)
        {
            Frm_Entrada darentrada = new Frm_Entrada();
            darentrada.Txt_IdCliente.Text = Dg_Clientes.CurrentRow.Cells[0].Value.ToString();
            darentrada.Txt_Placa.Text = Dg_Clientes.CurrentRow.Cells[1].Value.ToString();
            darentrada.Txt_Modelo.Text = Dg_Clientes.CurrentRow.Cells[2].Value.ToString();
            darentrada.ShowDialog();
            this.Close();
        }
    }
}
