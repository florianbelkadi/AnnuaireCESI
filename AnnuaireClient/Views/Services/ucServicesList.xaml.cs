using AnnuaireClient.ViewModels;
using AnnuaireModel.Dao;
using AnnuaireSalarie.ViewModels;
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

namespace AnnuaireClient.Views.Services
{
    /// <summary>
    /// Logique d'interaction pour ucServicesList.xaml
    /// </summary>

    public partial class ucServicesList : UserControl
    {
        public ucServicesList()
        {
            InitializeComponent();
        }

        private void ServiceCreate_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.CreateService();
        }

        private void ServiceDetails_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            MainViewModel.Instance.ChargerService(((Service)btn.DataContext).Id);
        }

        private void Retour_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.ChargerServices();
        }
    }
}
