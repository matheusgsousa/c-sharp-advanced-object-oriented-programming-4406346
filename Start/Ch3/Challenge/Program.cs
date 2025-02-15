// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Challenge: create a class hierarchy to represent employees

var Emp1 = new HourlyEmployee() {ID=1000,FullName="John Doe", Department="Sales", PayRate=35.0m};
var Emp2 = new SalariedEmployee() {ID=1001, FullName="Jane Deaux", Department="Marketing", Salary=75000.0m};

Console.WriteLine($"Count: {Employee.EmployeeCount}");

var Emp3 = new SalariedEmployee() {ID=1002, FullName="Jenny Doh", Department="Engineering", Salary=95000.0m};
Console.WriteLine($"Count: {Employee.EmployeeCount}");

var Emp4 = new HourlyEmployee() {ID=1003, FullName="Jim Dough", Department="Tech Support", PayRate=45.0m};
Console.WriteLine($"Count: {Employee.EmployeeCount}");

Console.WriteLine($"{Emp1}");
Console.WriteLine($"{Emp2}");
Console.WriteLine($"{Emp3}");
Console.WriteLine($"{Emp4}");
