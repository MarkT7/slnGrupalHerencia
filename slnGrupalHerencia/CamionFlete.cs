using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGrupalHerencia
{
    internal class CamionFlete:Camion
    {
        public int Mudanzas { get; set; }
        public int PrecioFlete { get; set; }
        public CamionFlete(int mudanzas, int precioflete, int cargamaxima, int cantidadejes, int capacidadmotor, int revolucionesmax, int tiempo0100, string marcaruedas, string patente, int cantidadpasajeros)
            :base(cargamaxima,  cantidadejes, capacidadmotor, revolucionesmax, tiempo0100, marcaruedas, patente, cantidadpasajeros)
        {
            Mudanzas = mudanzas;
            PrecioFlete = precioflete;
        }
    }
}
