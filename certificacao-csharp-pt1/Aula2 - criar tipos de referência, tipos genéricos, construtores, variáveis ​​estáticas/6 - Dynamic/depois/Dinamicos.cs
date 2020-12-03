using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Dinamicos : IAulaItem
    {
        public void Executar()
        {
            object objeto = 1;
            //objeto = objeto + 3;


            // Operações que contêm expressões dynamic não são resolvidas ou verificadas pelo compilador.
            // O tipo dynamic existe somente em tempo de compilação e não em tempo de execução.

            dynamic dinamico = 1;
            dinamico = dinamico + 3;

            Console.WriteLine(dinamico);
        }
    }
}
