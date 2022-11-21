using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGrupalHerencia
{
    internal class Camion:Motorizado
    {
        public int CargaMaxima { get; set; }
        public int CantidadEjes { get; set; }
        public Camion(int cargamaxima, int cantidadejes, int capacidadmotor, int revolucionesmax, int tiempo0100, string marcaruedas, string patente, int cantidadpasajeros)
            :base(capacidadmotor, revolucionesmax, tiempo0100, marcaruedas, patente, cantidadpasajeros)
        {
            CargaMaxima = cargamaxima;
            CantidadEjes = cantidadejes;
        }
    }
}
