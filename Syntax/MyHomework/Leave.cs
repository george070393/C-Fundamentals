using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    class Leave
    {
        private int startingDate;
        private int duration;
        private string leaveType;
        private object employee;
        public object curent;

        public object currentLeave
        {
            get { return employee; }
            set { employee = curent; }
        }

        public void Leave(int startingDate, int duration, string leavetype)
        {
            
        }
    }
}
