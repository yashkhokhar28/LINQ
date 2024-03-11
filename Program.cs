using LINQ;
using static System.Runtime.InteropServices.JavaScript.JSType;

var context = new ApplicationDBContext();
//For example, Display FirstName of all employees.
var q1 = context.Employee.Select(x => x.FirstName);
foreach (var employee in q1)
{
    Console.WriteLine("\n {0}", employee);
}

// 1.Display data of all employees.
var q2 = context.Employee.Select(x => x.FirstName + " " + x.LastName + " " + x.Gender + " " + x.Salary + " " + x.JoiningDate + " " + x.AccountNo);
foreach (var employee in q2)
{
    Console.WriteLine("\n {0}", employee);
}

//2. Select ActNo, FirstName and Salary of all employees to a new class and display it.
var q3 = context.Employee.Select(x => new Employee() { AccountNo = x.AccountNo, FirstName = x.FirstName, Salary = x.Salary }).ToList();
foreach (var employee in q3)
{
    Console.WriteLine("\nAccountNo: {0}, FirstName: {1}, Salary: {2}", employee.AccountNo, employee.FirstName, employee.Salary);
}

//3.Display data in following format => {Anil} works in {Admin} Department.
var q4 = context.Employee.Select(x => x.FirstName + " works in " + x.Department + " Department");
foreach (var employee in q4)
{
    Console.WriteLine("\n {0}", employee);
}


//4.Select Employee Full Name, Email and Department as anonymous and display it.
var q5 = context.Employee.Select(x => new { ActNo = x.AccountNo, FN = x.FirstName, Salary = x.Salary }).ToList();
foreach (var employee in q5)
{
    Console.WriteLine("\n {0}", employee);
}

//5. Display employees with their joining date.
var q6 = context.Employee.Select(x => x.FirstName + " " + x.LastName + " " + x.JoiningDate);
foreach (var employee in q6)
{
    Console.WriteLine("\n {0}", employee);
}