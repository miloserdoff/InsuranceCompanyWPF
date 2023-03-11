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
    /// Страница добавления пользователя.
    /// </summary>
    public partial class AdmPage : Page
    {
        private users _currentUsers = new users();
        public AdmPage()
        {
            DataContext = _currentUsers;
            InitializeComponent();
        }

        /// <summary>
        /// Сохранить.
        /// </summary>
        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentUsers.login) || string.IsNullOrWhiteSpace(_currentUsers.password) || string.IsNullOrWhiteSpace(_currentUsers.email))
            {
                errors.AppendLine("Логин / пароль / email не должны быть пустыми!");
            }

            if (string.IsNullOrWhiteSpace(_currentUsers.dostup))
            {
                errors.AppendLine("Выберите уровень доступа!");
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Ошибки!", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (_currentUsers.id == 0)
            {
                strah_compEntities.GetContext().users.Add(_currentUsers);
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

        private void ComboDostup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
