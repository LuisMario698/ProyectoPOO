using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Clases
{
    public class HabitacionEstandar : Habitacion
    {
        public HabitacionEstandar() : base("Estandar", 500) { }

        public override decimal CalcularGastosComida(int cantidadComidas)
        {
            return cantidadComidas * 50; // Precio por comida: $15
        }

        public override decimal CalcularGastosLimpieza(bool seLimpio)
        {
            return seLimpio ? 200 : 0; // Costo de limpieza: $20 si se limpió
        }
    }
}
