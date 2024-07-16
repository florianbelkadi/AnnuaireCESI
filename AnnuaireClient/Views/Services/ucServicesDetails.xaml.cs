using AnnuaireClient.ViewModels;
using AnnuaireModel.Dao;
using AnnuaireService.ViewModels;
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
    /// Logique d'interaction pour ucServicesDetails.xaml
    /// </summary>
    public partial class ucServicesDetails : UserControl
    {
        public ucServicesDetails()
        {
            InitializeComponent();
        }

        private void UpdateService_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var service = ((ServicesViewModel)btn.DataContext).Service;
            ServicesViewModel.Instance.UpdateService(service);
            ServicesViewModel.Instance.GetAllServices();
            MainViewModel.Instance.ChargerServices();
        }

        private void DeleteService_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var serviceId = ((ServicesViewModel)btn.DataContext).Service.Id;
            ServicesViewModel.Instance.DeleteService(serviceId);
            ServicesViewModel.Instance.GetAllServices();
            MainViewModel.Instance.ChargerServices();
        }

        private void Retour_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.ChargerServices();
        }
    }
}
