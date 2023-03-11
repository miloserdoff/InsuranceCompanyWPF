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
    /// Главное меню.
    /// </summary>
    public partial class MainMenu : Window
    {
        /// <summary>
        /// Констурктор класса.
        /// </summary>
        public MainMenu()
        {
            InitializeComponent();
            if (Datas._dostup < 3)
            {
                btnAdmin.Visibility = Visibility.Hidden;
            }
            MainFrame.Navigate(new DogovorsPage());
            Manager.MainFrame = MainFrame;
        }

        /// <summary>
        /// Назад.
        /// </summary>
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        /// <summary>
        /// Видимость кнопки "Назад"
        /// </summary>
        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                btnBack.Visibility = Visibility.Visible;
            }
            else
            {
                btnBack.Visibility = Visibility.Hidden;
            }
        }

        /// <summary>
        /// Переход на страницу договоров.
        /// </summary>
        private void btnDogovors_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new DogovorsPage());
            Manager.MainFrame = MainFrame;
        }

        /// <summary>
        /// Переход на страницу клиентов.
        /// </summary>
        private void btnClients_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ClientsPage());
            Manager.MainFrame = MainFrame;
        }

        /// <summary>
        /// Переход на страницу сотрудников.
        /// </summary>
        private void btnSotrud_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new SotrudPage());
            Manager.MainFrame = MainFrame;
        }

        /// <summary>
        /// Переход на страницу типов страхования.
        /// </summary>
        private void btnTypes_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TypesPage());
            Manager.MainFrame = MainFrame;
        }

        /// <summary>
        /// Переход на страницу филиалов.
        /// </summary>
        private void btnFilials_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new FilialsPage());
            Manager.MainFrame = MainFrame;
        }

        /// <summary>
        /// Переход на страницу админ-панели.
        /// </summary>
        private void btnAdmin_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AdmPage());
            Manager.MainFrame = MainFrame;
        }
    }
}
