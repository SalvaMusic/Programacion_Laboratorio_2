using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Servicio
    {
      Comun,
      SemiCama,
      Ejecutivo,
    }

    public class PasajeMicro : Pasaje
    {
      public Servicio tipoServicio;

      public PasajeMicro() { }

      public PasajeMicro(string origen, string destino, Pasajero pasajero, float precio, DateTime fecha, Servicio tipoServicio)
        : base(origen, destino, pasajero, precio, fecha)
      {
        this.tipoServicio = tipoServicio;
      }

    public override string Mostrar()
    {
      return String.Format("{0}\nPrecioFinal: {1}", base.Mostrar(), this.PrecioFinal);
    }

    public override float PrecioFinal
    {
      get
      {
        switch (this.tipoServicio)
        {
          case Servicio.SemiCama:
            return Precio + ((Precio * 10) / 100);
          case Servicio.Ejecutivo:
            return Precio + ((Precio * 20) / 100);
        }
        return Precio;
      }
    }
  }
}
