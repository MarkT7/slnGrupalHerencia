using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGrupalHerencia
{
    internal class MountainBike:Bicicleta
    {
        public string SuelosAptos { get; set; }
        public int FuerzaSuspension { get; set; }

        public MountainBike(string suelosaptos, int fuerzasuspension, int rodado, int cantidadcambios, int gastocalorias, int inclinacionmaxima, int tiempo0100, string marcaruedas, string patente, int cantidadpasajeros)
            :base(rodado, cantidadcambios, gastocalorias, inclinacionmaxima, tiempo0100, marcaruedas, patente, cantidadpasajeros)
        {
            SuelosAptos = suelosaptos;
            FuerzaSuspension = fuerzasuspension;
        }
    }
}
