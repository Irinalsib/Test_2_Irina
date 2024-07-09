using System.Collections.Generic;
using System.Linq;

namespace Курсовая_Бухгалтерия.Model.Entities
{
    public class Registry
    {
        // список сотрудников
        private List<Person> persons;

        public Registry()
        {            
            PersonDataBase data = new PersonDataBase();
            persons = data.ReadAllPersons();    
            persons = persons.OrderBy(person => person.Salary).ToList();
        }

        // добавить сотрудника
        public void AddPerson(Person person)
        {
            persons.Add(person);
        }

        // удалить сотрудника
        public void RemovePerson(Person person)
        {
            persons.Remove(person);
        }        

        // получить всех сотрудников
        public List<Person> GetPersons()
        {
            return persons;
        }        
    }
}
