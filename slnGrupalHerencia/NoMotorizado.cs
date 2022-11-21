using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGrupalHerencia
{
    internal class NoMotorizado:Terrestre
    {
        int GastoCalorias { get; set; }
        int InclinacionMaxima { get; set; }

        public NoMotorizado(int gastocalorias, int inclinacionmaxima, int tiempo0100, string marcaruedas, string patente, int cantidadpasajeros)
            :base(tiempo0100, marcaruedas, patente, cantidadpasajeros)
        {
            GastoCalorias = gastocalorias;
            InclinacionMaxima = inclinacionmaxima;
        }
    }
}
