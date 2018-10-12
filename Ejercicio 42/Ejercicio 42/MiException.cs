using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    public class MiException : Exception
    {
        public MiException() { }
        public MiException(string message) : base(message) { }
        public MiException(string message, Exception inner) : base(message, inner) { }
        protected MiException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
