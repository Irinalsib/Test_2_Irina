using System;
using System.Threading;
using System.Windows.Forms;

namespace Курсовая_Бухгалтерия
{
    public partial class InformationForm : Form
    {
        public InformationForm()
        {
            InitializeComponent();
        }                        

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            // Открытие главного окна. Для этого создаём отдельные поток и запускаем его. После чего уничтожаем старый поток.
            new Thread(() =>{ Application.Run(new MainMenuForm() { StartPosition = FormStartPosition.CenterScreen }); }) { ApartmentState = ApartmentState.STA }.Start();            
            this.Close();            
        }
    }
}
