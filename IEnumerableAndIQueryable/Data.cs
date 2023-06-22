using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableAndIQueryable
{
    internal class Data
    {

        public List<Employee> Employees = new List<Employee>();

        public Data()
        {
            Employees.Add(new Employee(1, "Karyn Jury", 90000));
            Employees.Add(new Employee(2, "Jacqueline Allen", 50000));
            Employees.Add(new Employee(3, "Andrew Warren", 78000));
            Employees.Add(new Employee(4, "Arthur Gray", 110000));
            Employees.Add(new Employee(5, "Lawrence Paul", 102000));
            Employees.Add(new Employee(6, "Thelma Piper", 76000));
            Employees.Add(new Employee(7, "Sheila Handy", 93000));
            Employees.Add(new Employee(8, "Gary Swanson", 98000));
            Employees.Add(new Employee(9, "Mara Dennis", 45000));
            Employees.Add(new Employee(10, "Kelsey Patchell", 58000));
            Employees.Add(new Employee(11, "Tom McPherson", 67000));
            Employees.Add(new Employee(12, "Richard Garrison", 81000));
            Employees.Add(new Employee(13, "Emma Goodspeed", 73000));
            Employees.Add(new Employee(14, "Helen Stafford", 97000));
            Employees.Add(new Employee(15, "Hector Whitman", 49000));
            Employees.Add(new Employee(16, "Jennifer Gibson", 102000));
            Employees.Add(new Employee(17, "Natosha Carter", 112000));
            Employees.Add(new Employee(18, "Kristen Thompson", 88000));
            Employees.Add(new Employee(19, "Grace Ward", 79000));
            Employees.Add(new Employee(20, "Chris Green", 91000));
        }

        public IEnumerable<Employee> GetEmployeesAsIEnumerable() 
        {             
            return Employees.AsEnumerable();
        }

        public IQueryable<Employee> GetEmployeesAsIQueryable()
        {
            return Employees.AsQueryable();        
        }

    }
}
