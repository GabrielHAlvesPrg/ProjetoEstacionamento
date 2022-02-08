using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace ProjetoEstacionamentoBliblioteca
{
    public class Cls_Uteis
    {

        public static bool validaSenhaLogin(string senha)
        {
            if (senha == "projeto")
            {
                return true;
            }
            return false;
        }


        public static string GeraJSONCEP(string CEP) // função que passa o CEP
        {
            // cria a variavel do tipo "HttpWebRequest" que vai navegar no site "viacep.com.br/ws/  + CEP + "/json/"" , então é como se ele abrisse o brawser e rodasse essa URL;
            System.Net.HttpWebRequest requisicao = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + CEP + "/json/");
            // agora atribuo na variavel do tipo "HttpWebResponse" a resposta da navegação, então nessa variavel "resposta" vou ter o JSON que veio do site. OBS: Ele nao vem no formato de texto, vem no formato HTTPWEBRESPONSE, presciso tranformar esse cara em uma string (texto);
            // primeiro vou tranformar ele em "Stream". "Stream seria um componente de memoria de dados", depois vou ler ele e tranformar ele em um " StringBuilder" e no final tranformo em string;
            HttpWebResponse resposta = (HttpWebResponse)requisicao.GetResponse();

            int cont;
            byte[] buffer = new byte[1000];
            StringBuilder sb = new StringBuilder();
            string temp;
            Stream stream = resposta.GetResponseStream();
            do
            {
                cont = stream.Read(buffer, 0, buffer.Length);
                temp = Encoding.Default.GetString(buffer, 0, cont).Trim();
                sb.Append(temp);

            } while (cont > 0);
            return sb.ToString();

        }


        public static bool Valida(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }
    }
}
