using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Ex03
{
    internal class Car : IMoveable
    {
        public int Speed { get; set; }

        public void Backward()
        {
            Console.WriteLine("Car IMoveable Backward");
        }

        public void Forward()
        {
            Console.WriteLine("Car IMoveable Forward");
        }

        public void Left()
        {
            Console.WriteLine("Car IMoveable Left");
        }

        public void Right()
        {
            Console.WriteLine("Car IMoveable Right");
        }
    }
}
