using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProjetoEstacionamentoBliblioteca.Classes
{
    public class Cep
    {
        public class Unit
        {
            //https://viacep.com.br/ws/12220662/json/ & https://json2csharp.com/
            // Desserealizar uma classe significa que vou tranformar de texto para classe;
            // Serealizar uma classe singifica que vou tranformar de classe para JSON

            public string cep { get; set; }
            public string logradouro { get; set; }
            public string complemento { get; set; }
            public string bairro { get; set; }
            public string localidade { get; set; }
            public string uf { get; set; }
            public string ibge { get; set; }
            public string gia { get; set; }
            public string ddd { get; set; }
            public string siafi { get; set; }
        }

        public static Unit DesSerializedClassUnit(string vJson)
        {
            return JsonConvert.DeserializeObject<Unit>(vJson);//Metodo do newtownsoft (JsonConvert);
        }
    }
}
