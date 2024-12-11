using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Clases
{
    public class HabitacionSuite : Habitacion
    {
        public HabitacionSuite() : base("Suite", 1000) { }

        public override decimal CalcularGastosComida(int cantidadComidas)
        {
            return cantidadComidas * 70; // Precio por comida: $15
        }

        public override decimal CalcularGastosLimpieza(bool seLimpio)
        {
            return seLimpio ? 250 : 0; // Costo de limpieza: $20 si se limpió
        }
    }
}
