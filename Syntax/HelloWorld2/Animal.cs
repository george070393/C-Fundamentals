using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    abstract class Animal:IAnimal
    {
        public abstract void Walk();
        
        public virtual void Speak()
        {
            Console.WriteLine("Sunt un animal,ergo nu vorbesc");
        }

        private int age;
        public int Age
        {
            get{
               return age;
            }
            set{
            if (value<10)
                { age = value; }
            else 
                { age = 1; }
                
            }
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }
    }

    class Cat:Animal
    {
        public string Name { get; set; }
        public override void Speak()
        {
            Console.WriteLine("Miau");
        }

        public override void Walk()
        {
            Console.WriteLine("Walk");
        }
    }
    class FatCAt : Cat
    {
        public override void Speak()
        {
            Console.WriteLine("dkdk");
        }
    }


   
}
