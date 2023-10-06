using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundamentosCs.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string TipoSanguineo { get; set; }
        public char FatorRH { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome}, tenho {Idade} anos e meu tipo de sangue é {TipoSanguineo}{FatorRH}");
        }
    }
}