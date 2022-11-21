using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGrupalHerencia
{
    internal class Bicicleta:NoMotorizado
    {
        public int Rodado { get; set; }
        public int CantidadCambios { get; set; }
        public Bicicleta(int rodado, int cantidadcambios, int gastocalorias, int inclinacionmaxima, int tiempo0100, string marcaruedas, string patente, int cantidadpasajeros)
            :base(gastocalorias, inclinacionmaxima, tiempo0100, marcaruedas, patente, cantidadpasajeros)
        {
            Rodado = rodado;
            CantidadCambios = cantidadcambios;
        }
    }
}
