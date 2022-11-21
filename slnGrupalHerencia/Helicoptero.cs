using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGrupalHerencia
{
    internal class Helicoptero:Aereo
    {
        public int DiametroHelices { get; set; }
        public int PesoHelices { get; set; }

        public Helicoptero(int diametrohelices, int pesohelices, int altitudmaxima, int cantidadhelices, string patente, int cantidadpasajeros)
            :base(altitudmaxima, cantidadhelices, patente, cantidadpasajeros)
        {
            DiametroHelices = diametrohelices;
            PesoHelices = pesohelices;
        }
    }
}
