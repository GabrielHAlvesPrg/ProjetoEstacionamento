using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace ProjetoEstacionamentoBliblioteca.DataBases
{
    public class SQLServerClass
    {
        public string StringConn;
        public SqlConnection connDB;

        public SQLServerClass()
        {
            try
            {
                StringConn = ConfigurationManager.ConnectionStrings["Fichario"].ConnectionString;
                connDB = new SqlConnection(StringConn);
                connDB.Open();
            }
            catch(Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
        }

        // ( SQLQuery) Tenho meu método para poder fazer uma consulta e retornar uma resposta.Vou receber dados e esses dados vão ser convertidos para uma tabela em memória dentro do meu ambiente, da minha aplicação.
        public DataTable SQLQuery(string SQL)
        {
            DataTable dt = new DataTable();
            try
            {
                var myCommand = new SqlCommand(SQL, connDB);//Criei a variável do tipo my command, como se estivesse preparando um pacote para ser enviado para o banco;
                myCommand.CommandTimeout = 0;// esse 0 significa que nao existe time out, ele vai esperar o tempo que for necessário;
                var myReader = myCommand.ExecuteReader();//envio o pacote;
                dt.Load(myReader); // a minha variavel dt, vai ter o conteudo do retorno do comando sql, que fez uma consulta no banco de dados;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }


        //SQLcommand, caso eu queira executar um comando que me retorne uma mensagem. Vai ser comando de inclusão, alteração, exclusão ou criação da estrutura de banco de dados.
        public string SQLCommand(string SQL)
        {
            try
            {
                var myCommand = new SqlCommand(SQL, connDB);//Criei a variável do tipo my command, como se estivesse preparando um pacote para ser enviado para o banco;
                myCommand.CommandTimeout = 0;// esse 0 significa que nao existe time out, ele vai esperar o tempo que for necessário;
                var myReader = myCommand.ExecuteReader();//envio o pacote;
                return "";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Método para fechar a conexão;
        public void Close()
        {
            connDB.Close();
        }
    }
}
