using ProjetoEstacionamentoBliblioteca.Classes;
using ProjetoEstacionamentoBliblioteca.DataBases;
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
    public partial class Frm_Buscar : Form
    {
        public object CellContentClick { get; private set; }

        public Frm_Buscar()
        {
            InitializeComponent();

            Lbl_FiltroNome.Text = "Filtrar por nome";
            Lbl_CadastrarVeiculo.Text = "Cadastrar veículo";
            Lbl_ExluirVeiculo.Text = "Excluir veículo";

           

            AtualizaGrid();

        }

        

        public void AtualizaGrid()
        {
            try
            {
                Cliente.Unit C = new Cliente.Unit();
                var ListaBusca = C.BuscarFicharioDBTodosSQLREL();
                Dg_TodosClientes.Rows.Clear();
                for (int i = 0; i <= ListaBusca.Count - 1; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(Dg_TodosClientes);
                    row.Cells[0].Value = ListaBusca[i][0].ToString();
                    row.Cells[1].Value = ListaBusca[i][1].ToString();
                    row.Cells[2].Value = ListaBusca[i][2].ToString();
                    row.Cells[3].Value = ListaBusca[i][3].ToString();
                    row.Cells[4].Value = ListaBusca[i][4].ToString();
                    row.Cells[5].Value = ListaBusca[i][5].ToString();
                    row.Cells[6].Value = ListaBusca[i][6].ToString();
                    row.Cells[7].Value = ListaBusca[i][7].ToString();
                    row.Cells[8].Value = ListaBusca[i][8].ToString();
                    row.Cells[9].Value = ListaBusca[i][9].ToString();
                    row.Cells[10].Value = ListaBusca[i][10].ToString();
                    row.Cells[11].Value = ListaBusca[i][11].ToString();
                    row.Cells[12].Value = ListaBusca[i][12].ToString();
                    row.Cells[13].Value = ListaBusca[i][13].ToString();
                    row.Cells[14].Value = ListaBusca[i][14].ToString();
                    row.Cells[15].Value = ListaBusca[i][15].ToString();
                    row.Cells[16].Value = ListaBusca[i][16].ToString();
                    row.Cells[17].Value = ListaBusca[i][17].ToString();
                    row.Cells[18].Value = ListaBusca[i][18].ToString();
                    row.Cells[19].Value = ListaBusca[i][19].ToString();

                    Dg_TodosClientes.Rows.Add(row);
                }

            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
        }



        private void Dg_TodosClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
            Frm_CadastroCliente Formulario = new Frm_CadastroCliente();
            Formulario.Btn_Salvar.Enabled = false;
            Formulario.Txt_Codigo.Text = Dg_TodosClientes.CurrentRow.Cells[0].Value.ToString();
            Formulario.Txt_NomeCliente.Text = Dg_TodosClientes.CurrentRow.Cells[1].Value.ToString(); 
            Formulario.Txt_NomePai.Text = Dg_TodosClientes.CurrentRow.Cells[2].Value.ToString(); 
            Formulario.Txt_NomeMae.Text = Dg_TodosClientes.CurrentRow.Cells[3].Value.ToString(); 
            if (Dg_TodosClientes.CurrentRow.Cells[4].Value.ToString() == "1")
            {
                Formulario.Chk_TemPai.Checked = true;
            }
            Formulario.Txt_CPF.Text = Dg_TodosClientes.CurrentRow.Cells[5].Value.ToString();
            if (Dg_TodosClientes.CurrentRow.Cells[6].Value.ToString() == "0")
            {
                Formulario.Rdb_Masculino.Checked = true;
            }
            if (Dg_TodosClientes.CurrentRow.Cells[6].Value.ToString() == "1")
            {
                Formulario.Rdb_Feminino.Checked = true;
            }
            if (Dg_TodosClientes.CurrentRow.Cells[6].Value.ToString() == "2")
            {
                Formulario.Rdb_Indefinido.Checked = true;
            }
            Formulario.Txt_CEP.Text = Dg_TodosClientes.CurrentRow.Cells[7].Value.ToString(); 
            Formulario.Txt_Logradouro.Text = Dg_TodosClientes.CurrentRow.Cells[8].Value.ToString(); 
            Formulario.Txt_Complemento.Text = Dg_TodosClientes.CurrentRow.Cells[9].Value.ToString(); 
            Formulario.Txt_Numero.Text = Dg_TodosClientes.CurrentRow.Cells[10].Value.ToString(); 
            Formulario.Txt_Bairro.Text = Dg_TodosClientes.CurrentRow.Cells[11].Value.ToString(); 
            Formulario.Txt_Cidade.Text = Dg_TodosClientes.CurrentRow.Cells[12].Value.ToString(); 
            Formulario.Cmb_Estados.Text = Dg_TodosClientes.CurrentRow.Cells[13].Value.ToString();
            Formulario.Txt_Telefone.Text = Dg_TodosClientes.CurrentRow.Cells[14].Value.ToString();
            Formulario.Txt_Profissao.Text = Dg_TodosClientes.CurrentRow.Cells[15].Value.ToString();
            Formulario.Txt_Placa.Text = Dg_TodosClientes.CurrentRow.Cells[16].Value.ToString();
            Formulario.Cmb_Marca.Text = Dg_TodosClientes.CurrentRow.Cells[17].Value.ToString();
            Formulario.Cmb_Modelo.Text = Dg_TodosClientes.CurrentRow.Cells[18].Value.ToString();
            Formulario.Cmb_Cor.Text = Dg_TodosClientes.CurrentRow.Cells[19].Value.ToString();

           
            Formulario.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Txt_FiltroNome.Text == "")
            {
                AtualizaGrid();
            }
            else
            {
                AtualizaGridFiltroNome();

            }
        }

        public void AtualizaGridFiltroNome()
        {
            try
            {

                var ListaBusca = BuscarFicharioFiltradoPorNome();
                Dg_TodosClientes.Rows.Clear();
                for (int i = 0; i <= ListaBusca.Count - 1; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();//crio uma variavel do tipo linha de um datagrid
                    row.CreateCells(Dg_TodosClientes);// crio celulas nessa linha, baseada nas colunas desse datagrid view
                    row.Cells[0].Value = ListaBusca[i][0].ToString();
                    row.Cells[1].Value = ListaBusca[i][1].ToString();
                    row.Cells[2].Value = ListaBusca[i][2].ToString();
                    row.Cells[3].Value = ListaBusca[i][3].ToString();
                    row.Cells[4].Value = ListaBusca[i][4].ToString();
                    row.Cells[5].Value = ListaBusca[i][5].ToString();
                    row.Cells[6].Value = ListaBusca[i][6].ToString();
                    row.Cells[7].Value = ListaBusca[i][7].ToString();
                    row.Cells[8].Value = ListaBusca[i][8].ToString();
                    row.Cells[9].Value = ListaBusca[i][9].ToString();
                    row.Cells[10].Value = ListaBusca[i][10].ToString();
                    row.Cells[11].Value = ListaBusca[i][11].ToString();
                    row.Cells[12].Value = ListaBusca[i][12].ToString();
                    row.Cells[13].Value = ListaBusca[i][13].ToString();
                    row.Cells[14].Value = ListaBusca[i][14].ToString();
                    row.Cells[15].Value = ListaBusca[i][15].ToString();
                    row.Cells[16].Value = ListaBusca[i][16].ToString();
                    row.Cells[17].Value = ListaBusca[i][17].ToString();
                    row.Cells[18].Value = ListaBusca[i][18].ToString();
                    row.Cells[19].Value = ListaBusca[i][19].ToString();

                    Dg_TodosClientes.Rows.Add(row);// adiciono a linha no meu datagrid;
                }

            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
        }

        public List<List<string>> BuscarFicharioFiltradoPorNome()
        {
            List<List<string>> ListaBusca = new List<List<string>>();
            try
            {
                var SQL = "SELECT * FROM TB_Cliente WHERE Nome = '" + Txt_FiltroNome.Text + "' ";
                var db = new SQLServerClass();
                var Dt = db.SQLQuery(SQL);
                for (int i = 0; i <= Dt.Rows.Count - 1; i++)
                {
                    ListaBusca.Add(new List<string> {
                            Dt.Rows[i]["Id"].ToString(),
                            Dt.Rows[i]["Nome"].ToString(),
                            Dt.Rows[i]["NomePai"].ToString(),
                            Dt.Rows[i]["NomeMae"].ToString(),
                            Dt.Rows[i]["NaoTemPai"].ToString(),
                            Dt.Rows[i]["Cpf"].ToString(),
                            Dt.Rows[i]["Genero"].ToString(),
                            Dt.Rows[i]["Cep"].ToString(),
                            Dt.Rows[i]["Logradouro"].ToString(),
                            Dt.Rows[i]["Complemento"].ToString(),
                            Dt.Rows[i]["Numero"].ToString(),
                            Dt.Rows[i]["Bairro"].ToString(),
                            Dt.Rows[i]["Cidade"].ToString(),
                            Dt.Rows[i]["Estado"].ToString(),
                            Dt.Rows[i]["Telefone"].ToString(),
                            Dt.Rows[i]["Profissao"].ToString(),
                            Dt.Rows[i]["Placa"].ToString(),
                            Dt.Rows[i]["Marca"].ToString(),
                            Dt.Rows[i]["Modelo"].ToString(),
                            Dt.Rows[i]["Cor"].ToString()
                        });

                }
                return ListaBusca;

            }
            catch (Exception ex)
            {
                throw new Exception("Conexão com a base ocasionou um erro: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_CadastroCliente Formulario = new Frm_CadastroCliente();
            Formulario.Grp_Codigo.Enabled = false;
            Formulario.Grp_DadosPessoais.Enabled = false;
            Formulario.Grp_Endereco.Enabled = false;
            Formulario.Grp_Outros.Enabled = false;
            Formulario.Grp_Veiculo.Enabled = true;
            Formulario.Btn_Atualizar.Enabled = true;
            Formulario.Btn_Atualizar.Text = "Adicionar";
            Formulario.Btn_Salvar.Enabled = false;
            Formulario.Btn_Excluir.Enabled = false;


           
            Formulario.Txt_Codigo.Text = Dg_TodosClientes.CurrentRow.Cells[0].Value.ToString();
            Formulario.Txt_NomeCliente.Text = Dg_TodosClientes.CurrentRow.Cells[1].Value.ToString();
            Formulario.Txt_NomePai.Text = Dg_TodosClientes.CurrentRow.Cells[2].Value.ToString();
            Formulario.Txt_NomeMae.Text = Dg_TodosClientes.CurrentRow.Cells[3].Value.ToString();
            if (Dg_TodosClientes.CurrentRow.Cells[4].Value.ToString() == "1")
            {
                Formulario.Chk_TemPai.Checked = true;
            }
            Formulario.Txt_CPF.Text = Dg_TodosClientes.CurrentRow.Cells[5].Value.ToString();
            if (Dg_TodosClientes.CurrentRow.Cells[6].Value.ToString() == "0")
            {
                Formulario.Rdb_Masculino.Checked = true;
            }
            if (Dg_TodosClientes.CurrentRow.Cells[6].Value.ToString() == "1")
            {
                Formulario.Rdb_Feminino.Checked = true;
            }
            if (Dg_TodosClientes.CurrentRow.Cells[6].Value.ToString() == "2")
            {
                Formulario.Rdb_Indefinido.Checked = true;
            }
            Formulario.Txt_CEP.Text = Dg_TodosClientes.CurrentRow.Cells[7].Value.ToString();
            Formulario.Txt_Logradouro.Text = Dg_TodosClientes.CurrentRow.Cells[8].Value.ToString();
            Formulario.Txt_Complemento.Text = Dg_TodosClientes.CurrentRow.Cells[9].Value.ToString();
            Formulario.Txt_Numero.Text = Dg_TodosClientes.CurrentRow.Cells[10].Value.ToString();
            Formulario.Txt_Bairro.Text = Dg_TodosClientes.CurrentRow.Cells[11].Value.ToString();
            Formulario.Txt_Cidade.Text = Dg_TodosClientes.CurrentRow.Cells[12].Value.ToString();
            Formulario.Cmb_Estados.Text = Dg_TodosClientes.CurrentRow.Cells[13].Value.ToString();
            Formulario.Txt_Telefone.Text = Dg_TodosClientes.CurrentRow.Cells[14].Value.ToString();
            Formulario.Txt_Profissao.Text = Dg_TodosClientes.CurrentRow.Cells[15].Value.ToString();
            Formulario.Txt_Placa.Text = Dg_TodosClientes.CurrentRow.Cells[16].Value.ToString();
            Formulario.Cmb_Marca.Text = Dg_TodosClientes.CurrentRow.Cells[17].Value.ToString();
            Formulario.Cmb_Modelo.Text = Dg_TodosClientes.CurrentRow.Cells[18].Value.ToString();
            Formulario.Cmb_Cor.Text = Dg_TodosClientes.CurrentRow.Cells[19].Value.ToString();


            Formulario.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_ApagarVeiculoDeCliente apagarVeiculo = new Frm_ApagarVeiculoDeCliente();
            apagarVeiculo.Lbl_IdApagarVeiculo.Text = Dg_TodosClientes.CurrentRow.Cells[0].Value.ToString();
            apagarVeiculo.Lbl_ClienteSelecionado.Text = Dg_TodosClientes.CurrentRow.Cells[1].Value.ToString();

            //---------------------------------------------------------------------------------------------------------
            apagarVeiculo.Lbl_assNomePai.Text = Dg_TodosClientes.CurrentRow.Cells[2].Value.ToString();
            apagarVeiculo.Lbl_assNomeMae.Text = Dg_TodosClientes.CurrentRow.Cells[3].Value.ToString();
            apagarVeiculo.Lbl_assNaoTempai.Text = Dg_TodosClientes.CurrentRow.Cells[4].Value.ToString();
            apagarVeiculo.Lbl_assCpf.Text = Dg_TodosClientes.CurrentRow.Cells[5].Value.ToString();
            apagarVeiculo.Lbl_assGenero.Text = Dg_TodosClientes.CurrentRow.Cells[6].Value.ToString();
            apagarVeiculo.Lbl_assCep.Text = Dg_TodosClientes.CurrentRow.Cells[7].Value.ToString();
            apagarVeiculo.Lbl_assLogradouro.Text = Dg_TodosClientes.CurrentRow.Cells[8].Value.ToString();
            apagarVeiculo.Lbl_assComplemento.Text = Dg_TodosClientes.CurrentRow.Cells[9].Value.ToString();
            apagarVeiculo.Lbl_AssNumero.Text = Dg_TodosClientes.CurrentRow.Cells[10].Value.ToString();
            apagarVeiculo.Lbl_assBairro.Text = Dg_TodosClientes.CurrentRow.Cells[11].Value.ToString();
            apagarVeiculo.Lbl_assCidade.Text = Dg_TodosClientes.CurrentRow.Cells[12].Value.ToString();
            apagarVeiculo.Lbl_assEstado.Text = Dg_TodosClientes.CurrentRow.Cells[13].Value.ToString();
            apagarVeiculo.Lbl_assTelefone.Text = Dg_TodosClientes.CurrentRow.Cells[14].Value.ToString();
            apagarVeiculo.Lbl_assProfissao.Text = Dg_TodosClientes.CurrentRow.Cells[15].Value.ToString();
            //---------------------------------------------------------------------------------------------------------

            apagarVeiculo.Txt_ApagarPlaca.Text = Dg_TodosClientes.CurrentRow.Cells[16].Value.ToString();
            apagarVeiculo.Txt_ApagarMarca.Text = Dg_TodosClientes.CurrentRow.Cells[17].Value.ToString();
            apagarVeiculo.Txt_ApagarModelo.Text = Dg_TodosClientes.CurrentRow.Cells[18].Value.ToString();
            apagarVeiculo.Txt_ApagarCor.Text = Dg_TodosClientes.CurrentRow.Cells[19].Value.ToString();
            apagarVeiculo.ShowDialog();
          
        }
    }
}
