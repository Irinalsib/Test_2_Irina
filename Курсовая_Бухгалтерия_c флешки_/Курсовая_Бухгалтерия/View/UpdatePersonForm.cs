using System;
using System.Windows.Forms;
using Курсовая_Бухгалтерия.Model;
using Курсовая_Бухгалтерия.Model.Entities;

namespace Курсовая_Бухгалтерия.View
{
    public partial class UpdatePersonForm : Form
    {
        private Person person;
        private Registry registry;        

        public UpdatePersonForm(Person person, Registry registry)
        {
            InitializeComponent();
            this.person = person;
            this.registry = registry;
            PersonNameTextBox.Text = person.Name;
            PersonSurNameTextBox.Text = person.SurName;
            PersonJobPosTextBox.Text = person.JobPos;
            PersonSalaryTextBox.Text = person.Salary.ToString();
            PersonBirthDayPicker.Value = person.BirthDay;
        }
        public void UpdatePerson()
        {
            // изменяем информацию о сотруднике
            Person newPerson = new Person()
            {
                Name = PersonNameTextBox.Text,
                SurName = PersonSurNameTextBox.Text,
                JobPos = PersonJobPosTextBox.Text,
                Salary = double.Parse(PersonSalaryTextBox.Text),
                BirthDay = PersonBirthDayPicker.Value,
            };
            // изменяем информацию о сотруднике в реестре
            int index = registry.GetPersons().IndexOf(person);
            registry.GetPersons()[index] = newPerson;
            // изменяем информацию о сотруднике в базе
            PersonDataBase dataBase = new PersonDataBase();
            dataBase.RefreshDataBase(registry.GetPersons());
        }
        private void UpdatePersonButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(PersonNameTextBox.Text) && !string.IsNullOrWhiteSpace(PersonSurNameTextBox.Text) && !string.IsNullOrWhiteSpace(PersonJobPosTextBox.Text)
                && !string.IsNullOrWhiteSpace(PersonSalaryTextBox.Text) && PersonBirthDayPicker.Value != default)
            {
                UpdatePerson();
                MessageBox.Show("Данные о сотруднике изменены", "Уведомление",  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void CloseWindowButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PersonSalaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // чтобы вводить только текстовые данные
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
    }
}
