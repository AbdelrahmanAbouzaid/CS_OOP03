using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface_Ex03
{
    internal class AirPlane : IMoveable, IFlyable
    {
        int IMoveable.Speed { get; set; }
        int IFlyable.Speed { get; set; }

        void IMoveable.Backward()
        {
            Console.WriteLine("AirPlane IMoveable Backward");
        }

        void IFlyable.Backward()
        {
            Console.WriteLine("AirPlane IFlyable Backward");

        }

        void IMoveable.Forward()
        {
            Console.WriteLine("AirPlane IMoveable Forward");

        }

        void IFlyable.Forward()
        {
            Console.WriteLine("AirPlane IFlyable Forward");
        }

        void IMoveable.Left()
        {
            Console.WriteLine("AirPlane IMoveable Left");
        }

        void IFlyable.Left()
        {
            Console.WriteLine("AirPlane IFlyable Left");
        }

        void IMoveable.Right()
        {
            Console.WriteLine("AirPlane IMoveable Right");
        }

        void IFlyable.Right()
        {
            Console.WriteLine("AirPlane IFlyable Right");
        }
    }
}
