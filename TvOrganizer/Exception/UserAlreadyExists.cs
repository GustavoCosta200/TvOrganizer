using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvOrganizer.Exception
{
    internal class UserAlreadyExists: ApplicationException
    {
        public UserAlreadyExists(string message) : base(message)
        {

        }
    }
}
