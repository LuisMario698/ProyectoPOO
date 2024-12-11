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
