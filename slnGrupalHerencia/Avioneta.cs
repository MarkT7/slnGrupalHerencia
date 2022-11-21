using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGrupalHerencia
{
    internal class Avioneta:Avion
    {
        string TipoUso { get; set; }
        string NombreDueño { get; set; }

        public Avioneta(string tipouso, string nombredueño, int largoalas, int pesoalas, int altitudmaxima, int cantidadhelices, string patente, int cantidadpasajeros)
            :base(largoalas, pesoalas, altitudmaxima, cantidadhelices, patente, cantidadpasajeros)
        {
            TipoUso = tipouso;
            NombreDueño = nombredueño;
        }
    }
}
