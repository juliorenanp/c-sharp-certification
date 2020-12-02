using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Interfaces : IAulaItem
    {
        public void Executar()
        {
            // Posso atribuir a variável eletro1 a qualquer objeto que implemente esta Interface
            IEletrodomestico eletro1 = new Televisao();
            eletro1.Ligar();
            eletro1 = new Abajur();

        }
    }

    interface IEletrodomestico
    {
        void Desligar();

        void Ligar();
    }

    interface IIluminacao
    {
        double PotenciaDaLampada { get; set; }
    }

    

    class Televisao : IEletrodomestico
    {
        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }

    class Abajur : IEletrodomestico, IIluminacao
    {
        public double PotenciaDaLampada { get; set; }

        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }

    class Lanterna : IEletrodomestico, IIluminacao
    {
        public double PotenciaDaLampada { get; set; }

        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }

    class Radio : IEletrodomestico
    {
        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }
}
