using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.exceptions
{
    public class DuplicateFacturaException : Exception
    {
        public DuplicateFacturaException() : base($"Factura duplicada.")
        {
            
        }
    }
}
