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
    /// Логика взаимодействия для PageCategorys.xaml
    /// </summary>
    public partial class PageCategorys : Page
    {
        public PageCategorys()
        {
            InitializeComponent();
            Header.Text = "Категории";
            DGridClients.ItemsSource = fsHostEntities.GetContext().Categoris.ToList();
        }

        private void BtnAddClient_Click(object sender, RoutedEventArgs e)
        {
            NavManager.AccountFrame.Navigate(new PageAddEditCategory(null));
        }

        private void BtndelService_Click(object sender, RoutedEventArgs e)
        {
            Categoris currentService = (sender as Button).DataContext as Categoris;
            if (MessageBox.Show("Вы действительно хотите удалить категорию " + currentService.Name + "?", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                fsHostEntities.GetContext().Categoris.Remove(currentService);
                fsHostEntities.GetContext().SaveChanges();
                NavManager.AccountFrame.Navigate(new PageCategorys());
            }
        }

        private void BtnEditClient_Click(object sender, RoutedEventArgs e)
        {
            NavManager.AccountFrame.Navigate(new PageAddEditCategory((sender as Button).DataContext as Categoris));
            
        }

        private void BtnEditClient_Click_1(object sender, RoutedEventArgs e)
        {
            NavManager.AccountFrame.Navigate(new PageAddEditCategory((sender as Button).DataContext as Categoris));
        }

        private void BtndelService_Click_1(object sender, RoutedEventArgs e)
        {
            Categoris currentService = (sender as Button).DataContext as Categoris;
            if (MessageBox.Show("Вы действительно хотите удалить категорию " + currentService.Name + "?", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                fsHostEntities.GetContext().Categoris.Remove(currentService);
                fsHostEntities.GetContext().SaveChanges();
                NavManager.AccountFrame.Navigate(new PageCategorys());
            }
        }

        private void BtnAddClient_Click_1(object sender, RoutedEventArgs e)
        {
            NavManager.AccountFrame.Navigate(new PageAddEditCategory(null));
        }
    }
}
