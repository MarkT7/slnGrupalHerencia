using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGrupalHerencia
{
    internal class AvionComercial:Avion
    {
        public int CantidadAzafatas { get; set; }
        public int CantidadBaños { get; set; }

        public AvionComercial(int cantidadazafatas, int cantidadbaños, int largoalas, int pesoalas, int altitudmaxima, int cantidadhelices, string patente, int cantidadpasajeros)
            :base( largoalas, pesoalas, altitudmaxima, cantidadhelices, patente, cantidadpasajeros)
        {
            CantidadAzafatas = cantidadazafatas;
            CantidadBaños = cantidadbaños;
        }
    }
}
