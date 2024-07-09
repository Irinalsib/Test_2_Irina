using System;
using System.Threading;
using System.Windows.Forms;

namespace Курсовая_Бухгалтерия
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }      
        private void button2_Click(object sender, EventArgs e)
        {
            // Открытие окна с информацией путем создания нового потока
            new Thread(() => Application.Run(new InformationForm() { StartPosition = FormStartPosition.CenterScreen })) { ApartmentState = ApartmentState.STA}.Start();
            this.Close();
        }  
        private void ExitButton_Click(object sender, EventArgs e)
        {
            // выход
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }                        
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            // Открываем окно с базой данных о сотрудниках путем создания нового потока
            new Thread(() => Application.Run(new DataViewForm() { StartPosition = FormStartPosition.CenterScreen })) { ApartmentState = ApartmentState.STA }.Start();
            this.Close();
        }
        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
