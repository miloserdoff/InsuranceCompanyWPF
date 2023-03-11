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
    /// Страница добавление договора.
    /// </summary>
    public partial class AddEditDogovors : Page
    {
        strah_compEntities dataBase = new strah_compEntities();
        private dogovors _currentDogovor = new dogovors();
        private clients _currentClients = new clients();

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="selectedDogovor">Договор.</param>
        public AddEditDogovors(dogovors selectedDogovor)
        {
            InitializeComponent();
            
            if (selectedDogovor != null)
            {
                _currentDogovor = selectedDogovor;
            }

            DataContext = _currentDogovor;

            ComboType.ItemsSource = strah_compEntities.GetContext().type_of_str.ToList();
            ComboType.SelectedIndex = 0;
            ComboType.DisplayMemberPath = "name_type";
            ComboType.SelectedValuePath = "id";

            ComboFilials.ItemsSource = strah_compEntities.GetContext().fillials.ToList();
            ComboFilials.SelectedIndex = 0;
            ComboFilials.SelectedValuePath = "id";
            ComboFilials.DisplayMemberPath = "name_fill";

            ComboClients.ItemsSource = strah_compEntities.GetContext().clients.ToList();
            ComboClients.SelectedIndex = 0;
            ComboClients.SelectedValuePath = "id";
            ComboClients.DisplayMemberPath = "fio_cl";

            ComboSotrud.ItemsSource = strah_compEntities.GetContext().sotrud.ToList();
            ComboSotrud.SelectedIndex = 0;
            ComboSotrud.SelectedValuePath = "id";
            ComboSotrud.DisplayMemberPath = "fio_sotrud";
        }

        /// <summary>
        /// Кнопка "Сохранить"
        /// </summary>
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            
            StringBuilder errors = new StringBuilder();
            if (Convert.ToInt32(_currentDogovor.str_proc) < 1 || Convert.ToInt32(_currentDogovor.str_proc) > 70)
            {
                errors.AppendLine("Страховой процент должен быть от 1 до 70!");
            }
            if (Convert.ToInt32(_currentDogovor.str_pay) < 3500 || Convert.ToInt32(_currentDogovor.str_pay) > 10000)
            {
                errors.AppendLine("Страховая выплата должна быть от 3500 до 10000!");
            }
            if (string.IsNullOrWhiteSpace(_currentDogovor.date_start) || string.IsNullOrWhiteSpace(_currentDogovor.date_end))
            {
                errors.AppendLine("Не должно быть пустых полей!");
            }
            if (ComboSotrud.SelectedIndex == -1 || ComboClients.SelectedIndex == -1 || ComboFilials.SelectedIndex == -1 || ComboType.SelectedIndex == -1)
            {
                errors.AppendLine("Выберите значение!");
            }
            try 
            {
                DateTime.Parse(_currentDogovor.date_start);
            }
            catch (Exception)
            {
                errors.AppendLine("Дата начала введена неверно!");
            }

            try
            {
                DateTime.Parse(_currentDogovor.date_end);
            }
            catch (Exception)
            {
                errors.AppendLine("Дата окончания введена неверно!");
            }
            
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Ошибки!", MessageBoxButton.OK, MessageBoxImage.Warning);
                return; 
            }

            if (_currentDogovor.id == 0)
            {
                strah_compEntities.GetContext().dogovors.Add(_currentDogovor);
            }
            try
            {
                strah_compEntities.GetContext().SaveChanges();
                MessageBox.Show("Изменения сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString()); 
            }
        }

        /// <summary>
        /// ComboBox, выбранное значение
        /// </summary>
        private void ComboFilials_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        /// <summary>
        /// ComboBox, выбранное значение
        /// </summary>
        private void ComboClients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        /// <summary>
        /// ComboBox, выбранное значение
        /// </summary>
        private void ComboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        /// <summary>
        /// ComboBox, выбранное значение
        /// </summary>
        private void ComboSotrud_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
