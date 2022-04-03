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

Console.WriteLine(employee1);


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

Console.WriteLine(employee2);

