using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Age = 15;
            Console.WriteLine(cat.Age);
            cat.Speak();
            Console.ReadLine();
        }
       
    }
}
