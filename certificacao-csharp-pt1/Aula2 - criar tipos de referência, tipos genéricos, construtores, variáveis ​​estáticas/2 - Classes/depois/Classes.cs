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
     internal class Humano
        {
            public int Idade { get; set; }
            public string Nome { get; set; }
            public int Peso { get; set; }
        }
    }
}
