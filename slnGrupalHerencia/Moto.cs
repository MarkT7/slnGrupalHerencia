using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGrupalHerencia
{
    internal class Moto:Motorizado
    {
        public string MaterialManubrio { get; set; }
        public int LargoCadena { get; set; }
        public Moto(string materialmanubrio, int largocadena, int capacidadmotor, int revolucionesmax, int tiempo0100, string marcaruedas, string patente, int cantidadpasajeros)
            :base(capacidadmotor, revolucionesmax, tiempo0100, marcaruedas, patente, cantidadpasajeros)
        {
            MaterialManubrio = materialmanubrio;
            LargoCadena = largocadena;
        }
    }
}
