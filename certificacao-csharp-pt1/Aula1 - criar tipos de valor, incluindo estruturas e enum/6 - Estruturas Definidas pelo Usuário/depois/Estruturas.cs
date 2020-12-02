using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Estruturas : IAulaItem
    {
        public void Executar()
        {
            double Latitude1 = 13.78;
            double Longitude1 = 29.51;
            double Latitude2 = 40.23;
            double Longitude2 = 17.4;
            Console.WriteLine($"Latitude1 = {Latitude1}");
            Console.WriteLine($"Longitude1 = {Longitude1}");
            Console.WriteLine($"Latitude2 = {Latitude2}");
            Console.WriteLine($"Longitude2 = {Longitude2}");

            // By default all variables created as struct are created with 0 (for double).
            PosicaoGps posicao1;
            posicao1.Latitude = 15.23;
            posicao1.Longitude = 29.30;

            posicao1 = new PosicaoGps() { Longitude = 33.12, Latitude = 12.33 };
            posicao1 = new PosicaoGps(32.11, 33.52);
        }
    }


    interface IGPS
    {
        bool EstaNoHemisFerioNorte();
    }

    // O que diferencia uma estrutura de uma classe? Uma variavel do tipo estrutura é um tipo de valor e não uma referência.
    // Se copiarmos a estrutura ambas estarão diferentes. No caso da classe os valores se manteriam os mesmos.
    // Utilizada para coisas simples, como uma cor ou etc.
    struct PosicaoGps : IGPS
    {
        public double Latitude;
        public double Longitude;

        public PosicaoGps(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public bool EstaNoHemisFerioNorte()
        {
            return Latitude > 0;
        }

        public override string ToString()
        {
            return $"Latitude:{Latitude}, Longitude {Longitude} ";
        }
    }
}
