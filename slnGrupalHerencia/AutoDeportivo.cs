using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGrupalHerencia
{
    internal class AutoDeportivo:Auto
    {
        public int CarrerasGanadas { get; set; }
        public int RecordsRotos { get; set; }

        public AutoDeportivo(int carrerasganadas, int recordsrotos, bool aireacondicionado, int tamanobaul, int capacidadmotor, int revolucionesmax, int tiempo0100, string marcaruedas, string patente, int cantidadpasajeros)
            :base(aireacondicionado, tamanobaul, capacidadmotor, revolucionesmax, tiempo0100,marcaruedas, patente, cantidadpasajeros)
        {
            CarrerasGanadas = carrerasganadas;
            RecordsRotos = recordsrotos;
        }
    }
}
