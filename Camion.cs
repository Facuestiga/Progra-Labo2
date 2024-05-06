using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseHerencia_Ejercicio2
{
    public class Camion : Vehiculo
    {
        protected float tara;

        public Camion(string patente, byte cantidadRuedas, EMarcas marca, float tara)
            : base(patente, cantidadRuedas, marca)
        {
            this.tara = tara;
        }

        public string MostrarCamion()
        {
            string mensaje = base.Mostrar();
            mensaje += $"\nTara kg: {this.tara}";
            return mensaje;
        }

    }
}
