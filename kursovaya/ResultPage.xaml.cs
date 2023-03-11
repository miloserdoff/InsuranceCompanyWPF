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
    /// Вывод информации на печать.
    /// </summary>
    public partial class ResultPage : Page
    {
        private dogovors _currentDogovor = new dogovors();
        private clients _currentClients = new clients();

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="selectedDogovor">Выбранный договор.</param>
        public ResultPage(dogovors selectedDogovor)
        {
            InitializeComponent();

            if (selectedDogovor != null)
            {
                _currentDogovor = selectedDogovor;
            }

            DataContext = _currentDogovor;

            ShowType.ItemsSource = strah_compEntities.GetContext().type_of_str.ToList();
            ShowType.SelectedIndex = 0;
            ShowType.DisplayMemberPath = "name_type";
            ShowType.SelectedValuePath = "id";

            ShowFilial.ItemsSource = strah_compEntities.GetContext().fillials.ToList();
            ShowFilial.SelectedIndex = 0;
            ShowFilial.SelectedValuePath = "id";
            ShowFilial.DisplayMemberPath = "name_fill";

            ShowClient.ItemsSource = strah_compEntities.GetContext().clients.ToList();
            ShowClient.SelectedIndex = 0;
            ShowClient.SelectedValuePath = "id";
            ShowClient.DisplayMemberPath = "fio_cl";

            ShowSotrud.ItemsSource = strah_compEntities.GetContext().sotrud.ToList();
            ShowSotrud.SelectedIndex = 0;
            ShowSotrud.SelectedValuePath = "id";
            ShowSotrud.DisplayMemberPath = "fio_sotrud";

            PrintDialog printer = new PrintDialog();
            if (printer.ShowDialog() == true)
            {
                printer.PrintVisual(this, "Печать");
            }


        }

        private void ShowClient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ShowSotrud_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ShowType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ShowFilial_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
