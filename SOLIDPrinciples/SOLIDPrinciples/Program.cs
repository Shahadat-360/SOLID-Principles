using SOLIDPrinciples;
using Unity;
using static SOLIDPrinciples.Employee;

//Employee employee = new Employee(new DatabaseLogger()) { EmployeeType = empType.FullTime.ToString(), TotalHoursWorked = 10 };
//Employee employee2 = new Employee(new DatabaseLogger()) { EmployeeType = empType.HalfTime.ToString(), TotalHoursWorked = 10 };

//IEmployeeFinances employeeFinances = new EmployeeFinanceForPTE();
//Console.WriteLine(employeeFinances.CalculatePay(employee));
//Console.WriteLine(employeeFinances.CalculateRewards(employee));
//employee.Save(employee);

IUnityContainer unityContainer = new UnityContainer();
unityContainer.RegisterType<ILogger,FileLogger>();
unityContainer.RegisterType<ILogger,DatabaseLogger>();

Employee employee = unityContainer.Resolve<Employee>();
employee.Save(employee);