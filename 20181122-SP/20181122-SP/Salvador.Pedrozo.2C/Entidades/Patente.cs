using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Patente
    {
        #region Enumerado
        public enum Tipo
        {
            Vieja, Mercosur
        } 
        #endregion


        #region Atributos
        private Tipo tipoCodigo;
        private string codPatente; 
        #endregion

        #region Constructores
        public Patente() { }

        public Patente(string codPatente, Tipo tipo)
        {
            this.CodigoPatente = codPatente;
            this.TipoCodigo = tipo;
        }
        #endregion

        #region Propiedades
        public string CodigoPatente
        {
            get
            {
                return this.codPatente;
            }
            set
            {
                this.codPatente = value;
            }
        }

        public Tipo TipoCodigo
        {
            get
            {
                return this.tipoCodigo;
            }
            set
            {
                this.tipoCodigo = value;
            }
        }
        #endregion

        #region Métodos
        public override string ToString()
        {
            return this.CodigoPatente;
        } 
        #endregion
    }
}
