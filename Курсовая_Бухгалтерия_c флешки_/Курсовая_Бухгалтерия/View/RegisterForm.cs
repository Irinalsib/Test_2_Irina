using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Курсовая_Бухгалтерия.Model;
using Курсовая_Бухгалтерия.Model.Entities;

namespace Курсовая_Бухгалтерия.View
{
    // окно с ведомостью
    public partial class RegisterForm : Form
    {
        // ссылка на реестр
        private Register register;
        // ссылка на список сотрудников
        private List<Person> persons;
        // список сотрудников для привязки к таблице
        private BindingList<Person> registerPersons;
        // информация о сотруднике с максимальным окладом
        private string maxEmployeeInfo;
        private double averageSalary;
        public RegisterForm(List<Person> persons)
        {
            InitializeComponent();
            this.persons = persons;
            averageSalary = persons.Select(item => item.Salary).Average();
            label1.Text = averageSalary.ToString();
        }
        private void DataViewButton_Click(object sender, EventArgs e)
        {
            // переход в окно с данными
            new Thread(() => { Application.Run(new DataViewForm() { StartPosition = FormStartPosition.CenterScreen }); }) { ApartmentState = ApartmentState.STA}.Start();
            this.Close();
        }
        private void ArrangeSalaryByBonus()
        {
            // расчет ЗП с премией и налогом 13 процентов
            foreach (var person in persons)
            {
                double tax = (person.Salary + register.BonusSalary) * 0.13;
                person.Salary = (person.Salary + register.BonusSalary) - tax;
            }
        }
        private void ArrangeEmployyWithMaxSalary()
        {
            // расчёт сотрудника с макс. окладом
            double maxSalary = persons.Max(x => x.Salary);
            Person personWithMaxSalary = persons.FirstOrDefault(x => x.Salary ==  maxSalary);
            string info = $"Имя: {personWithMaxSalary.Name}\nФамилия: {personWithMaxSalary.SurName}\nДолжность: {personWithMaxSalary.JobPos}\nЗарплата: {personWithMaxSalary.Salary}";
            maxEmployeeInfo = info;
            BestWorkerRichTextBox.Text = info;
        }
        private void CreateRegister()
        {
            // создание ведомости
            register = new Register(SalaryDatePicker.Value, double.Parse(BonusSalaryTextBox.Text));
        }
        private void CreateRegisterButton_Click(object sender, EventArgs e)
        {
            // создание ведемости (нажатие на кнопку)
            if (!string.IsNullOrEmpty(BonusSalaryTextBox.Text) && SalaryDatePicker.Value != default)
            {
                CreateRegister();
                ArrangeSalaryByBonus();
                ArrangeEmployyWithMaxSalary();
                registerPersons = new BindingList<Person>(persons.OrderByDescending(person => person.Salary).ToList());
                RegisterDataGrid.DataSource = registerPersons;
                EmployeesCountLabel.Text = $"Количество сотрудников: {registerPersons.Count}";
                RegisterDataGrid.Columns[0].HeaderText = "Имя сотрудника";
                RegisterDataGrid.Columns[1].HeaderText = "Фамилия сотрудника";
                RegisterDataGrid.Columns[2].HeaderText = "Дата рождения сотрудника";
                RegisterDataGrid.Columns[3].HeaderText = "Возраст сотрудника";
                RegisterDataGrid.Columns[4].HeaderText = "Должность сотрудника";
                RegisterDataGrid.Columns[5].HeaderText = "Зарплата сотрудника";
            }
        }
        private void CreateReportButton_Click(object sender, EventArgs e)
        {
            // создание отчёта текстового
            if (!string.IsNullOrEmpty(BonusSalaryTextBox.Text) && SalaryDatePicker.Value != default &&
                registerPersons != null && BonusSalaryTextBox.Text != "Размер премии")
            {
                TxtReportWriter writer = new TxtReportWriter(SalaryDatePicker.Value, maxEmployeeInfo,
                    registerPersons.ToList());
                writer.CreateTextReport();
                MessageBox.Show("Текстовый отчёт создан", "Уведомление", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
        }
        private void CreateExcelReportButton_Click(object sender, EventArgs e)
        {
            // создание отчёта excel
            if (registerPersons != null)
            {
                ExcelReportWriter writer = new ExcelReportWriter(registerPersons.ToList());
                writer.CreateExcelReport();                
            }
        }
        private void BonusSalaryTextBox_Click(object sender, EventArgs e)
        {
            BonusSalaryTextBox.Text = string.Empty;
        }
        private void BonusSalaryTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BonusSalaryTextBox.Text))
            {
                BonusSalaryTextBox.Text = "Размер премии";
            }            
        }
        private void BonusSalaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
    }
}
