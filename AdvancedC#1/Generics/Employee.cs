using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_1.Generics
{
    internal class Employee:IComparable
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id,string name,double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{Id}::{Name}::{Salary}";
        }

        //public static bool operator ==(Employee left, Employee right)
        //{
        //    return left.Equals(right);
        //}
        //public static bool operator !=(Employee left, Employee right)
        //{
        //    return !left.Equals(right) ;
        //}

        public override bool Equals(object? obj)
        {
            Employee PassedEmployee = (Employee)obj;
            return (this.Id == PassedEmployee.Id) && (this.Name == PassedEmployee.Name) && (this.Salary == PassedEmployee.Salary);
        }

        public int CompareTo(object? obj)
        {
            Employee PassedEmployee = (Employee)obj;//Explicit Casting Unsafe
            if (this.Salary > PassedEmployee.Salary)
                return 1;
            else if (this.Salary < PassedEmployee.Salary)
                return -1;
            else return 0;
        }

        
    }
}
