using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGrupalHerencia
{
    internal class Terrestre:Vehiculo
    {
        int Tiempo0100 { get; set; }
        string MarcaRuedas { get; set; }

        public Terrestre(int tiempo0100, string marcaruedas, string patente, int cantidadpasajeros)
            :base(patente, cantidadpasajeros)
        {
            Tiempo0100 = tiempo0100;
            MarcaRuedas = marcaruedas;
        }
    }
}
