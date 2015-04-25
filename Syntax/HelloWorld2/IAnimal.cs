using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    public interface IAnimal
    {
        int Age { get; set; }
        void Eat();
    }
}
