using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.Aula1___criar_tipos_de_valor__incluindo_estruturas_e_enum._8___Jokenpo
{
    public class Jokenpo : IAulaItem
    {
        private string pedra = "pedra";
        private string papel = "papel";
        private string tesoura = "tesoura";

        public void Executar()
        {

            Jogar(null, null);
        }

        void Jogar(string opcao1, string opcao2)
        {

        }

        string calculaVencedor(string op, string op2)
        {
            if(op == "tesoura" && op2 == "tesoura")
            {
                return "Empate!";
            }
            else if(op == "tesoura" && op2 == "papel")
            {
                return "${op} Ganha de ${op2}";
            }
            else if(op == "tesoura" && op2 == "pedra")
            {
                return "${op} Perde para ${op2}";
            }
            else
            {
                return "Para jogar, é necessário passar dois valores";
            }
        }
    }
}
