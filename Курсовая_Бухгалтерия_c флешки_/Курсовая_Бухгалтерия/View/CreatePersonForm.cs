using System.Windows.Forms;
using Курсовая_Бухгалтерия.Model;
using Курсовая_Бухгалтерия.Model.Entities;

namespace Курсовая_Бухгалтерия.View
{
    // окно для создания нового сотрудника
    public partial class CreatePersonForm : Form
    {
        // ссылка на реестр сотрудников
        private Registry registry;
        // ссылка на базу данных сотрудников
        private PersonDataBase dataBase;
        public CreatePersonForm(Registry registry)
        {
            InitializeComponent();            
            this.registry = registry;
            dataBase = new PersonDataBase();
        }
        public void CreatePerson()
        {
            if (!string.IsNullOrWhiteSpace(PersonNameTextBox.Text) && !string.IsNullOrWhiteSpace(PersonSurNameTextBox.Text) 
                && !string.IsNullOrWhiteSpace(PersonJobPosTextBox.Text)
                && !string.IsNullOrWhiteSpace(PersonSalaryTextBox.Text) && PersonBirthDayPicker.Value != default
                && PersonNameTextBox.Text != "Имя сотрудника" && PersonSurNameTextBox.Text != "Фамилия сотрудника" 
                && PersonJobPosTextBox.Text != "Должность сотрудника"
                && PersonSalaryTextBox.Text != "Зарплата сотрудника")
            {
                // создаем сотрудника
                Person person = new Person()
                {
                    Name = PersonNameTextBox.Text,
                    SurName = PersonSurNameTextBox.Text,
                    JobPos = PersonJobPosTextBox.Text,
                    Salary = double.Parse(PersonSalaryTextBox.Text),
                    BirthDay = PersonBirthDayPicker.Value,
                };
                // добавляем в реестр
                registry.AddPerson(person);
                // добавляем в базу данных
                dataBase.AddPersonInDataBase(person);
                MessageBox.Show("Сотрудник создан и записан в базу", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ошибка в вводе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CreatePersonButton_Click(object sender, System.EventArgs e)
        {
            CreatePerson();
        }
        private void CloseWindowButton_Click(object sender, System.EventArgs e)
        {            
            this.Close();
        }
        private void PersonSalaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // чтобы в поле с ЗП можно было вводить только числа или десятичные числа
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
        // для полей, чтобы при нажатии оно становилось пустым для ввода, а когда убираем с фокуса - стандартное значение
        private void PersonNameTextBox_Click(object sender, System.EventArgs e)
        {
            PersonNameTextBox.Text = string.Empty;
        }
        private void PersonNameTextBox_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PersonNameTextBox.Text))
            {
                PersonNameTextBox.Text = "Имя сотрудника";
            }            
        }
        private void PersonSurNameTextBox_Click(object sender, System.EventArgs e)
        {            
            PersonSurNameTextBox.Text = string.Empty;
        }
        private void PersonSurNameTextBox_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PersonSurNameTextBox.Text))
            {
                PersonSurNameTextBox.Text = "Фамилия сотрудника";
            }            
        }
        private void PersonJobPosTextBox_Click(object sender, System.EventArgs e)
        {
            PersonJobPosTextBox.Text = string.Empty;
        }
        private void PersonJobPosTextBox_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PersonJobPosTextBox.Text))
            {
                PersonJobPosTextBox.Text = "Должность сотрудника";
            }            
        }
        private void PersonSalaryTextBox_Click(object sender, System.EventArgs e)
        {
            PersonSalaryTextBox.Text = string.Empty;
        }
        private void PersonSalaryTextBox_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PersonSalaryTextBox.Text))
            {
                PersonSalaryTextBox.Text = "Зарплата сотрудника";
            }            
        }
    }
}
