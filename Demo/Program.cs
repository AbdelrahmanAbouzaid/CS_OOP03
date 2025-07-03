using Demo.Interface_Ex01;

using Demo.Interface_Ex02;
using Demo.Interface_Ex03;


namespace Demo
{
    internal class Program
    {
        #region Overload
        //static void Print10Numbers(SeriesByTwo series)
        //{
        //    for (int i = 0; i < 10; i++) 
        //    {
        //        Console.Write($"{series.Current}, ");
        //        series.Next();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}
        //static void Print10Numbers(SeriesByThree series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write($"{series.Current}, ");
        //        series.Next();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}
        //static void Print10Numbers(SeriesByFour series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write($"{series.Current}, ");
        //        series.Next();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //} 
        #endregion
        static void Print10Numbers(ISeries series)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{series.Current}, ");
                series.Next();
            }
            Console.WriteLine();
            series.Reset();
        }

        static void Main(string[] args)
        {
            #region Interface Ex01
            // Interface : Reference Type
            // Code Contruct Between The Developer Who Write It And The Developer Who Use It[Implementation]

            // IMyType myType = new IMyType();
            // Can't Create Object From Any Interfaces

            //MyType myType = new MyType();
            //myType.MyFun();
            //myType.Salary = 20000;
            //Console.WriteLine(myType.Salary);
            ////myType.Print();

            //IMyType myType2;
            //// Ref --> Can refere to object from any which implemented the interface 'IMyType'
            //myType2 = new MyType();
            //myType2.MyFun();
            //myType2.Salary = 100000;
            //Console.WriteLine(myType2.Salary);
            //myType2.Print(); 
            #endregion

            #region Interface Ex02
            //SeriesByTwo series = new SeriesByTwo();
            //Print10Numbers(series);
            //SeriesByThree series2 = new SeriesByThree();
            //Print10Numbers(series2);
            //SeriesByFour series3 = new SeriesByFour();
            //Print10Numbers(series3); 
            #endregion

            #region Interface Ex03
            //Car car = new Car();
            //car.Speed = 120;
            //Console.WriteLine(car.Speed);
            //car.Backward();

            //AirPlane plane = new AirPlane();

            //IMoveable moveable = plane;
            //moveable.Speed = 100;
            //moveable.Forward();

            //IFlyable flyable = plane;
            //flyable.Speed = 100;
            //flyable.Backward(); 
            #endregion

            #region Shallow Copy Vs Deep Copy
            //// Shallow Copy Vs Deep Copy
            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = { 4, 5, 6 };

            //Console.WriteLine($"arr1: {arr1.GetHashCode()}");
            //Console.WriteLine($"arr2: {arr2.GetHashCode()}");
            //Console.WriteLine();
            //arr2 = arr1; // Shallow Copy
            //// Copy Identity 
            //// { 1, 2, 3 } -> Has Tow References arr1,arr2
            //// { 4, 5, 6 } -> UnReachable Object

            //Console.WriteLine($"arr1: {arr1.GetHashCode()}");
            //Console.WriteLine($"arr2: {arr2.GetHashCode()}");

            //// Identity(Address) + Object State


            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = { 4, 5, 6 };

            //Console.WriteLine($"arr1: {arr1.GetHashCode()}");
            //Console.WriteLine($"arr2: {arr2.GetHashCode()}");
            //Console.WriteLine();
            //arr2 = (int[])arr1.Clone(); // Deep Copy
            //                            //Clone Method Will Copy The Object State of The Caller
            //                            //Assign The New Object To arr2, Will Generate New Identity


            //Console.WriteLine($"arr1: {arr1.GetHashCode()}");
            //Console.WriteLine($"arr2: {arr2.GetHashCode()}");

            // Identity(Address) + Object State 
            #endregion

            #region Built-in Interface - IClonable
            //Employee emp1 = new Employee() { Id = 1, Name = "Abdelrahman", Age = 22, Salary = 20000 };
            //Employee emp2 = new Employee() { Id = 2, Name = "Ahmed", Age = 21, Salary = 18000 };

            ////emp2 = emp2; // Shallow Copy

            //emp2 = (Employee)emp1.Clone(); // Deep Copy
            //Console.WriteLine(emp1.GetHashCode());
            //Console.WriteLine(emp2.GetHashCode());

            //Console.WriteLine(emp1);
            //Console.WriteLine(emp2); 
            #endregion

            #region Built-in Interface - IComparable
            //Employee[] employees =
            //{
            //    new Employee(){ Id=1,Name="Abdelrahman",Age=22,Salary=20000},
            //    new Employee(){ Id=2,Name="Ahmed",Age=21,Salary=15000},
            //    new Employee(){ Id=3,Name="Omar",Age=20,Salary=18000},
            //};

            //int x = employees[0].CompareTo(employees[1]);
            //// +ve  : Caller Greater Than Parameter
            //// -ve  : Caller Less Than Parameter
            ////  0   : Caller Equal Parameter

            //Array.Sort(employees);
            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employee);
            //} 
            #endregion


        }
    }
}
