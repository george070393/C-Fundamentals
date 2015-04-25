using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    class Employee:Person
    {
        private int dateOfEmployment;
        private int salary;
        private int availableDaysOff;

        public void employeeDetails(string lastname, string firstname, int dateofbirth,
            int dateOfEmployment, int salary, int availableDaysOff)
        {
            
        }

        public void DisplayInfo(string lastname, string firstname, int salary, int availableDaysOff)
        {
            Console.WriteLine("Prenume: {0}, Nume: {1} , Salariu: {2} , Zile Libere: {3}" , lastname,firstname,salary,availableDaysOff);
        }

        private int SubstractDays(int daysoff)
        {
            availableDaysOff -= daysoff;
            return availableDaysOff;
        }

        public object AddNewLeave(int startingDate, int duration, string leaveType)
        {
            availableDaysOff = SubstractDays(duration);
            Leave curent = new Leave(startingDate,duration,leaveType);
            return curent;

        }

        static void NegativeLeaveDays(int duration, int availableDaysOff)
        {
            if (availableDaysOff - duration < 0)
            {
                throw new ArithmeticException("Numarul de zile ramase nu poate fi mai mare decat durata concediului", "AddNewLeave");
            }
        }
    }
}
