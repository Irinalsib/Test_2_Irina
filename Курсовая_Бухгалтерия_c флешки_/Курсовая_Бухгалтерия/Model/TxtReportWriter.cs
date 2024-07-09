using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Курсовая_Бухгалтерия.Model.Entities;

namespace Курсовая_Бухгалтерия.Model
{
    // класс создания отчёта в текстовый файл
    public class TxtReportWriter
    {
        // дата зарплаты
        private DateTime salaryDate;
        // лучший сотрудник ( с макс ЗП )
        private string maxSalaryEmployeeInfo;
        // сотрудники
        private List<Person> persons;
        // путь к текстовому файлу
        private string reportPath = "Report.txt";

        public TxtReportWriter(DateTime salaryDate, string MaxSalaryEmployeeInfo, List<Person> persons)
        {
            this.salaryDate = salaryDate;
            maxSalaryEmployeeInfo = MaxSalaryEmployeeInfo;
            this.persons = persons;
        }

        public void CreateTextReport()
        {
            // Создаем текстовый файл - отчёт или перезаписываем
            using (FileStream fileStream = new FileStream(reportPath, FileMode.Create))
            {
                byte[] buffer = new byte[0];
                fileStream.Write(buffer, 0, buffer.Length);
            }
            // Добавляем информацию о дате зарплаты
            using (FileStream fileStream = new FileStream(reportPath, FileMode.Append))
            {
                string dateInfo = "Дата зарплаты:" + salaryDate.ToString() + '\n';
                byte[] buffer = Encoding.UTF8.GetBytes(dateInfo);
                fileStream.Write(buffer, 0, buffer.Length);
            }
            // Добавляем информацию о сотруднике с макс ЗП
            using (FileStream fileStream = new FileStream(reportPath, FileMode.Append))
            {
                string maxEmployeeInfo = maxSalaryEmployeeInfo.ToString() + '\n';
                byte[] buffer = Encoding.UTF8.GetBytes(maxEmployeeInfo);
                fileStream.Write(buffer, 0, buffer.Length);
            }
            // Добавляем информацию о сотрудниках
            foreach (var person in persons)
            {
                using (FileStream fileStream = new FileStream(reportPath, FileMode.Append))
                {
                    string line = $"{person.Name}\t{person.SurName}\t{person.BirthDay}\t{person.JobPos}\t{person.Salary}\n";
                    byte[] buffer = Encoding.UTF8.GetBytes(line);
                    fileStream.Write(buffer, 0, buffer.Length);
                }
            }
        }
    }
}
