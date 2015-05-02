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
        public Enum.LeaveType leaveType;
        public int employeeId;
        public static Leave employee = new Leave(new DateTime(2000,01 , 01), 0, Enum.LeaveType.Other, 0);
        

        public Leave(DateTime startingDate, int duration, Enum.LeaveType leaveType,int employeeId)
        {
           
            this.startingDate = startingDate;
            this.duration = duration;
            this.leaveType = leaveType;
            this.employeeId = employeeId;

        }

        public override string ToString()
        {
            return "Prima zi de concediu: " + this.startingDate + " " + " Durata:" + this.duration + " " + "Tip concediu: " + this.leaveType + " " + "ID Angajat " + this.employeeId;
        }
    }
}
