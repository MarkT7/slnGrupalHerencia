using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGrupalHerencia
{
    internal class Aereo:Vehiculo
    {
        int AltitudMaxima { get; set; }
        int CantidadHelices { get; set; }

        public Aereo(int altitudmaxima, int cantidadhelices, string patente, int cantidadpasajeros)            :base(patente, cantidadpasajeros)        {
            AltitudMaxima = altitudmaxima;
            CantidadHelices = cantidadhelices;
        }           

    }
}
