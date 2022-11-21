using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGrupalHerencia
{
    internal class HelicopteroMilitar:Helicoptero
    {
        public int CantidadMunicion { get; set; }
        public int CantidadMisiles { get; set; }
        public HelicopteroMilitar(int cantidadmunicion, int cantidadmisiles, int diametrohelices, int pesohelices, int altitudmaxima, int cantidadhelices, string patente, int cantidadpasajeros)
            :base(diametrohelices, pesohelices, altitudmaxima, cantidadhelices, patente, cantidadpasajeros)
        {
            CantidadMunicion = cantidadmunicion;
            CantidadMisiles = cantidadmisiles;
        }
    }
}
