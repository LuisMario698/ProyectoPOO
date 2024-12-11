using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Clases
{
    public interface IHabitacion
    {
        string Tipo { get; }
        decimal PrecioBase { get; }
        decimal CalcularGastosComida(int cantidadComidas);
        decimal CalcularGastosLimpieza(bool seLimpio);
    }
    public abstract class Habitacion : IHabitacion
    {
        public string Tipo { get; protected set; }
        public decimal PrecioBase { get; protected set; }

        public Habitacion(string tipo, decimal precioBase)
        {
            Tipo = tipo;
            PrecioBase = precioBase;
        }

        public abstract decimal CalcularGastosComida(int cantidadComidas);
        public abstract decimal CalcularGastosLimpieza(bool seLimpio);
    }
    
    
    
}
