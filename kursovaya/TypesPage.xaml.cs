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
    /// Страница типов страхования.
    /// </summary>
    public partial class TypesPage : Page
    {
        /// <summary>
        /// Конструктор класса.
        /// </summary>
        public TypesPage()
        {
            InitializeComponent();
            DGridTypes.ItemsSource = strah_compEntities.GetContext().type_of_str.ToList();
        }

        /// <summary>
        /// Изменить.
        /// </summary>
        private void btnEditTypes_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
