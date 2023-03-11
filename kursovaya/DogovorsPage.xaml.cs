using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
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
    /// Страница договоров.
    /// </summary>
    public partial class DogovorsPage : Page
    {

        /// <summary>
        /// Страница договоров.
        /// </summary>
        public DogovorsPage()
        {
            InitializeComponent();

            if (Datas._dostup < 2)
            {
                btnAdd.Visibility = Visibility.Hidden;
                btnAddClient.Visibility = Visibility.Hidden;
                btnDelete.Visibility = Visibility.Hidden;
                
            }

            var allTypes = strah_compEntities.GetContext().type_of_str.ToList();
            allTypes.Insert(0, new type_of_str { name_type = "Все типы" });
            ComboTypeSearch.ItemsSource = allTypes;
            ComboTypeSearch.SelectedIndex = 0;
            ComboTypeSearch.SelectedValue = "id";
            ComboTypeSearch.DisplayMemberPath = "name_type";

            var allFilias = strah_compEntities.GetContext().fillials.ToList();
            allFilias.Insert(0, new fillials { name_fill = "Все филиалы" });
            ComboFilialSearch.ItemsSource = allFilias;
            ComboFilialSearch.SelectedIndex = 0;
            ComboFilialSearch.SelectedValue = "id";
            ComboFilialSearch.DisplayMemberPath = "name_fill";

            var allSotrud = strah_compEntities.GetContext().sotrud.ToList();
            allSotrud.Insert(0, new sotrud { fio_sotrud = "Все сотрудники" });
            ComboSotrudSearch.ItemsSource = allSotrud;
            ComboSotrudSearch.SelectedIndex = 0;
            ComboSotrudSearch.SelectedValue = "id";
            ComboSotrudSearch.DisplayMemberPath = "fio_sotrud";

            var allClients = strah_compEntities.GetContext().clients.ToList();
            allClients.Insert(0, new clients { fio_cl = "Все клиенты" });
            ComboClientSearch.ItemsSource = allClients;
            ComboClientSearch.SelectedIndex = 0;
            ComboClientSearch.SelectedValue = "id";
            ComboClientSearch.DisplayMemberPath = "fio_cl";

            //DGridDogovors.ItemsSource = strah_compEntities.GetContext().dogovors.ToList();
        }

        /// <summary>
        /// Обновить договоры.
        /// </summary>
        private void UpdateDogovors()
        {
            var current = strah_compEntities.GetContext().dogovors.ToList();

            if (ComboTypeSearch.SelectedIndex > 0)
            {
                current = current.Where(p => p.id_type_of == ComboTypeSearch.SelectedIndex).ToList();
            }

            if (ComboClientSearch.SelectedIndex > 0)
            {
                current = current.Where(p => p.id_client == ComboClientSearch.SelectedIndex - 1).ToList();
            }
            if (ComboFilialSearch.SelectedIndex > 0)
            {
                current = current.Where(p => p.id_fillials == ComboFilialSearch.SelectedIndex).ToList();
            }

            if (ComboSotrudSearch.SelectedIndex > 0)
            {
                current = current.Where(p => p.id_sotrud == ComboSotrudSearch.SelectedIndex).ToList();
            }

            DGridDogovors.ItemsSource = current.ToList();
        }

        /// <summary>
        /// Изменить.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (Datas._dostup < 2)
            {
                MessageBox.Show("Вы не можете изменить запись!", "Ошибка доступа!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                Manager.MainFrame.Navigate(new AddEditDogovors((sender as Button).DataContext as dogovors));
            }
        }

        /// <summary>
        /// Добавить.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditDogovors(null));
        }

        /// <summary>
        /// Удалить.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var dogovorsForRemoving = DGridDogovors.SelectedItems.Cast<dogovors>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить {dogovorsForRemoving.Count()} элементов?", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    strah_compEntities.GetContext().dogovors.RemoveRange(dogovorsForRemoving);
                    strah_compEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены", "Успех!", MessageBoxButton.OK, MessageBoxImage.Information);
                    DGridDogovors.ItemsSource = strah_compEntities.GetContext().dogovors.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        /// <summary>
        /// Смеенить видимость страницы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(Visibility == Visibility.Visible)
            {
                strah_compEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridDogovors.ItemsSource = strah_compEntities.GetContext().dogovors.ToList();
            }
        }

        /// <summary>
        /// Добавить клиента.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddClient_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditClient());
        }

        /// <summary>
        /// ComboBox, обновить
        /// </summary>
        private void ComboTypeSearch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateDogovors();
        }

        /// <summary>
        /// ComboBox, обновить
        /// </summary>
        private void ComboFilialSearch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateDogovors();
        }

        /// <summary>
        /// ComboBox, обновить
        /// </summary>
        private void ComboClientSearch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateDogovors();
        }

        /// <summary>
        /// ComboBox, обновить
        /// </summary>
        private void ComboSotrudSearch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateDogovors();
        }
        /// <summary>
        /// Печать.
        /// </summary>
        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new ResultPage((sender as Button).DataContext as dogovors));
        }
    }
}
