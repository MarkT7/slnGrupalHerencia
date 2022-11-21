using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGrupalHerencia
{
    internal class CamionFrigorifico:Camion
    {
        public int TemperaturaInterna { get; set; }
        public string TipoCarne { get; set; }

        public CamionFrigorifico(int temperaturainterna, string tipocarne, int cargamaxima, int cantidadejes, int capacidadmotor, int revolucionesmax, int tiempo0100, string marcaruedas, string patente, int cantidadpasajeros)
            :base(cargamaxima, cantidadejes, capacidadmotor, revolucionesmax, tiempo0100, marcaruedas, patente, cantidadpasajeros)
        {
            TemperaturaInterna = temperaturainterna;
            TipoCarne = tipocarne;
        }
    }
}
