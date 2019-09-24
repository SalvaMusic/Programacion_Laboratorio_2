using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class PasajeAvion : Pasaje
  {
    public int cantidadEscalas;

    public PasajeAvion() { }

    public PasajeAvion(string origen, string destino, Pasajero pasajero, float precio, DateTime fecha, int cantidadEscalas)
      :base(origen, destino,pasajero,precio,fecha)
    {
      this.cantidadEscalas = cantidadEscalas;
    }

    public override string Mostrar()
    {
      return String.Format("{0}\nPrecioFinal: {1}",base.Mostrar(),this.PrecioFinal);
    }

    public override float PrecioFinal
    {
      get
      {
        switch(this.cantidadEscalas)
        {
          case 1:
            return Precio - ((Precio * 10) / 100);
          case 2:
            return Precio - ((Precio * 20) / 100);
        }
        return Precio - ((Precio * 30) / 100); ;
      }
    }
  }
}
