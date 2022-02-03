using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoEstacionamentoBliblioteca;
using ProjetoEstacionamentoBliblioteca.Classes;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

namespace ProjetoEstacionamento
{
    public partial class Frm_CadastroCliente : Form
    {
        public Frm_CadastroCliente()
        {
            InitializeComponent();

            Grp_DadosPessoais.Text = "Dados Pessoais";
            Grp_Codigo.Text = "Código";
            Grp_Endereco.Text = "Endereço";
            Grp_Outros.Text = "Outros";
            Lbl_Bairro.Text = "Bairro";
            Lbl_CEP.Text = "CEP";
            Lbl_Complemento.Text = "Complemento";
            Lbl_CPF.Text = "CPF";
            Lbl_Estado.Text = "Estado";
            Lbl_Logradouro.Text = "Logradouro";
            Lbl_NomeCliente.Text = "Nome";
            Lbl_NomeMae.Text = "Nome da Mãe";
            Lbl_NomePai.Text = "Nome do Pai";
            Lbl_Profissao.Text = "Profissão";
            Lbl_Numero.Text = "Número";
            Lbl_Telefone.Text = "Telefone";
            Lbl_Cidade.Text = "Cidade";
            Chk_TemPai.Text = "Pai desconhecido";
            Rdb_Masculino.Text = "Masculinio";
            Rdb_Feminino.Text = "Feminino";
            Rdb_Indefinido.Text = "Indefinido";
            Grp_Genero.Text = "Genero";
            Lbl_Placa.Text = "Placa";
            Lbl_Marca.Text = "Marca";
            Lbl_Modelo.Text = "Modelo";
            Lbl_Cor.Text = "Cor";
            Grp_Veiculo.Text = "Veículo";


            //Inicializando os estados; (criando uma colection)
            Cmb_Estados.Items.Clear(); //Este comando garante que o combobox foi limpo;
            Cmb_Estados.Items.Add("Acre (AC)");// adicionando item no combobox;
            Cmb_Estados.Items.Add("Alagoas(AL)");
            Cmb_Estados.Items.Add("Amapá(AP)");
            Cmb_Estados.Items.Add("Amazonas(AM)");
            Cmb_Estados.Items.Add("Bahia(BA)");
            Cmb_Estados.Items.Add("Ceará(CE)");
            Cmb_Estados.Items.Add("Distrito Federal(DF)");
            Cmb_Estados.Items.Add("Espírito Santo(ES)");
            Cmb_Estados.Items.Add("Goiás(GO)");
            Cmb_Estados.Items.Add("Maranhão(MA)");
            Cmb_Estados.Items.Add("Mato Grosso(MT)");
            Cmb_Estados.Items.Add("Mato Grosso do Sul(MS)");
            Cmb_Estados.Items.Add("Minas Gerais(MG)");
            Cmb_Estados.Items.Add("Pará(PA)");
            Cmb_Estados.Items.Add("Paraíba(PB)");
            Cmb_Estados.Items.Add("Paraná(PR)");
            Cmb_Estados.Items.Add("Pernambuco(PE)");
            Cmb_Estados.Items.Add("Piauí(PI)");
            Cmb_Estados.Items.Add("Rio de Janeiro(RJ)");
            Cmb_Estados.Items.Add("Rio Grande do Norte(RN)");
            Cmb_Estados.Items.Add("Rio Grande do Sul(RS)");
            Cmb_Estados.Items.Add("Rondônia(RO)");
            Cmb_Estados.Items.Add("Roraima(RR)");
            Cmb_Estados.Items.Add("Santa Catarina(SC)");
            Cmb_Estados.Items.Add("São Paulo(SP)");
            Cmb_Estados.Items.Add("Sergipe(SE)");
            Cmb_Estados.Items.Add("Tocantins(TO)");


            //Veículos
            Cmb_Marca.Items.Clear();
            Cmb_Marca.Items.Add("Abarth");
            Cmb_Marca.Items.Add("Alfa Romeo");
            Cmb_Marca.Items.Add("Alpine");
            Cmb_Marca.Items.Add("Aston Martin");
            Cmb_Marca.Items.Add("Audi");
            Cmb_Marca.Items.Add("Bentley");
            Cmb_Marca.Items.Add("BMW");
            Cmb_Marca.Items.Add("Citroën");
            Cmb_Marca.Items.Add("Cupra");
            Cmb_Marca.Items.Add("Dacia");
            Cmb_Marca.Items.Add("DS");
            Cmb_Marca.Items.Add("Ferrari");
            Cmb_Marca.Items.Add("Fiat");
            Cmb_Marca.Items.Add("Ford");
            Cmb_Marca.Items.Add("Honda");
            Cmb_Marca.Items.Add("Hyundai");
            Cmb_Marca.Items.Add("Jaguar");
            Cmb_Marca.Items.Add("JEEP");
            Cmb_Marca.Items.Add("KIA");
            Cmb_Marca.Items.Add("Lamborghini");
            Cmb_Marca.Items.Add("Land Rover");
            Cmb_Marca.Items.Add("Lexus");
            Cmb_Marca.Items.Add("Maserati");
            Cmb_Marca.Items.Add("Mazda");
            Cmb_Marca.Items.Add("Mercedes-Benz");
            Cmb_Marca.Items.Add("MG");
            Cmb_Marca.Items.Add("MINI");
            Cmb_Marca.Items.Add("Mitsubishi");
            Cmb_Marca.Items.Add("Nissan");
            Cmb_Marca.Items.Add("Opel");
            Cmb_Marca.Items.Add("Peugeot");
            Cmb_Marca.Items.Add("Porsche");
            Cmb_Marca.Items.Add("Renault");
            Cmb_Marca.Items.Add("SEAT");
            Cmb_Marca.Items.Add("Škoda");
            Cmb_Marca.Items.Add("Smart");
            Cmb_Marca.Items.Add("Suzuki");
            Cmb_Marca.Items.Add("TESLA");
            Cmb_Marca.Items.Add("Toyota");
            Cmb_Marca.Items.Add("Volkswagen");
            Cmb_Marca.Items.Add("Volvo");

            //Cores
            Cmb_Cor.Items.Clear();
            Cmb_Cor.Items.Add("Amarelo");
            Cmb_Cor.Items.Add("Azul");
            Cmb_Cor.Items.Add("Branco");
            Cmb_Cor.Items.Add("Cinza");
            Cmb_Cor.Items.Add("Preto");
            Cmb_Cor.Items.Add("Prata");
            Cmb_Cor.Items.Add("Vermelho");
            Cmb_Cor.Items.Add("Verde");

            //Botões
            Btn_Salvar.Text = "Salvar";
            Btn_Excluir.Text = "Excluir";
            Btn_Atualizar.Text = "Atualizar";

            Grp_Veiculo.Enabled = false;

            
        }

        private void LimparFormulario()
        {
            Txt_Codigo.Text = "";
            Txt_NomeCliente.Text = "";
            Txt_NomePai.Text = "";
            Txt_NomeMae.Text = "";
            Txt_CPF.Text = "";
            Txt_CEP.Text = "";
            Txt_Logradouro.Text = "";
            Txt_Complemento.Text = "";
            Txt_Numero.Text = "";
            Txt_Bairro.Text = "";
            Txt_Cidade.Text = "";
            Cmb_Estados.SelectedIndex = -1;
            Txt_Telefone.Text = "";
            Txt_Profissao.Text = "";
            Txt_Placa.Text = "";
            Cmb_Marca.Text = "";
            Cmb_Modelo.Text = "";
            Cmb_Cor.Text = "";
            Chk_TemPai.Checked = false;
            Rdb_Masculino.Checked = true;

        }

        private void Chk_TemPai_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_TemPai.Checked)
            {
                Txt_NomePai.Enabled = false;
                Txt_NomePai.Text = "";
            }
            else
            {
                Txt_NomePai.Enabled = true;
            }
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente.Unit c = new Cliente.Unit();
                c = LeituraFormulario();
                c.ValidaClasse();
                c.ValidaComplemento();
                c.IncluirFicharioSQLREL();


                MessageBox.Show("Classe foi inicializada com sucesso", "Projeto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
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

        Cliente.Unit LeituraFormulario()
        {
            Cliente.Unit C = new Cliente.Unit();
            C.Id = Txt_Codigo.Text;
            C.Nome = Txt_NomeCliente.Text;
            C.NomeMae = Txt_NomeMae.Text;
            C.NomePai = Txt_NomePai.Text;
            if (Chk_TemPai.Checked)
            {
                C.NaoTemPai = 1;
            }
            else
            {
                C.NaoTemPai = 0;
            }

            if (Rdb_Masculino.Checked)
            {
                C.Genero = 0;
            }
            if (Rdb_Feminino.Checked)
            {
                C.Genero = 1;
            }
            if (Rdb_Indefinido.Checked)
            {
                C.Genero = 2;
            }
            C.Cpf = Txt_CPF.Text;

           
            //Veiculo
            C.Placa = Txt_Placa.Text;
            C.Marca = Cmb_Marca.Text;
            C.Modelo = Cmb_Modelo.Text;
            C.Cor = Cmb_Cor.Text;
         

            //endereço
            C.Cep = Txt_CEP.Text;
            C.Logradouro = Txt_Logradouro.Text;
            C.Complemento = Txt_Complemento.Text;
            C.Cidade = Txt_Cidade.Text;
            C.Bairro = Txt_Bairro.Text;
            C.Numero = Txt_Numero.Text;

            if (Cmb_Estados.SelectedIndex < 0) //SelectedIndex diz a posição que foi selecionada.
            {
                C.Estado = "";
            }
            else
            {
                //capturando alguem que foi selecionado lá no ComboBox;
                C.Estado = Cmb_Estados.Items[Cmb_Estados.SelectedIndex].ToString();
            }

            C.Telefone = Txt_Telefone.Text;
            C.Profissao = Txt_Profissao.Text;
            return C;
        }

        public void EscreveFormulario(Cliente.Unit C)
        {
            Txt_Codigo.Text = C.Id;
            Txt_NomeCliente.Text = C.Nome;
            Txt_NomeMae.Text = C.NomeMae;

            if (C.NaoTemPai == 1)
            {
                Chk_TemPai.Checked = true;
                Txt_NomePai.Text = "";
            }
            else
            {
                Chk_TemPai.Checked = false;
                Txt_NomePai.Text = C.NomePai;
            }

            if (C.Genero == 0)
            {
                Rdb_Masculino.Checked = true;
            }
            if (C.Genero == 1)
            {
                Rdb_Feminino.Checked = true;
            }
            if (C.Genero == 3)
            {
                Rdb_Indefinido.Checked = true;
            }

            Txt_CPF.Text = C.Cpf;
            Txt_CEP.Text = C.Cep;
            Txt_Logradouro.Text = C.Logradouro;
            Txt_Complemento.Text = C.Complemento;
            Txt_Numero.Text = C.Numero;
            Txt_Cidade.Text = C.Cidade;
            Txt_Bairro.Text = C.Bairro;
            Txt_Telefone.Text = C.Telefone;
            Txt_Profissao.Text = C.Profissao;
            //Txt_Placa.Text = C.Placa;
            //Cmb_Marca.Text = C.Marca;
            //Cmb_Modelo.Text = C.Modelo;
            //Cmb_Cor.Text = C.Cor;

            if (C.Estado == "")
            {
                Cmb_Estados.SelectedIndex = -1;
            }
            else
            {
                for (int i = 0; i <= Cmb_Estados.Items.Count - 1; i++)
                {
                    if (C.Estado == Cmb_Estados.Items[i].ToString())
                    {
                        Cmb_Estados.SelectedIndex = i;
                    }
                }
            }


        }

        private void Txt_CEP_Leave(object sender, EventArgs e)
        {
            string vCep = Txt_CEP.Text;
            if (vCep != "")
            {
                if (vCep.Length == 8)
                {
                    if (Information.IsNumeric(vCep)) //Função do VB (VisualBasic)
                    {
                        //capuro o Json (comando abaixo);
                        var vJson = Cls_Uteis.GeraJSONCEP(vCep); //quando rodar essa função, vou navegar na internet e trazer meu json como string para a minha variavel;
                        Cep.Unit CEP = new Cep.Unit(); // estancio uma classe Cep vazia;
                        //tranformo em classe (comando abaixo);
                        CEP = Cep.DesSerializedClassUnit(vJson); // jogo tudo para dentro da classe atraves do "DesSerializedClassUnit";
                        Txt_Logradouro.Text = CEP.logradouro;
                        Txt_Bairro.Text = CEP.bairro;
                        Txt_Cidade.Text = CEP.localidade;


                        Cmb_Estados.SelectedIndex = -1;
                        //              i <= ao tamanho maximo do numero de opçoes do combobox;
                        for (int i = 0; i <= Cmb_Estados.Items.Count - 1; i++)// por que -1? pois a colection começa na posição [0];
                        {

                            // O InStr é uma função que busca um texto dentro de uma string;
                            var vPos = Strings.InStr(Cmb_Estados.Items[i].ToString(), "(" + CEP.uf + ")");

                            if (vPos > 0)
                            {
                                Cmb_Estados.SelectedIndex = i; //aqui o combobox vai exibir o elemento i da lista;
                            }
                        }

                    }
                }

            }
        }

        private void Cmb_Marca_Leave(object sender, EventArgs e)
        {
            if (Cmb_Marca.Text == "Fiat")
            {
                Cmb_Modelo.Items.Clear();
                Cmb_Modelo.Items.Add("Uno");
                Cmb_Modelo.Items.Add("Argos");
                Cmb_Modelo.Items.Add("Cronos");
                Cmb_Modelo.Items.Add("Toro");
            }

            if (Cmb_Marca.Text == "Honda")
            {

            }
        }

        private void Btn_Excluir_Click(object sender, EventArgs e)
        {
            if (Txt_Codigo.Text == "")
            {
                MessageBox.Show("Código do Cliente vazio.", "Projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Cliente.Unit C = new Cliente.Unit();
                    C = C.BuscarFicharioSQLREL(Txt_Codigo.Text);
                    if (C == null)
                    {
                        MessageBox.Show("Identificador não encontrado.", "Projeto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        EscreveFormulario(C);
                        Frm_Questao Db = new Frm_Questao("icons8_question_mark_961", "Você quer excluir o cliente?");
                        Db.ShowDialog();
                        if (Db.DialogResult == DialogResult.Yes)
                        {
                            C.ApagarFicharioSQLREL();
                            MessageBox.Show("OK: Indentificador apagado com sucesso", "Projeto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Frm_Buscar b = new Frm_Buscar();
                            b.AtualizaGrid();
                            b.ShowDialog();
                            LimparFormulario();
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

        private void Btn_Atualizar_Click(object sender, EventArgs e)
        {

            if (Txt_Codigo.Text == "")
            {
                MessageBox.Show("Código do Cliente vazio.", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Cliente.Unit C = new Cliente.Unit();
                    C = LeituraFormulario();
                    C.ValidaClasse();
                    C.ValidaComplemento();
                    C.AlterarFicharioSQLREL();
                    MessageBox.Show("OK: Indentificador alterado com sucesso", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparFormulario();
                    this.Close();



                }
                catch (ValidationException Ex)
                {
                    MessageBox.Show(Ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }

    }
}

