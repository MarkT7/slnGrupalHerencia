using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGrupalHerencia
{
    public class Vehiculo
    {
        public string Patente { get; set; }
        public int CantidadPasajeros { get; set; }

        public Vehiculo(string patente, int cantidadpasajeros)
        {
            Patente = patente;
            CantidadPasajeros = cantidadpasajeros;
        }
    }
}
