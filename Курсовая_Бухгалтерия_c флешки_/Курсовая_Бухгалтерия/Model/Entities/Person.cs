using System;

namespace Курсовая_Бухгалтерия.Model.Entities
{
    public class Person
    {   
        public string Name { get; set; } // Имя сотрудника
        public string SurName { get; set; } // Фамилия сотрудника
        public DateTime BirthDay { get; set; } // Дата рождения сотрудника  
        public int Age { get; set; } // Возраст сотрудника
        public string JobPos { get; set; } // Должность
        public double Salary { get; set; }  // Зарплата

        public void UpdateAge()
        {
            DateTime today = DateTime.Today;
            Age = today.Year - BirthDay.Year;
            if (BirthDay.AddYears(Age) > today)
            {
                Age--;
            }            
        }
    }
}
