using AnnuaireClient.ViewModels;
using AnnuaireModel.Dao;
using AnnuaireSalarie.ViewModels;
using AnnuaireService.ViewModels;
using AnnuaireSite.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace AnnuaireClient.Views.Salaries
{
    /// <summary>
    /// Logique d'interaction pour ucSalariesDetails.xaml
    /// </summary>
    public partial class ucSalariesDetails : UserControl
    {
        public ucSalariesDetails()
        {
            InitializeComponent();
            SalariesViewModel.Instance.GetAllSitesAndServices();
        }

        private void comboBoxServicesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Service service = (Service)((ComboBox)sender).SelectedItem;
            SalariesViewModel.Instance.Salarie.ServiceId = service.Id;
        }

        private void comboBoxSitesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Site site= (Site)((ComboBox)sender).SelectedItem;
            SalariesViewModel.Instance.Salarie.SiteId = site.Id;
        }

        private void UpdateSalarie_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var salarie = ((SalariesViewModel)btn.DataContext).Salarie;
            SalariesViewModel.Instance.UpdateSalarie(salarie);
            SalariesViewModel.Instance.GetAllSalaries();
            MainViewModel.Instance.ChargerSalaries();
        }

        private void DeleteSalarie_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var salarieId = ((SalariesViewModel)btn.DataContext).Salarie.Id;
            SalariesViewModel.Instance.DeleteSalarie(salarieId);
            SalariesViewModel.Instance.GetAllSalaries();
            MainViewModel.Instance.ChargerSalaries();
        }

        private void Retour_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.ChargerSalaries();
        }
    }
}
