using System;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Курсовая_Бухгалтерия.Model;
using Курсовая_Бухгалтерия.Model.Entities;
using Курсовая_Бухгалтерия.View;

namespace Курсовая_Бухгалтерия
{
    // окно для представления данных
    public partial class DataViewForm : Form
    {
        // ссылка на реестр
        private Registry registry;
        // список сотрудников для привязки к таблице
        private BindingList<Person> persons;
        // выбранная строка с сотрудником (из таблицы)
        private Person selectedPerson;
        public DataViewForm()
        {
            InitializeComponent();
            registry = new Registry();                        
            persons = new BindingList<Person>(registry.GetPersons().OrderByDescending(person => person.Salary).ToList());            
            RegistryGridView.DataSource = persons;
            RegistryGridView.Columns[0].HeaderText = "Имя сотрудника";
            RegistryGridView.Columns[1].HeaderText = "Фамилия сотрудника";
            RegistryGridView.Columns[2].HeaderText = "Дата рождения сотрудника";
            RegistryGridView.Columns[3].HeaderText = "Возраст сотрудника";
            RegistryGridView.Columns[4].HeaderText = "Должность сотрудника";
            RegistryGridView.Columns[5].HeaderText = "Зарплата сотрудника";
        }
        private void MainMenuButton_Click_1(object sender, EventArgs e)
        {
            // переход в главное окно программы через создание нового потока
            new Thread(() => Application.Run(new MainMenuForm() { StartPosition = FormStartPosition.CenterScreen })) { ApartmentState = ApartmentState.STA }.Start();
            this.Close();
        }
        private void CreateButton_Click(object sender, EventArgs e)
        {
            CreatePersonForm form = new CreatePersonForm(registry) { StartPosition = FormStartPosition.CenterScreen };
            form.ShowDialog();
            RefreshTable();
        }
        private void RefreshTable()
        {
            // обновление таблицы при изменении
            persons = new BindingList<Person>(registry.GetPersons().OrderByDescending(person => person.Salary).ToList());
            RegistryGridView.DataSource = persons;
        }
        private void RegistryGridView_SelectionChanged(object sender, EventArgs e)
        {
            // выбор сотрудника (строки из таблицы)
            if (RegistryGridView.SelectedRows.Count > 0)
            {
                selectedPerson = RegistryGridView.SelectedRows[0].DataBoundItem as Person;                
            }            
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // удаление сотрудника из таблицы и обновление таблицы
            if (selectedPerson != null)
            {
                registry.GetPersons().Remove(selectedPerson);
                RefreshTable();
                PersonDataBase dataBase = new PersonDataBase();
                dataBase.RefreshDataBase(persons.ToList());
            }
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // обновление сотрудника из таблицы и обновление таблицы
            if (selectedPerson != null)
            {
                UpdatePersonForm form = new UpdatePersonForm(selectedPerson, registry) { StartPosition = FormStartPosition.CenterScreen };
                form.ShowDialog();
                RefreshTable();
            }
        }
        private void OpenRegistryButton_Click(object sender, EventArgs e)
        {
            // открыть окно с ведомостью
            new Thread(() => { Application.Run(new RegisterForm(persons.ToList()) { StartPosition = FormStartPosition.CenterScreen }); }) { ApartmentState = ApartmentState.STA }.Start();
            this.Close();
        }
    }
}
