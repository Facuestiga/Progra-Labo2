using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseHerencia_Ejercicio2
{
    public class Auto : Vehiculo
    {
        protected int cantidadAsientos;

        public Auto(string patente, byte cantidadRuedas, EMarcas marca, int cantidadAsientos)
            : base(patente, cantidadRuedas, marca)
        {
            this.cantidadAsientos = cantidadAsientos;
        }

        public string MostrarAuto()
        {
            string mensaje = base.Mostrar();
            mensaje += $"\nCantidad de Asientos: {this.cantidadAsientos}";
            return mensaje;  
        }
    }
}
