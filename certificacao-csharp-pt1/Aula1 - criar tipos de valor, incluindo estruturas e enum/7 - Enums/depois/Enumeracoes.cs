using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Enumeracoes : IAulaItem
    {
        public void Executar()
        {

            DiasDaSemana primeiroDia = DiasDaSemana.Ter;
            DiasDaSemanaDois segundoDia = DiasDaSemanaDois.Ter;

            DiasDeTrabalho diasDeTrabalho = DiasDeTrabalho.Ter | DiasDeTrabalho.Qui | DiasDeTrabalho.Sab;
            Console.WriteLine(diasDeTrabalho);
        }
    }

    // Automáticamente é pego o próximo número para as demais opções do enum.
    enum DiasDaSemana
    {
        Seg = 1, Ter , Qua, Qui, Sex, Sab, Dom
    }

    enum DiasDaSemanaDois : long
    {
        Seg = 1 , Ter, Qua, Qui, Sex, Sab, Dom
    }

    //A Flags tem o poder de demonstrar o valor detalhado dos Enuns
    [Flags]
    enum DiasDeTrabalho
    {
        Seg = 0, Ter =  1, Qua = 2, Qui = 4, Sex = 8, Sab = 16, Dom = 32
    }
}

