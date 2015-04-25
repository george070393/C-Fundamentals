using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    class Leave
    {
        private DateTime startingDate;
        private int duration;
        private string leaveType;
        private object employee;
        public object curent;

        public object currentLeave
        {
            get { return employee; }
            set { employee = curent; }
        }

        public Leave(DateTime startingDate, int duration, string leavetype)
        {
            this.startingDate = startingDate;
            //......
        }
    }
}
