using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    internal class Employee : Person
    {
        private DateTime dateOfEmployment;  //DateTime=tip date
        private int salary;
        private int availableDaysOff;

        public Employee(string lastname, string firstname, DateTime dateofbirth, 
            DateTime dateOfEmployment, int salary, int availableDaysOff)
        {
            this.lastname = lastname; //retine parametrul
            this.firstname = firstname;
            this.dateofbirth = dateofbirth;
            this.dateOfEmployment = dateOfEmployment;
            this.salary = salary;
            this.availableDaysOff = availableDaysOff;
        }

        public void DisplayInfo(string lastname, string firstname, int salary, int availableDaysOff)
        {
            this.lastname = lastname;
            this.firstname = firstname;            
            this.salary = salary;
            this.availableDaysOff = availableDaysOff;
            Console.WriteLine("Prenume: {0}, Nume: {1} , Salariu: {2} , Zile Libere: {3}", lastname, firstname, salary,
                availableDaysOff);
        }

        private int SubstractDays(int daysoff)
        {
           
            availableDaysOff -= daysoff;
            return availableDaysOff;
        }

        public object AddNewLeave(DateTime startingDate, int duration, string leaveType)
        {
            
            availableDaysOff = SubstractDays(duration);
            Leave curent = new Leave(startingDate, duration, leaveType);
            return curent;

        }

        private static void NegativeLeaveDays(int duration, int availableDaysOff)
        {
            if (availableDaysOff - duration < 0)
            {
                throw new ArithmeticException("Numarul de zile ramase nu poate fi mai mare decat durata concediului",
                    AddNewLeave);
            }
        }

        
    }
}

