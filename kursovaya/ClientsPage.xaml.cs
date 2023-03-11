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
    /// Страница клиента.
    /// </summary>
    public partial class ClientsPage : Page
    {
        /// <summary>
        /// Конструктор класса.
        /// </summary>
        public ClientsPage()
        {
            InitializeComponent();
            DGridClients.ItemsSource = strah_compEntities.GetContext().clients.ToList();
        }

        private void btnEditClients_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
