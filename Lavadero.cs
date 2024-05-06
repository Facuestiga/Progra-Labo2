using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseHerencia_Ejercicio2
{
    public class Lavadero
    {

        private List<Vehiculo> listaVehiculos;
        private float precioAuto;
        private float precioCamion;
        private float precioMoto;


        private Lavadero()
        {
            this.listaVehiculos = new List<Vehiculo>();
        }

        public Lavadero(float precioAuto, float precioCamion, float precioMoto) : this()
        {
            this.precioAuto = precioAuto;
            this.precioCamion = precioCamion;
            this.precioMoto = precioMoto;
        }

        public string Detalle
        {
            get 
            {
                string detalle = "";

                foreach(var item in listaVehiculos)
                {
                    if(item is Auto auto)
                    {
                        detalle += auto.MostrarAuto();
                    } else if (item is Moto moto)
                    {
                        detalle += moto.MostrarMoto();
                    } else if(item is Camion camion)
                    {
                        detalle += camion.MostrarCamion();
                    }
                }
                return detalle;

            }
        }

        public List<Vehiculo> Vehiculos
        {
            get { return listaVehiculos; }
        }

        public double MostrarTotalFacturado(Lavadero lavadero)
        {
            double precioFinal = 0;

            foreach(Vehiculo item in lavadero.listaVehiculos)
            {
                precioFinal += lavadero.precioAuto + lavadero.precioMoto + lavadero.precioCamion;
            }

            return precioFinal;
        }

        public double MostrarTotalFacturado(EVehiculos vehiculo)
        {
            double precioFinal = 0;

            foreach(Vehiculo v in this.listaVehiculos)
            {
                if(vehiculo == EVehiculos.Auto && v is Auto)
                {
                    precioFinal += precioAuto;
                } else if(vehiculo == EVehiculos.Moto && v is Moto)
                {
                    precioFinal += precioMoto;
                } else
                {
                    precioFinal += precioCamion;
                }
            }

            return precioFinal;
        }


        public static bool operator ==(Lavadero lavadero, Vehiculo vehiculo)
        {
            return lavadero.listaVehiculos.Contains(vehiculo);
        }

        public static bool operator !=(Lavadero lavadero , Vehiculo vehiculo)
        {
            return !(lavadero == vehiculo);
        }

        public static Lavadero operator +(Lavadero lavadero, Vehiculo vehiculo)
        {
            if(lavadero != vehiculo)
            {
                lavadero.listaVehiculos.Add(vehiculo);
            }
            return lavadero;
        }

        public static Lavadero operator -(Lavadero lavadero, Vehiculo vehiculo)
        {
            if(lavadero == vehiculo)
            {
                lavadero.listaVehiculos.Remove(vehiculo);
            }
            return lavadero;
        }

        public static int OrdenarVehiculosPorPatente(Vehiculo v1, Vehiculo v2)
        {
            return string.Compare(v1.Patente, v2.Patente);
        }

        public static int OrdenarVehiculosPorMarca(Vehiculo v1, Vehiculo v2)
        {
            return string.Compare(v1.Marca.ToString(), v2.Marca.ToString());
        }
    }
}
