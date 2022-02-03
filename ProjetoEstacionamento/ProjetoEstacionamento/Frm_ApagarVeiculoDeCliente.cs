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
    public partial class Frm_ApagarVeiculoDeCliente : Form
    {
        public Frm_ApagarVeiculoDeCliente()
        {
            InitializeComponent();

            Lbl_ApagarPlaca.Text = "Placa";
            Lbl_ApagarMarca.Text = "Marca";
            Lbl_ApagarModelo.Text = "Modelo";
            Lbl_ApagarCor.Text = "Cor";
            Lbl_ApagarVeiculoCliente.Text = "Apagar veículo do cliente: ";
            Lbl_IdReferencial.Text = "Id do Cliente: ";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var status = true;

            if (status == true)
            {
                Cliente.Unit VeiculoApagar = new Cliente.Unit();
                VeiculoApagar.Id = Lbl_IdApagarVeiculo.Text;
                VeiculoApagar.Nome = Lbl_ClienteSelecionado.Text;

                //ABAIXO, ESTAO APENAS PARA PEGAR SEUS VALORES------------
                VeiculoApagar.NomePai = Lbl_assNomePai.Text;
                VeiculoApagar.NomeMae = Lbl_assNomeMae.Text;
                if (Lbl_assNaoTempai.Text == "1")
                {
                    VeiculoApagar.NaoTemPai = 1;
                }
                else
                {
                    VeiculoApagar.NaoTemPai = 0;
                }
            ;
                if (Lbl_assGenero.Text == "0")
                {
                    VeiculoApagar.Genero = 0;
                }
                if (Lbl_assGenero.Text == "1")
                {
                    VeiculoApagar.Genero = 1;
                }
                if (Lbl_assGenero.Text == "2")
                {
                    VeiculoApagar.Genero = 2;
                }
                VeiculoApagar.Cpf = Lbl_assCpf.Text;
                VeiculoApagar.Cep = Lbl_assCep.Text;
                VeiculoApagar.Logradouro = Lbl_assLogradouro.Text;
                VeiculoApagar.Complemento = Lbl_assComplemento.Text;
                VeiculoApagar.Numero = Lbl_AssNumero.Text;
                VeiculoApagar.Bairro = Lbl_assBairro.Text;
                VeiculoApagar.Cidade = Lbl_assCidade.Text;
                VeiculoApagar.Estado = Lbl_assEstado.Text;
                VeiculoApagar.Telefone = Lbl_assTelefone.Text;
                VeiculoApagar.Profissao = Lbl_assProfissao.Text;

                //----------------------------------------------------------
                VeiculoApagar.Placa = null;
                VeiculoApagar.Marca = null;
                VeiculoApagar.Modelo = null;
                VeiculoApagar.Cor = null;
                VeiculoApagar.AlterarFicharioSQLREL();
                

            }
            else
            {
                status = false;
                MessageBox.Show("Erro ao Excluir veículo");
                this.Close();
            }

            MessageBox.Show("Veículo Excluido com sucesso");
            this.Close();
        }

       
    }
}
