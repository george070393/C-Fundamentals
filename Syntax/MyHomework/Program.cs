using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    internal class Program
    {
        public static List<Person> GetPersons()
        {
            
            return new List<Person>
            {
                new Person("George", "Popa", new DateTime(1993,03,07)),
                new Person("Florina", "Matei", new DateTime(1993,02,14)),
                new Person("Iulian", "Cepoiu", new DateTime(1993,10,17)),
                new Person("Izabel", "Toma", new DateTime(1993,05,20)),
                new Person("Georgian", "Vlad", new DateTime(1993,04,27)),
                new Person("Sorin", "Broasca", new DateTime(1993,08,13))
            };
        }

        public static List<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee(1, "George", "Popa", new DateTime(1993,03,07), new DateTime(2012,03,03), 2000, 20),
                new Employee(2, "Georgian", "Vlad", new DateTime(1993,04,27), new DateTime(2012,03,03), 2000, 20),
                new Employee(3, "Florina", "Matei", new DateTime(1993,02,14), new DateTime(2014,05,01), 1700, 18),
                new Employee(4, "Izabel", "Toma", new DateTime(1993,05,20), new DateTime(2014,09,05), 2000, 15),
                new Employee(5, "Iulian", "Cepoiu", new DateTime(1993,10,17), new DateTime(2015,02,01), 1500, 5),                                
                new Employee(6, "Sorin", "Broasca", new DateTime(1993,08,13), new DateTime(2015,02,01), 1500, 5)
            };
        }

      


        public static readonly IEnumerable<Person> Persons = GetPersons();

        public static readonly IEnumerable<Employee> Employees = GetEmployees();

       

        private static void Main(string[] args)
        {
           
            //Employee.AddNewLeave(new DateTime(2015 , 05 , 05), 5, Enum.LeaveType.Holiday, 1);
            //Employee.AddNewLeave(new DateTime(2015, 05, 11), 5, Enum.LeaveType.Holiday, 1);
            //Employee.AddNewLeave(new DateTime(2015, 05, 05), 5, Enum.LeaveType.Holiday, 3);
            //Employee.AddNewLeave(new DateTime(2015, 05, 05), 5, Enum.LeaveType.Holiday, 4); 
            //AddEmployee(6, "Nicu", "Salcie", new DateTime(1990, 03, 06), new DateTime(2011, 07, 03), 2000, 20);
            //ShowEmployees();
            //Employee.ShowLeaves();
            //Employee.ShowLeavesForYear(2015,1);
            
          
           
            Console.ReadLine();

        }

        public static void ShowEmployees(){
        
            foreach(var employee in Employees)
            {
                Console.WriteLine(employee);
            }

        }

      

        //Am incercat sa creez o metoda pentu a adauga abgajati noi ,dar nu am reusit,imi sare mereu la exceptie

        //public static void AddEmployee(int id, string lastName, string firstName, DateTime dateOfBirth, DateTime dateOfEmployment, double salary, int availableDaysOff)
        //{
        //    foreach (var employee in Employees)
        //    {
        //        if (employee.id != id)
        //        {
        //            Employee newEmployee = new Employee(id, lastName, firstName, dateOfBirth, dateOfEmployment, salary, availableDaysOff);
        //            var addemployee = new List<Employee>();
        //            addemployee.Add(new Employee(id, lastName, firstName, dateOfBirth, dateOfEmployment, salary, availableDaysOff)
        //            {
        //                id = newEmployee.id, availableDaysOff = newEmployee.availableDaysOff ,
        //                dateOfEmployment = newEmployee.dateOfEmployment,salary = newEmployee.salary
        //            });
        //        }
        //        throw new Exception("Angajautul cu acest id exista deja in lista!");
        //    }
            
        //}
               
      
    }
}