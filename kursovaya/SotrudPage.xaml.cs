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
    /// Страница сотрудников.
    /// </summary>
    public partial class SotrudPage : Page
    {
        /// <summary>
        /// Конструктор класса.
        /// </summary>
        public SotrudPage()
        {
            InitializeComponent();
            DGridSotrud.ItemsSource = strah_compEntities.GetContext().sotrud.ToList();
        }

        /// <summary>
        /// Сохранить.
        /// </summary>
        private void btnEditSotrud_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
