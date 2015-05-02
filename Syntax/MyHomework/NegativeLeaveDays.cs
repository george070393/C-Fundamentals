using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    
        public class NegativeLeaveDays : Exception
        {
            public NegativeLeaveDays()
            {
            }

            public NegativeLeaveDays(string message)
                : base(message)
            {
            }

            public NegativeLeaveDays(string message, Exception inner)
                : base(message, inner)
            {
            }
        }
    
}
