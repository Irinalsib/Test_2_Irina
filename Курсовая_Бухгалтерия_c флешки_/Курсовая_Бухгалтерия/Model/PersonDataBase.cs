using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Курсовая_Бухгалтерия.Model.Entities;

namespace Курсовая_Бухгалтерия.Model
{
    // класс для работы с базой данных о сотрудниках
    public class PersonDataBase
    {
        // путь к текстовому файлу
        private string databasePath = @"PersonDataBase.txt";

        // добавление сотрудника в текстовый файл
        public void AddPersonInDataBase(Person person)
        {
            // Создание потока для записи текста в файл (в режиме добавления текста в конец)
            using (FileStream fileStream = new FileStream(databasePath, FileMode.Append))
            {
                // создание строки с информацией о сотруднике
                string line = $"{person.Name}\t{person.SurName}\t{person.BirthDay}\t" +
                    $"{person.JobPos}\t{person.Salary}\n";
                // создание массива байтов из строки
                byte[] buffer = Encoding.UTF8.GetBytes(line);
                // запись в файл
                fileStream.Write(buffer, 0, buffer.Length);
            }
        }
        // чтение сотрудников из текстового файла
        public List<Person> ReadAllPersons()
        {
            // создание потока для чтения из файла в режиме Чтения
            using (FileStream fileStream = new FileStream(databasePath, FileMode.Open))
            {
                // пустой список людей, дальше заполнится
                List<Person> persons = new List<Person>();
                // массив байтов, заполняется из текстового документа
                byte[] buffer = new byte[fileStream.Length];
                fileStream.Read(buffer, 0, buffer.Length);
                // разделяем строку на фрагменты информации о сотрудниках разделителем - новой строкой
                string[] personData = Encoding.UTF8.GetString(buffer).Split('\n');                
                foreach (var data in personData)
                {
                    // разбиваем строку с информацией о острудниках разделителем - табуляцией
                    string[] splittedInfo = data.Split('\t');
                    if (splittedInfo.Length > 1)
                    {
                        // создаем сотрудника
                        Person person = new Person()
                        {
                            Name = splittedInfo[0],
                            SurName = splittedInfo[1],
                            BirthDay = DateTime.ParseExact(splittedInfo[2].Split(' ')[0],
                            "dd.MM.yyyy", CultureInfo.InvariantCulture),
                            JobPos = splittedInfo[3],
                            Salary = double.Parse(splittedInfo[4])
                        };
                        // вычисляем его возраст
                        person.UpdateAge();
                        // добавляем в список о сотрудниках
                        persons.Add(person);
                    }                    
                }
                // возвращаем список сотрудников
                persons = persons.OrderBy(person => person.Salary).ToList();
                return persons;
            }
        }
        // для обновления данных в базе при удалении/изменении сотрудников
        public void RefreshDataBase(List<Person> persons)
        {
            // обнуляем текущую базу путем перезаписывания текстового файла
            using (FileStream fileStream = new FileStream(databasePath, FileMode.Create))
            {
                byte[] buffer = new byte[0];
                fileStream.Write(buffer, 0, buffer.Length);
            }
            // добавляем информацию о сотрудниках в чистый файл
            foreach (var person in persons)
            {
                using (FileStream fileStream = new FileStream(databasePath, FileMode.Append))
                {
                    string line = $"{person.Name}\t{person.SurName}\t{person.BirthDay}\t{person.JobPos}\t{person.Salary}\n";
                    byte[] buffer = Encoding.UTF8.GetBytes(line);
                    fileStream.Write(buffer, 0, buffer.Length);
                }
            }
        }
    }
}
