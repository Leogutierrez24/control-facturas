using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Resultado<T>
    {
        public bool Success { get; }
        public T Value { get; }

        public Resultado(bool success, T value)
        {
            Success = success;
            Value = value;
        }
    }
}
