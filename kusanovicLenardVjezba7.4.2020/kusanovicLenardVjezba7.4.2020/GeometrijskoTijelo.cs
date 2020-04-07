using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kusanovicLenardVjezba7._4._2020
{
    class GeometrijskoTijelo
    {
        double volumen;
        double oplosje;
        static int brojacTijela;

        public double Volumen { get => volumen; set => volumen = value; }
        public double Oplosje { get => oplosje; set => oplosje = value; }
        public static int BrojacTijela { get => brojacTijela; set => brojacTijela = value; }

        public GeometrijskoTijelo()
        {
            brojacTijela++;
        }
    }
}
