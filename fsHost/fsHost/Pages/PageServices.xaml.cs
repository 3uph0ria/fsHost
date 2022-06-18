using fsHost.Classes;
using fsHost.Models;
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

namespace fsHost.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageServices.xaml
    /// </summary>
    public partial class PageServices : Page
    {
        public PageServices(string header)
        {
            InitializeComponent();
            DGridServices.ItemsSource = fsHostEntities.GetContext().Services.ToList();
            Header.Text = header;
        }

        private void BtnEditService_Click(object sender, RoutedEventArgs e)
        {
            NavManager.AccountFrame.Navigate(new PageAddEditService((sender as Button).DataContext as Services));
        }

        private void BtnAddService_Click(object sender, RoutedEventArgs e)
        {
            NavManager.AccountFrame.Navigate(new PageAddEditService(null));
        }

        private void BtndelService_Click(object sender, RoutedEventArgs e)
        {
            Services currentService = (sender as Button).DataContext as Services;
            if (MessageBox.Show("Вы действительно хотите удалить товар " + currentService.Name + "?", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                fsHostEntities.GetContext().Services.Remove(currentService);
                fsHostEntities.GetContext().SaveChanges();
                NavManager.AccountFrame.Navigate(new PageServices(NavManager.BtnServices.Content + ""));
            }
        }

        private void SortCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }

        public void Update()
        {
            var services = fsHostEntities.GetContext().Services.ToList();
            DGridServices.ItemsSource = services;

        }
    }
}
