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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kursovaya
{
    /// <summary>
    /// Interaction logic for AddEditClient.xaml
    /// </summary>
    public partial class AddEditClient : Page
    {
        private clients _currentClients = new clients();
        public AddEditClient()
        {
            DataContext = _currentClients;
            InitializeComponent();
        }

        private void btnSaveClient_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentClients.fio_cl) || string.IsNullOrWhiteSpace(_currentClients.phone_number) || string.IsNullOrWhiteSpace(_currentClients.address) || string.IsNullOrWhiteSpace(_currentClients.inn) || string.IsNullOrWhiteSpace(_currentClients.snills) || string.IsNullOrWhiteSpace(_currentClients.passport))
            {
                errors.AppendLine("Заполните все поля!");
            }
            if (PassportTextBox.Text.Length != 10)
            {
                errors.AppendLine("В паспорте должно быть 10 цифр!");
            }
            if (SnillsTextBox.Text.Length != 11)
            {
                errors.AppendLine("В СНИЛС должно быть 11 цифр!");
            }
            if (InnTextBox.Text.Length != 12)
            {
                errors.AppendLine("В ИНН должно быть 12 цифр!");
            }
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentClients.id == 0)
            {
                strah_compEntities.GetContext().clients.Add(_currentClients);
            }
            try
            {
                strah_compEntities.GetContext().SaveChanges();
                MessageBox.Show("Новая запись создана!", "Успех!", MessageBoxButton.OK, MessageBoxImage.Information);
                Manager.MainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
        }
    }
}
