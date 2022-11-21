using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGrupalHerencia
{
    internal class Hidroavion:Avion
    {
        int CapacidadFlotadores { get; set; }
        int CostoFlotadores { get; set; }

        public Hidroavion(int capacidadflotadores, int costoflotadores,int largoalas, int pesoalas, int altitudmaxima, int cantidadhelices, string patente, int cantidadpasajeros)
            :base(largoalas, pesoalas, altitudmaxima, cantidadhelices, patente, cantidadpasajeros)
        {
            CapacidadFlotadores = capacidadflotadores;
            CostoFlotadores = costoflotadores;
        }
    }
}
