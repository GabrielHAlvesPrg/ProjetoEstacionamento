using ProjetoEstacionamentoBliblioteca.DataBases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjetoEstacionamentoBliblioteca.Classes
{
    public class Veiculo 
    {
        public class Unit
        {

            public string IdCliente { get; set; }


            //Entrada
            [Required(ErrorMessage = "Placa é Obrigatorio.")]
            [StringLength(7, MinimumLength = 7, ErrorMessage = "A placa deve ter 7 dígitos.")]
            public string Placa { get; set; }

            public string Modelo { get; set; }

            [Required(ErrorMessage = "Horário é Obrigatorio.")]
            public string Horario { get; set; }

            public string Observacao { get; set; }


            public void IncluirFicharioSQLRELEntrada()
            {
                try
                {
                    string SQL;
                    SQL = this.ToInsertEntrada();
                    var db = new SQLServerClass();
                    db.SQLCommand(SQL);
                    db.Close();

                }
                catch (Exception ex)
                {
                    throw new Exception("Inclusão não permitida. Placa: " + this.Placa + ", erro: " + ex.Message);
                }

            }


            public string ToInsertEntrada()
            {
                string SQL;
                SQL = @"INSERT INTO Tb_Estacionado
                            (Placa    
                            ,Modelo
                            ,Horario
                            ,Observacao";
                            if (this.IdCliente != "")
                            {
                                SQL += ",IdCliente)";

                            }
                            else
                            {
                                  SQL += ") ";
                            } 
                            SQL += "VALUES ";
                SQL += "('" + this.Placa + "'";
                SQL += ",'" + this.Modelo + "'";
                SQL += ",'" + this.Horario + "'";
                SQL += ",'" + this.Observacao + "'";
                if (this.IdCliente != "")
                {
                 SQL += ",'" + this.IdCliente + "');";

                }
                else
                {

                    SQL +=  ");";
                }
                return SQL;

            }

            public void SaidaEstacionado()
            {
                try
                {
                    string SQL = "SELECT * FROM [Tb_Estacionado] WHERE Placa = '" + this.Placa + "'";
                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);
                    if (Dt.Rows.Count == 0)
                    {
                        db.Close();
                        throw new Exception("Indentificador não existente: " + this.Placa);
                    }
                    else
                    {
                        SQL = "DELETE FROM Tb_Estacionado WHERE Placa = '" + this.Placa + "'";
                        db.SQLCommand(SQL);
                        db.Close();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao excluir o conteúdo do identificador: " + ex.Message);
                }
            }


            public List<List<string>> BuscarFicharioTodosVeiculoSQLREL()
            {
                List<List<string>> ListaBusca = new List<List<string>>();
                try
                {
                    var SQL = "SELECT * FROM Tb_Estacionado";
                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);
                    for (int i = 0; i <= Dt.Rows.Count - 1; i++)
                    {
                        ListaBusca.Add(new List<string> {

                                Dt.Rows[i]["Placa"].ToString(),
                                Dt.Rows[i]["Modelo"].ToString(),
                                Dt.Rows[i]["Horario"].ToString(),
                                Dt.Rows[i]["Observacao"].ToString(),
                                Dt.Rows[i]["IdCliente"].ToString(),

                            });

                    }
                    return ListaBusca;

                }
                catch (Exception ex)
                {
                    throw new Exception("Conexão com a base ocasionou um erro: " + ex.Message);
                }
            }

          

            public Unit BuscarFicharioVeiculoEstacionadoSQLREL(string Placa)
            {
                try
                {
                    string SQL = "SELECT * FROM [Tb_Estacionado] WHERE Placa = '" + Placa + "'";
                    var db = new SQLServerClass();
                    var Dt = db.SQLQuery(SQL);
                    if (Dt.Rows.Count == 0)
                    {
                        db.Close();
                        throw new Exception("Indentificador não existente: " + Placa);
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


            public Unit DataRowToUnit(DataRow dr)//essa função, entra um datarow e sai uma classe;
            {
                Unit u = new Unit(); // a unit é uma subclasse que tem as caracteristicas da classe;
                u.Placa = dr["Placa"].ToString();
                u.Modelo = dr["Modelo"].ToString();
                u.Horario = dr["Horario"].ToString();
                u.Observacao = dr["Observacao"].ToString();
                return u;

            }

            public class List
            {
                public List<Unit> ListUnit { get; set; }
            }
        }
    }
}
