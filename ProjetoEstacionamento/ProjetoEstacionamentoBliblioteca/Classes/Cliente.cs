using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using ProjetoEstacionamentoBliblioteca.DataBases;
using System.Data;

namespace ProjetoEstacionamentoBliblioteca.Classes
{
    public class Cliente
    {
        public class Unit
        {
            //Dados Pessoais

            [Required(ErrorMessage = "Codigo do cliente é obrigatorio.")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Código do Cliente somente aceita valores numéricos.")] 
            [StringLength(6, MinimumLength = 6, ErrorMessage = "Código do Cliente deve ter 6 dígitos.")]
            public string Id { get; set; }

            [Required(ErrorMessage = "Nome do cliente é obrigatorio.")]
            [StringLength(50, ErrorMessage = "Nome do Cliente deve ter até 50 caracteres.")]
            public string Nome { get; set; }

            [StringLength(50, ErrorMessage = "Nome do pai do Cliente deve ter até 50 caracteres.")]
            public string NomePai { get; set; }

           
            [StringLength(50, ErrorMessage = "Nome da mae do Cliente deve ter até 50 caracteres.")]
            public string NomeMae { get; set; }


            public int NaoTemPai { get; set; }


            [Required(ErrorMessage = "CPF do cliente é obrigatorio.")]
            [RegularExpression("([0-9]+)", ErrorMessage = "CPF do Cliente somente aceita valores numéricos.")]
            [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF do Cliente deve ter 11 dígitos.")]
            public string Cpf { get; set; }

            [Required(ErrorMessage = "Genero é obrigatorio.")]
            public int Genero { get; set; }

            //Endereço

            [Required(ErrorMessage = "CEP do cliente é obrigatorio.")]
            [RegularExpression("([0-9]+)", ErrorMessage = "CEP do Cliente somente aceita valores numéricos.")] 
            [StringLength(8, MinimumLength = 8, ErrorMessage = "CEP do Cliente deve ter 8 dígitos.")]
            public string Cep { get; set; }

            [Required(ErrorMessage = "Logradouro é obrigatorio.")]
            [StringLength(100, ErrorMessage = "Logradouro deve ter até 100 caracteres.")]
            public string Logradouro { get; set; }

            [Required(ErrorMessage = "Complemento é obrigatorio.")]
            [StringLength(100, ErrorMessage = "Complemento deve ter até 100 caracteres.")]
            public string Complemento { get; set; }

            [Required(ErrorMessage = "Número é Obrigatorio")]
            [StringLength(10,ErrorMessage = "Número deve ter no máximo 10 digitos")]
            public string Numero { get; set; }

            [Required(ErrorMessage = "Bairro é obrigatorio.")]
            [StringLength(50, ErrorMessage = "Bairro deve ter até 50 caracteres.")]
            public string Bairro { get; set; }


            [Required(ErrorMessage = "Cidade é obrigatorio.")]
            [StringLength(50, ErrorMessage = "Cidade deve ter até 50 caracteres.")]
            public string Cidade { get; set; }

            [Required(ErrorMessage = "Estado é obrigatorio.")]
            [StringLength(50, ErrorMessage = "Estado deve ter até 50 caracteres.")]
            public string Estado { get; set; }


            //Outros

            [Required(ErrorMessage = "Número do telefone é obrigatorio.")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Número do telefone somente aceita valores numéricos.")]
            public string Telefone { get; set; }


            public string Profissao { get; set; }

            public Veiculo Veiculo { get; set; }


            //Veículo

            //[Required(ErrorMessage = "Placa é Obrigatorio.")]
            //[StringLength(7, MinimumLength = 7, ErrorMessage = "A placa deve ter 7 dígitos.")]
            public string Placa { get; set; }

            //[Required(ErrorMessage = "Marca é obrigatorio.")]
            public string Marca { get; set; }

            public string Modelo { get; set; }

            public string Cor { get; set; }

            ////Entrada
            //[Required(ErrorMessage = "Horário é Obrigatorio.")]
            //public int Horario { get; set; }

            //public string Observacao { get; set; }



            public void ValidaClasse()
            {

                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null); // capturando das diretivas os resultados dos testes;
                List<ValidationResult> results = new List<ValidationResult>(); // capturando das diretivas os resultados dos testes;
                bool isValid = Validator.TryValidateObject(this, context, results, true); // faço os testes usando o metodo "TryValidateObject", que vai me retornar um verdadeiro ou falso, caso algum teste de problema;


                //Se retornar falso, ele vai entrar aqui dentro, vai fazer um Loop onde ele vai jogar para uma variável chamada "sbrErros" que é do tipo "StringBuilder". O "StringBuilder" e o "String" são muito parecidos.
                // Porém, o "StringBuilder" eu consigo inserir coisas nele através do método "Append" ou "Append Line". No caso, quando eu faço o "Append Line" eu estou criando linha a linha. Então estou fazendo o Loop para capturar todos os erros.
                // Se eu tiver mais de um erro, eu vou ter nesse "String", cuja "sbrErrors", eu vou ter nesse “String” todos os erros. "O "Id" está em branco, o CEP não é número, o CPF é inválido". Ou seja, todos os erros.
                if (isValid == false)
                {
                    StringBuilder sbrErrors = new StringBuilder();
                    foreach (var validationResult in results)
                    {
                        sbrErrors.AppendLine(validationResult.ErrorMessage);
                    }
                    // E aí eu vou pegar o conteúdo dessa variável que tem todos os erros, que está aqui e vou transformar ele para “String” porque eu preciso transformar o "StringBuilder" em “String” e vou jogar nessa exceção. Para quem não está familiarizado,
                    // exceção seria como se fosse um erro que acontece no ".net Framework". Quando tem uma exceção dentro do seu programa, se você não tratar ela, seu programa abenda.
                    // eu estou forçando um erro do tipo "ValidationException". Esse tipo de erro, é um tipo que já está contido dentro da biblioteca "DataAnnotations" que nós incluímos no projeto, na classe.
                    //Então ele vai jogar para o conteúdo de uma variável do tipo "ValidationException", digamos assim, essa mensagem de erro e vai forçar uma exceção desse tipo. É o que vai acontecer. Pronto.
                    //Só que agora eu preciso fazer o teste aonde? Eu preciso fazer o teste lá no formulário, instanciar classe, colocar um valor e ver o que vai acontecer.
                    throw new ValidationException(sbrErrors.ToString());
                }
            }

            public void ValidaComplemento()
            {
                if (this.NomePai == this.NomeMae)
                {
                    throw new Exception("Nome do PAI e da MÃE, não podem ser iguais!");
                }
                if (NaoTemPai == 0)
                {
                    if (this.NomePai == "")
                    {
                        throw new Exception("Nome do PAI nao pode estar vazio quando a propriedade PAI DESCONHECIDO não estiver marcada");
                    }
                }

                bool validaCPF = Cls_Uteis.Valida(this.Cpf);
                if (validaCPF == false)
                {
                    throw new Exception("CPF inválido!");
                }
            }


            #region "CRUD do Fichario DB SQL SERVER Relacional"

            #region "Funções auxiliares"

            public string ToInsert()
            {
                string SQL;
                SQL = @"INSERT INTO TB_Cliente
                        (Id
                        ,Nome
                        ,NomePai
                        ,NomeMae
                        ,NaoTemPai
                        ,Cpf
                        ,Genero
                        ,Cep
                        ,Logradouro
                        ,Complemento
                        ,Numero
                        ,Bairro
                        ,Cidade
                        ,Estado
                        ,Telefone
                        ,Profissao) 
                        VALUES ";
                SQL += "('" + this.Id + "'";
                SQL += ",'" + this.Nome + "'";
                SQL += ",'" + this.NomePai + "'";
                SQL += ",'" + this.NomeMae + "'";
                SQL += "," + Convert.ToString(this.NaoTemPai) + ",";
                SQL += "'" + this.Cpf + "'";
                SQL += "," + Convert.ToString(this.Genero) + ",";
                SQL += "'" + this.Cep + "'";
                SQL += ",'" + this.Logradouro + "'";
                SQL += ",'" + this.Complemento + "'";
                SQL += ",'" + this.Numero + "'";
                SQL += " ,'" + this.Bairro + "'";
                SQL += ",'" + this.Cidade + "'";
                SQL += ",'" + this.Estado + "'";
                SQL += ",'" + this.Telefone + "'";
                SQL += ",'" + this.Profissao + "');";
                //SQL += ",'" + this.Placa + "'";
                //SQL += ",'" + this.Marca + "'";
                //SQL += ",'" + this.Modelo + "'";
                //SQL += ",'" + this.Cor + "');";
                return SQL;


                //@"INSERT INTO TB_Cliente
                //        (Id
                //        ,Nome
                //        ,NomePai
                //        ,NomeMae
                //        ,NaoTemPai
                //        ,Cpf
                //        ,Genero
                //        ,Cep
                //        ,Logradouro
                //        ,Complemento
                //        ,Numero
                //        ,Bairro
                //        ,Cidade
                //        ,Estado
                //        ,Telefone
                //        ,Profissao
                //        ,Placa
                //        ,Marca
                //        ,Modelo
                //        ,Cor) 
                //        VALUES ";
            }

            //public string ToInsertEntrada()
            //{
            //    string SQL;
            //    SQL = @"INSERT INTO Tb_Estacionado
            //            (Placa    
            //            ,Modelo
            //            ,Horário
            //            ,Observação) 
            //            VALUES ";
            //    SQL += ",'" + this.Placa + "'";
            //    SQL += ",'" + this.Modelo + "'";
            //    //  SQL += ",'" + this.Horario + "'";
            //    SQL += "," + Convert.ToString(this.Horario) + ",";
            //    SQL += ",'" + this.Observacao + "');";
            //    return SQL;

            //}

            public string ToUpdate(string Id)
            {
                string SQL;
                SQL = @"UPDATE TB_Cliente
                        SET ";
                SQL += "Id = '" + this.Id + "'";
                SQL += " , Nome = '" + this.Nome + "'";
                SQL += " , NomePai = '" + this.NomePai + "'";
                SQL += " , NomeMae = '" + this.NomeMae + "'";
                SQL += " , NaoTemPai = " + Convert.ToString(this.NaoTemPai) + "";
                SQL += " , Cpf = '" + this.Cpf + "'";
                SQL += " , Genero = " + Convert.ToString(this.Genero) + "";
                SQL += " , Cep = '" + this.Cep + "'";
                SQL += " , Logradouro = '" + this.Logradouro + "'";
                SQL += " , Complemento = '" + this.Complemento + "'";
                SQL += " , Numero = '" + this.Complemento + "'";
                SQL += " , Bairro = '" + this.Bairro + "'";
                SQL += " , Cidade = '" + this.Cidade + "'";
                SQL += " , Estado = '" + this.Estado + "'";
                SQL += " , Telefone = '" + this.Telefone + "'";
                SQL += " , Profissao = '" + this.Profissao + "'";
                SQL += " , Placa = '" + this.Placa + "'";
                SQL += " , Marca = '" + this.Marca + "'";
                SQL += " , Modelo = '" + this.Modelo + "'";
                SQL += " , Cor = '" + this.Cor + "'";
                SQL += " WHERE Id = '" + Id + "';";
                return SQL;

            }

            public Unit DataRowToUnit(DataRow dr)//essa função, entra um datarow e sai uma classe;
            {
                Unit u = new Unit(); // a unit é uma subclasse que tem as caracteristicas da classe;
                u.Id = dr["Id"].ToString();
                u.Nome = dr["Nome"].ToString();
                u.NomePai = dr["NomePai"].ToString();
                u.NomeMae = dr["NomeMae"].ToString();
                u.NaoTemPai = Convert.ToInt32(dr["NaoTemPai"]);
                u.Cpf = dr["Cpf"].ToString();
                u.Cep = dr["Cep"].ToString();
                u.Logradouro = dr["Logradouro"].ToString();
                u.Complemento = dr["Complemento"].ToString();
                u.Numero = dr["Numero"].ToString();
                u.Bairro = dr["Bairro"].ToString();
                u.Cidade = dr["Cidade"].ToString();
                u.Estado = dr["Estado"].ToString();
                u.Telefone = dr["Telefone"].ToString();
                u.Profissao = dr["Profissao"].ToString();
                //u.Placa = dr["Placa"].ToString();
                //u.Marca = dr["Marca"].ToString();
                //u.Modelo = dr["Modelo"].ToString();
                //u.Cor = dr["Cor"].ToString();
                // u.RendaFamiliar = Convert.ToDouble(dr["RendaFamiliar"]);
                return u;

            }

            #endregion

            public void IncluirFicharioSQLREL()
            {
                try
                {
                    string SQL;
                    SQL = this.ToInsert();
                    var db = new SQLServerClass();
                    db.SQLCommand(SQL);
                    db.Close();

                }
                catch (Exception ex)
                {
                    throw new Exception("Inclusão não permitida. Identificador: " + this.Id + ", erro: " + ex.Message);
                }

            }

            //public void IncluirFicharioSQLRELEntrada()
            //{
            //    try
            //    {
            //        string SQL;
            //        SQL = this.ToInsertEntrada();
            //        var db = new SQLServerClass();
            //        db.SQLCommand(SQL);
            //        db.Close();

            //    }
            //    catch (Exception ex)
            //    {
            //        throw new Exception("Inclusão não permitida. Identificador: " + this.Id + ", erro: " + ex.Message);
            //    }

            //}

            public Unit BuscarFicharioSQLREL(string Id)
            {
                try
                {
                    string SQL = "SELECT * FROM [TB_Cliente] WHERE Id = '" + Id + "'";
                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);
                    if (Dt.Rows.Count == 0)
                    {
                        db.Close();
                        throw new Exception("Indentificador não existente: " + Id);
                    }
                    else
                    {
                        Unit u = this.DataRowToUnit(Dt.Rows[0]);
                        return u;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao buscar o conteúdo do identificador: " + ex.Message);
                }
            }

            public void AlterarFicharioSQLREL()
            {
                try
                {
                    string SQL = "SELECT * FROM [TB_Cliente] WHERE Id = '" + Id + "'";
                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);
                    if (Dt.Rows.Count == 0)
                    {
                        db.Close();
                        throw new Exception("Indentificador não existente: " + Id);
                    }
                    else
                    {
                        SQL = this.ToUpdate(this.Id);
                        db.SQLCommand(SQL);
                        db.Close();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao alterar o conteúdo do identificador: " + ex.Message);
                }
            }

            public void ApagarFicharioSQLREL()
            {
                try
                {
                    string SQL = "SELECT * FROM [TB_Cliente] WHERE Id = '" + this.Id + "'";
                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);
                    if (Dt.Rows.Count == 0)
                    {
                        db.Close();
                        throw new Exception("Indentificador não existente: " + this.Id);
                    }
                    else
                    {
                        SQL = "DELETE FROM TB_cliente WHERE Id = '" + this.Id + "'";
                        db.SQLCommand(SQL);
                        db.Close();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao excluir o conteúdo do identificador: " + ex.Message);
                }
            }


            //public void ApagarFicharioVeiculoCliente()//--------------------------------------------------------------------------
            //{
            //    try
            //    {
            //        string SQL = "SELECT * FROM [TB_Cliente] WHERE Placa = '" + this.Placa + "'";
            //        var db = new SQLServerClass();
            //        var Dt = db.SQLQuery(SQL);
            //        if (Dt.Rows.Count == 0)
            //        {
            //            db.Close();
            //            throw new Exception("Placa não existente: " + this.Placa);
            //        }
            //        else
            //        {
            //            SQL = "DELETE FROM TB_cliente WHERE Id = '" + this.Id + "'";
            //            db.SQLCommand(SQL);
            //            db.Close();
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        throw new Exception("Erro ao excluir o conteúdo do identificador: " + ex.Message);
            //    }
            //}



            public List<List<string>> BuscarFicharioDBTodosSQLREL()
            {
                List<List<string>> ListaBusca = new List<List<string>>();
                try
                {
                    var SQL = "SELECT * FROM TB_Cliente";
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

           

            public List<List<string>> BuscarTodosClientes()
            {
                List<List<string>> ListaBusca = new List<List<string>>();
                try
                {
                    var SQL = "SELECT * FROM TB_Cliente";
                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);
                    for (int i = 0; i <= Dt.Rows.Count - 1; i++)
                    {
                        ListaBusca.Add(new List<string> { Dt.Rows[i]["Id"].ToString()
                            , Dt.Rows[i]["Nome"].ToString()
                            , Dt.Rows[i]["NomePai"].ToString()
                            , Dt.Rows[i]["NomeMae"].ToString()
                            , Dt.Rows[i]["NaoTemPai"].ToString()
                            , Dt.Rows[i]["Cpf"].ToString()
                            , Dt.Rows[i]["Genero"].ToString()
                            , Dt.Rows[i]["Cep"].ToString()
                            , Dt.Rows[i]["Logradouro"].ToString()
                            , Dt.Rows[i]["Complemento"].ToString()
                            , Dt.Rows[i]["Numero"].ToString()
                            , Dt.Rows[i]["Bairro"].ToString()
                            , Dt.Rows[i]["Cidade"].ToString()
                            , Dt.Rows[i]["Estado"].ToString()
                            , Dt.Rows[i]["Telefone"].ToString()
                            , Dt.Rows[i]["Profissao"].ToString()
                            , Dt.Rows[i]["Placa"].ToString()
                            , Dt.Rows[i]["Marca"].ToString()
                            , Dt.Rows[i]["Modelo"].ToString()
                            , Dt.Rows[i]["Cor"].ToString()
                            , });
                    }
                    return ListaBusca;

                }
                catch (Exception ex)
                {
                    throw new Exception("Conexão com a base ocasionou um erro: " + ex.Message);
                }
            }

            #endregion



            public class List
            {
                public List<Unit> ListUnit { get; set; }
            }

            //public class EntradaVeiculo
            //{
            //    //Entrada
            //    [Required(ErrorMessage = "Placa é Obrigatorio.")]
            //    [StringLength(7, MinimumLength = 7, ErrorMessage = "A placa deve ter 7 dígitos.")]
            //    public string Placa { get; set; }

            //    public string Modelo { get; set; }

            //    [Required(ErrorMessage = "Horário é Obrigatorio.")]
            //    public int Horario { get; set; }

            //    public string Observacao { get; set; }
            //}


        }


    }
}
