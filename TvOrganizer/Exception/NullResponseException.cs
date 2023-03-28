using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvOrganizer.Exception
{
    internal class NullResponseException : ApplicationException
    {
        public NullResponseException(string message) : base(message) { }
    }
}
