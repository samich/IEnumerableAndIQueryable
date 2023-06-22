using IEnumerableAndIQueryable;

Data data = new Data();


//Get Employees As IEnumerable
IEnumerable<Employee> e = data.GetEmployeesAsIEnumerable(); // e -> 20
IEnumerable<Employee> employeesWithHighSalary = e.Where(o => o.Salary > 100000); //e -> 4
Console.WriteLine(employeesWithHighSalary.Count());

//Get Employees As IEnumerable
IQueryable<Employee> e1 = data.GetEmployeesAsIQueryable(); //e1 -> 0
IQueryable<Employee> employeesWithHighSalary1 = e1.Where(o => o.Salary > 100000); //e1 -> 0
Console.WriteLine(employeesWithHighSalary1.Count()); //e1 -> 4
