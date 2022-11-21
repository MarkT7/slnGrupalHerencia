using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGrupalHerencia
{
    internal class Motomel:Moto
    {
        public int Ofertas { get; set; }
        public string TipoPlastico { get; set; }
        public Motomel(int ofertas, string tipoplastico, string materialmanubrio, int largocadena, int capacidadmotor, int revolucionesmax, int tiempo0100, string marcaruedas, string patente, int cantidadpasajeros)
            :base(materialmanubrio,largocadena,capacidadmotor, revolucionesmax, tiempo0100,  marcaruedas, patente, cantidadpasajeros)
        {
            Ofertas = ofertas;
            TipoPlastico = tipoplastico;
        }
    }
}
