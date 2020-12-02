using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Objetos : IAulaItem
    {
        public void Executar()
        {
            int pontuacao = 10;
            Console.WriteLine($"pontuacao: {pontuacao}");

            Console.WriteLine($"Object com valor primitivo");
            object meuObjeto;
            meuObjeto = pontuacao;
            Console.WriteLine($"meuObjeto{meuObjeto}");
            Console.WriteLine($"meuObjeto{meuObjeto.GetType()}");


            Console.WriteLine();
            Console.WriteLine("Object com referência de objeto");

            meuObjeto = new Jogador();
            //referencia de classe para Jogador
            Jogador classRef;
            
            // exemplo de conversão explicita ou Cast
            classRef = (Jogador)meuObjeto;

            Console.WriteLine($"classRef.Pontuacao: {classRef.Pontuacao}");

        }
    }

    class Jogador
    {
        public int Pontuacao { get; set; } = 10;
    }
}
