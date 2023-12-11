try
{
 Console.Write("Введите количество сотрудников: ");
    int employeeсount = int.Parse(Console.ReadLine());

    Employee[] employees = new Employee[employeeсount];

    for (int i = 0; i < employeeсount; i++)
    {
        Console.WriteLine($"Введите информацию о {i+1} сотруднике:");
        Console.Write("Имя: ");
        string name = Console.ReadLine();
        Console.Write("Фамилия: ");
        string surname = Console.ReadLine();
        Console.Write("Отчество: ");
        string patronymic = Console.ReadLine();
        Console.Write("Должность: ");
        string jobTitle = Console.ReadLine();
        Console.Write("Зарплата: ");
        decimal salary = decimal.Parse(Console.ReadLine());
        Console.Write("Дата рождения (гггг-мм-дд): ");
        DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());

        employees[i] = new Employee(name, surname, patronymic, jobTitle, salary, dateOfBirth);
    }

    Employee youngestEmployee = GetYoungestEmployee(employees);

    Console.WriteLine("самый молодой сотрудник:");
    Console.WriteLine("Имя: " + youngestEmployee.Name);
    Console.WriteLine("Фамилия: " + youngestEmployee.Surname);
    Console.WriteLine("Отчество: " + youngestEmployee.Patronymic);
    Console.WriteLine("Должность: " + youngestEmployee.JobTitle);
    Console.WriteLine("Зарплата: " + youngestEmployee.Salary);
    Console.WriteLine("Дата рождения: " + youngestEmployee.DateOfBirth.ToShortDateString());
}



catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
   
static Employee GetYoungestEmployee(Employee[] employees)
{
    Employee youngest = employees[0];
    foreach (var employee in employees)
    {
        if (employee.DateOfBirth > youngest.DateOfBirth)
        {
            youngest = employee;
        }
    }
    return youngest;
}

public struct Employee
{
    public string Name;
    public string Surname;
    public string Patronymic;
    public string JobTitle;
    public decimal Salary;
    public DateTime DateOfBirth;

    public Employee(string name, string surname, string patronymic, string jobTitle, decimal salary, DateTime dateOfBirth)
    {
        Name = name;
        Surname = surname;
        Patronymic = patronymic;
        JobTitle = jobTitle;
        Salary = salary;
        DateOfBirth = dateOfBirth;
    }
}