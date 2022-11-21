using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGrupalHerencia
{
    internal class Auto:Motorizado
    {
        public bool AireAcondicionado { get; set; }
        public int TamanoBaul { get; set; }

        public Auto(bool aireacondicionado, int tamanobaul, int capacidadmotor, int revolucionesmax, int tiempo0100, string marcaruedas, string patente, int cantidadpasajeros)
            :base(capacidadmotor, revolucionesmax, tiempo0100, marcaruedas, patente, cantidadpasajeros)
        {
            AireAcondicionado = aireacondicionado;
            TamanoBaul = tamanobaul;
        }
    }
}
