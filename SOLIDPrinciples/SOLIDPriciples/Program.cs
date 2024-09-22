using SOLIDPriciples;
using static SOLIDPriciples.Employee;

Employee employee = new Employee() { EmployeeType = empType.FullTime.ToString(), TotalHoursWorked = 10 };
Employee employee2 = new Employee() { EmployeeType = empType.HalfTime.ToString(), TotalHoursWorked = 10 };

EmployeeFinances employeeFinances = new EmployeeFinanceForPTE();
Console.WriteLine(employeeFinances.CalculatePay(employee2));