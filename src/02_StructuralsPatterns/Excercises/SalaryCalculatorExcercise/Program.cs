using SalaryCalculatorExcercise;


// TODO: Dodaj premię za udział w szkoleniu. Pamiętaj, że pracownik mógł brać udział w kilku szkoleniach.

SalaryCalculator salaryCalculator = new SalaryCalculator(50, 1000);

Employee employee = new JuniorDeveloper { OvertimeSalary = TimeSpan.FromHours(2), NumberOfProjects = 1 };

decimal salary = salaryCalculator.CalculateSalary(employee);

Console.WriteLine(salary);



