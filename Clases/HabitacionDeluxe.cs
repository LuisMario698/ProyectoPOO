using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Clases
{
    public class HabitacionDeluxe : Habitacion
    {
        public HabitacionDeluxe() : base("Deluxe", 1500) { }

        public override decimal CalcularGastosComida(int cantidadComidas)
        {
            return cantidadComidas * 100; // Precio por comida: $15
        }

        public override decimal CalcularGastosLimpieza(bool seLimpio)
        {
            return seLimpio ? 300 : 0; // Costo de limpieza: $20 si se limpió
        }
    }
}
