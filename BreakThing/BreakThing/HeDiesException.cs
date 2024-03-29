using System;
using System.Collections.Generic;
using System.Text;

namespace BreakThing
{
    class HeDiesException : Exception
    {
        
        public HeDiesException()
        {

        }

        public HeDiesException(string exMessage) : base(exMessage)
        {
            
        }

        public HeDiesException(string exMessage, Exception ex) :base(exMessage, ex)
        {

        }
    }
}
