using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseHerencia_Ejercicio2
{
    public class Vehiculo
    {
        protected string patente;
        protected byte cantidadRuedas;
        protected EMarcas marca;

        public Vehiculo(string patente, byte cantidadRuedas, EMarcas marca)
        {
            this.patente = patente;
            this.cantidadRuedas = cantidadRuedas;
            this.marca = marca;
        }

        public string Patente
        {
            get { return patente; }
        }

        public EMarcas Marca
        {
            get { return marca; }
        }

        /// <summary>
        /// Funcion para mostrar datos del Vehiculo
        /// </summary>
        /// <returns></returns>
        protected string Mostrar()
        {
            string mensaje = $"Patente: {Patente}\n" +
                $"Cantidad Ruedas: {this.cantidadRuedas}\n" +
                $"Marca: {Marca}";           

            return mensaje;
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.patente == v2.patente && v1.marca == v2.marca;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

    }
}
