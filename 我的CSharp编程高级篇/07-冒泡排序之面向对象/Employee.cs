using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_冒泡排序之面向对象
{
    class Employee
    {
        public string Name { get; private set; }
        public int Salary { get; private set; }

        public Employee(string name, int salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        //如果e1大于e2的话，返回true，否则返回false
        public static bool Compare(Employee e1, Employee e2)
        {
            if (e1.Salary > e2.Salary) return true;
            else return false;
        }

        public override string ToString()
        {
            return Name+":"+Salary;
        }
    }
}
