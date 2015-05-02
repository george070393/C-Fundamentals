using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    public class Employee : Person
    {
        public int id ;
        public DateTime dateOfEmployment;     //DateTime=tip date
        public double salary;
        public int availableDaysOff;

        public Employee(int id,string lastName, string firstName, DateTime dateOfBirth, DateTime dateOfEmployment, double salary, int availableDaysOff)
            : base(lastName, firstName, dateOfBirth)
        {
            this.salary = salary;
            this.dateOfEmployment = dateOfEmployment;
            this.availableDaysOff = availableDaysOff;
        }

        public override string ToString()
        {
            return "Name: " + this.firstName +" "+ this.lastName + " " + "Date of birth " + this.dateOfBirth + "Date of employment" +this.dateOfEmployment+" Salary:" + this.salary + " Available Days Off:" + this.availableDaysOff;
        }

        public void DisplayInfo(string lastName, string firstName, double salary, int availableDaysOff)
        {
            
            this.lastName = lastName;
            this.firstName = firstName;
            this.salary = salary;
            this.availableDaysOff = availableDaysOff;
            Console.WriteLine("Prenume: {0}, Nume: {1} , Salariu: {2} , Zile Libere: {3}", lastName, firstName, salary,
                availableDaysOff);
        }

        protected static int SubstractDays(int availableDaysOff, int daysoff)
        {

            availableDaysOff -= daysoff;
            return availableDaysOff;
        }


        static List<Leave> leave = new List<Leave>();
        public static void AddNewLeave(DateTime startingDate, int duration, Enum.LeaveType leaveType, int employeeId)
        {
            int availableDays;
            if (Leave.employee.employeeId != employeeId)
            {
                Leave.employee = new Leave(new DateTime(2000, 01, 01), 0, Enum.LeaveType.Other, 0);
            }
            
            if (startingDate.Year > Leave.employee.startingDate.Year)
            {

              availableDays = 20;
            }

             availableDays = Program.Employees.ElementAt(employeeId-1 ).availableDaysOff;

            if (startingDate < Leave.employee.startingDate.AddDays(Leave.employee.duration))
            {
                throw new Exception("Prima zi de concediu se afla in intervalul zilelor de concediu trecut.Alege o alta zi!");
            }
                       
            if (availableDays < duration )
            {
                throw new NegativeLeaveDays( "Numarul de zile ramase nu poate fi mai mare decat durata concediului");
                }
                Program.Employees.ElementAt(employeeId-1).availableDaysOff = SubstractDays(availableDays, duration);                               
                Leave.employee = new Leave(startingDate, duration, leaveType, employeeId);
               
               
               
               leave.Add(new Leave(startingDate, duration, leaveType, employeeId)
                {
                    startingDate = Leave.employee.startingDate,duration = Leave.employee.duration,
                    leaveType = Leave.employee.leaveType, employeeId = Leave.employee.employeeId

                });
               

            
        }

        public static void ShowLeaves()
        {
            foreach (var aleave in leave)
            {
                Console.WriteLine(aleave);
            }
        }

        public static void ShowLeavesForYear(int year,int id)
        {
            foreach (var aleave in leave)
            {
                if (aleave.employeeId == id)
                {
                    if (aleave.startingDate.Year== year)
                    {
                        Console.WriteLine(aleave);
                    }
                    throw new Exception("Nu a fost gasit nici un concediu pe acest an!");
                }
                throw new Exception("Nu a fost gasit nici un angajat cu acest ID!");
            }
        }

        

        
    }
}