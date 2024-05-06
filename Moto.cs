using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseHerencia_Ejercicio2
{
    public class Moto : Vehiculo
    {
        protected float cilindrada;

        public Moto(string patente, byte cantidadRuedas, EMarcas marca, float cilindrada) 
            : base(patente, cantidadRuedas, marca)
        {
            this.cilindrada = cilindrada;
        }

        public string MostrarMoto()
        {
            string mensaje = base.Mostrar();
            mensaje += $"\nCilindrada: {this.cilindrada}";
            return mensaje;
        }
    }
}
