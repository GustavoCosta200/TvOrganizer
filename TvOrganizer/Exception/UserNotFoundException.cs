using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvOrganizer.Exception
{
    internal class UserNotFoundException: ApplicationException
    {
        public UserNotFoundException(string message) : base(message)
        {
        }
    }
}
