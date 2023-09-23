namespace SalaryCalculatorExcercise;

public class SalaryCalculator
{
    private readonly decimal amountPerHour;
    private readonly decimal bonusPerProject;

    public SalaryCalculator(decimal amountPerHour, decimal bonusPerProject)
    {
        this.amountPerHour = amountPerHour;
        this.bonusPerProject = bonusPerProject;
    }

    public decimal CalculateSalary(Employee employee)
    {
        // pensja zasadnicza
        decimal baseSalary = employee.GetBaseSalary();

        // premia za nadgodziny
        var salary = baseSalary + (decimal) employee.OvertimeSalary.TotalHours * amountPerHour;

        // premia za oddanie każdego projektu
        for (int i = 0; i < employee.NumberOfProjects; i++)
        {
            salary += bonusPerProject;
        }

        // TODO: premia za udział w szkoleniu        

        return salary;           
       
    }
}
