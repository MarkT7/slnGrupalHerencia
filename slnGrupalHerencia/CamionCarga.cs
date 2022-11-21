using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGrupalHerencia
{
    internal class CamionCarga:Camion
    {
        public int KmRecorridos { get; set; }
        public bool Internacional { get; set; }

        public CamionCarga(int kmrecorridos, bool internacional, int cargamaxima, int cantidadejes, int capacidadmotor, int revolucionesmax, int tiempo0100, string marcaruedas, string patente, int cantidadpasajeros)
            :base(cargamaxima, cantidadejes, capacidadmotor, revolucionesmax, tiempo0100, marcaruedas, patente, cantidadpasajeros)
        {
            KmRecorridos = kmrecorridos;
            Internacional = internacional;
        }
    }
}
