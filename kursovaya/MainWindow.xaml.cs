using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace kursovaya
{
    /// <summary>
    /// Авторизация.
    /// </summary>
    public partial class MainWindow : Window
    {
        strah_compEntities dataBase = new strah_compEntities();
        /// <summary>
        /// Конструктор класса.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            // mm.Show();
        }

        /// <summary>
        /// Авторизация.
        /// </summary>
        private void btnAuth_Click(object sender, RoutedEventArgs e)
        {
            if(dataBase.users.Any(u => u.login == LoginTextBox.Text && u.password == PasswordTextBox.Text))
            {
                var datas = dataBase.users.Where(p => p.login == LoginTextBox.Text);

                foreach (var data in datas)
                {
                    Datas._dostup = Convert.ToInt32(data.dostup);
                }

                MessageBox.Show("Успешный вход в систему!", "Успех!", MessageBoxButton.OK, MessageBoxImage.Information);
                MainMenu mm = new MainMenu();
                mm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка!\nНеверные данные!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
