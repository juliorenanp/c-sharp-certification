using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    public class Classes : IAulaItem
    {
        public void Executar()
        {
            
        }

     // pode ser vista dentro de mesmo assembly, neste caso a certificacao-charp-pt1
     internal class SerVivo
        {
            public SerVivo(int idade, string nome, int peso)
            {
                Idade = idade;
                Nome = nome;
                Peso = peso;
            }

            public int Idade { get; set; }
            public string Nome { get; set; }
            public int Peso { get; set; }

            protected int retornaIdade()
            {
                return this.Idade;
            }

            public int retornaIdadePub()
            {
                return this.Idade;
            }

        }

        private class Humano : SerVivo
        {
            public Humano(int idade, string nome, int peso) : base(idade, nome, peso)
            {

            }
        }
    }
}
