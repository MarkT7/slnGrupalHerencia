using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGrupalHerencia
{
    internal class MotoDeportiva:Moto
    {
        public int Accidentes { get; set; }
        public string PistasHabilitadas { get; set; }
        public MotoDeportiva(int accidentes, string pistashabilitadas,string materialmanubrio, int largocadena, int capacidadmotor, int revolucionesmax, int tiempo0100, string marcaruedas, string patente, int cantidadpasajeros)
            :base(materialmanubrio,largocadena, capacidadmotor, revolucionesmax, tiempo0100,  marcaruedas,  patente, cantidadpasajeros)
        {
            Accidentes = accidentes;
            PistasHabilitadas = pistashabilitadas;
        }
    }
}
