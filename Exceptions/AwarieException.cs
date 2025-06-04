using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZglaszanieAwariiApp.Exceptions
{
    public class AwarieException : Exception
    {
        public AwarieException(string message) : base(message) { }
    }
}