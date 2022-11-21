using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGrupalHerencia
{
    internal class Motorizado:Terrestre
    {
        public int CapacidadMotor { get; set; }
        public int RevolucionesMax { get; set; }

        public Motorizado(int capacidadmotor, int revolucionesmax,int tiempo0100, string marcaruedas, string patente, int cantidadpasajeros)
            :base(tiempo0100, marcaruedas, patente, cantidadpasajeros)
        {
            CapacidadMotor = capacidadmotor;
            RevolucionesMax = revolucionesmax;
        }
    }
}
