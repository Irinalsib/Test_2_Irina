using System;
using System.Collections.Generic;

namespace Курсовая_Бухгалтерия.Model.Entities
{
    // класс для записи файла в эксель
    internal class ExcelReportWriter
    {
        // список людей
        private List<Person> persons;

        // инициализация списка людей
        public ExcelReportWriter(List<Person> persons)
        {
            this.persons = persons;
        }

        // запись в эксель
        public void CreateExcelReport()
        {
            // создание экземпляра класса ApplicationClass для работы с Excel
            Microsoft.Office.Interop.Excel.ApplicationClass MExcel = 
                new Microsoft.Office.Interop.Excel.ApplicationClass();
            // Добавление книги
            MExcel.Application.Workbooks.Add(Type.Missing);
            // Добавление столбцов
            MExcel.Cells[1, 1] = "Имя сотрудника";
            MExcel.Cells[1, 2] = "Фамилия сотрудника";
            MExcel.Cells[1, 3] = "Должность сотрудника";
            MExcel.Cells[1, 4] = "Зарплата сотрудника";
            // Первая строка в excel после заголовков столбцов
            int row = 2;
            // запись данных
            foreach (var person in persons)
            {
                MExcel.Cells[row, 1] = person.Name;
                MExcel.Cells[row, 2] = person.SurName;
                MExcel.Cells[row, 3] = person.JobPos;
                MExcel.Cells[row, 4] = person.Salary;
                row++;
            }            
            // Растягивание колонок по размеру текста в них
            MExcel.Columns.AutoFit();
            // Растягивание строк по размеру текста в них
            MExcel.Rows.AutoFit();
            // Размер шрифта
            MExcel.Columns.Font.Size = 12;
            // Включаем excel после успешной записи
            MExcel.Visible = true;
        }
    }
}
