using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGrupalHerencia
{
    internal class Triciclo:NoMotorizado
    {
        public int EdadMaxima { get; set; }
        public int EdadMinima { get; set; }
        public Triciclo(int edadmaxima, int edadminima, int gastocalorias, int inclinacionmaxima, int tiempo0100, string marcaruedas, string patente, int cantidadpasajeros)
            :base(gastocalorias, inclinacionmaxima, tiempo0100, marcaruedas, patente, cantidadpasajeros)
        {
            EdadMaxima = edadmaxima;
            EdadMinima = edadminima;
        }
    }
}
