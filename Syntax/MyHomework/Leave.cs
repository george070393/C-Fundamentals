using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    class Leave
    {
        public DateTime startingDate;
        public int duration;
        public string leaveType;
        private object employee;
        public object curent= null;

        public object currentLeave
        {
            get { return employee; }
            set { employee = curent; }
        }

        public Leave(DateTime startingDate, int duration, string leavetype)
        {
            this.startingDate = startingDate;
            this.duration = duration;
            this.leaveType = leavetype;
        }
    }
}
