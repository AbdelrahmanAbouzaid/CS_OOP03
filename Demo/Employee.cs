using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Employee : ICloneable,IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public object Clone()
        {
            return new Employee() {Id = this.Id, Name = this.Name, Age = this.Age ,Salary = this.Salary };
        }

        public int CompareTo(object? obj)
        {
            Employee employee = (Employee)obj;   //obj as Employee;

            //if (this.Age > employee.Age) return 1;
            //else if (this.Age < employee.Age) return -1;
            //else return 0;

            return this.Age.CompareTo(employee.Age);
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}, Salary: {Salary}";
        }
    }
}
