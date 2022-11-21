using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGrupalHerencia
{
    internal class Avion:Aereo
    {
        public int LargoAlas { get; set; }
        public int PesoAlas { get; set; }

        public Avion(int largoalas, int pesoalas, int altitudmaxima, int cantidadhelices,string patente, int cantidadpasajeros)
            :base(altitudmaxima, cantidadhelices, patente, cantidadpasajeros)
        {
            LargoAlas = largoalas;
            PesoAlas = pesoalas;
        }
    }
}
