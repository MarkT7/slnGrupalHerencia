using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGrupalHerencia
{
    internal class MotoSidecar:Moto
    {
        public int PesoMaxSidecar { get; set; }
        public string PaisesHabilitados { get; set; }
        public MotoSidecar(int pesomaxsidecar, string paiseshabilitados, string materialmanubrio, int largocadena, int capacidadmotor, int revolucionesmax, int tiempo0100, string marcaruedas, string patente, int cantidadpasajeros)
            :base(materialmanubrio, largocadena, capacidadmotor, revolucionesmax, tiempo0100, marcaruedas, patente, cantidadpasajeros)
        {
            PesoMaxSidecar = pesomaxsidecar;
            PaisesHabilitados = paiseshabilitados;
        }
    }
}
