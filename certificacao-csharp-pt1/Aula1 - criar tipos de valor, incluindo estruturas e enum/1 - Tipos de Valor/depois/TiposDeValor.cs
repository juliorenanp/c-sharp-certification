using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class TiposDeValor : IAulaItem
    {
        public void Executar()
        {
            int idade = 28;
            Console.WriteLine(idade);

            int idade2 = idade;
            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"idade2: {idade2}");


            // All variables available
            // type variableName = value;
            int inteiro = 10;
            double preco = 19.99D;
            char caracter = 'J';
            string ronanld = "string gigante";
            bool boleana = true;
        }
    }
}
