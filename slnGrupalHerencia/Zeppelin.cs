using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGrupalHerencia
{
    internal class Zeppelin:Aereo
    {
        public int Volumen { get; set; }
        public string Gas { get; set; }
        public Zeppelin(int volumen, string gas, int altitudmaxima, int cantidadhelices, string patente, int cantidadpasajeros)
            :base(altitudmaxima, cantidadhelices, patente, cantidadpasajeros)
        {
            Volumen = volumen;
            Gas = gas;
        }
    }
}
