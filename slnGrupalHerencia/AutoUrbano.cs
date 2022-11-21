using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGrupalHerencia
{
    internal class AutoUrbano:Auto
    {
        public bool Automatico { get; set; }
        public int Ofertas { get; set; }

        public AutoUrbano(bool automatico, int ofertas, bool aireacondicionado, int tamanobaul, int capacidadmotor, int revolucionesmax, int tiempo0100, string marcaruedas, string patente, int cantidadpasajeros)
            :base(aireacondicionado, tamanobaul, capacidadmotor, revolucionesmax, tiempo0100, marcaruedas, patente, cantidadpasajeros)
        {
            Automatico = automatico;
            Ofertas = ofertas;
        }
    }
}
