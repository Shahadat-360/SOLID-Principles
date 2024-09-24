using SOLIDPrinciples;
using static SOLIDPrinciples.Employee;

Employee employee = new Employee() { EmployeeType = empType.FullTime.ToString(), TotalHoursWorked = 10 };
Employee employee2 = new Employee() { EmployeeType = empType.HalfTime.ToString(), TotalHoursWorked = 10 };

IEmployeeFinances employeeFinances = new EmployeeFinanceForPTE();
Console.WriteLine(employeeFinances.CalculatePay(employee));
Console.WriteLine(employeeFinances.CalculateRewards(employee));