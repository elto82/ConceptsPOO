using ConceptsPOO;

Console.WriteLine("Concepts POO");
Console.WriteLine("================");

Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "sandra",
    LastName = "morales",
    BirthDade = new Date(1983, 5, 23),
    HiringDate = new Date(2022, 1, 3),
    IsActive = true,
    Salary = 1200000
};

//Console.WriteLine(employee1);


Employee employee2 = new CommissionEmployee()
{
    Id = 2010,
    FirstName = "lucas",
    LastName = "peres",
    BirthDade = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 3),
    IsActive = true,
    Sales = 320000000M,
    CommissionPercentaje = 0.03F,
};

//Console.WriteLine(employee2);

Employee employee3 = new HourlyEmployee()
{
    Id = 3010,
    FirstName = "Matheo",
    LastName = "jaramillo",
    BirthDade = new Date(2000, 5, 23),
    HiringDate = new Date(2018, 1, 3),
    IsActive = true,
    HourValue = 12356.56M,
    Hours = 123.5F
};

//Console.WriteLine(employee3);

Employee employee4 = new BaseCommissionEmployee()
{
    Id = 3010,
    FirstName = "antonio",
    LastName = "arias",
    BirthDade = new Date(2000, 5, 23),
    HiringDate = new Date(2018, 1, 3),
    IsActive = true,
    Sales = 10000000M,
    CommissionPercentaje = 0.015F,
    Base = 1200000

};

//Console.WriteLine(employee4);

//ICollection<Employee> employees = new List<Employee>();
//employees.Add(employee1);
//employees.Add(employee2);
//employees.Add(employee3);
//employees.Add(employee4);

ICollection<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3, employee4
};

decimal payroll = 0;

foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
    
}

Console.WriteLine("               ===============");

Console.WriteLine($"TOTAL.........................:{$"{payroll:C2}",18}");

Invoice invoice1 = new Invoice()
{
    Description = "iphone 13",
    Id = 1,
    Price = 5300000M,
    Quantity = 6
};

Invoice invoice2 = new Invoice()
{
    Description = "posta premium",
    Id = 2,
    Price = 32000,
    Quantity =17.5F
};

Console.WriteLine(invoice1);
Console.WriteLine(invoice2);
