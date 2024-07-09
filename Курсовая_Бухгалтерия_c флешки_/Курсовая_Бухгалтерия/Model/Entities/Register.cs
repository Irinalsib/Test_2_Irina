using System;

namespace Курсовая_Бухгалтерия.Model.Entities
{
    // класс - ведомость    
    public class Register
    {                
        // дата зарплаты
        public DateTime SalaryDate { get; set; }
        // размер премии
        public double BonusSalary { get; set; }

        public Register(DateTime salaryDate, double bonusSalary)
        {            
            SalaryDate = salaryDate;
            BonusSalary = bonusSalary;
        }
    }
}
