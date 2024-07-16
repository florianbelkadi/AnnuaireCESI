using AnnuaireClient.ViewModels;
using AnnuaireSite.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace AnnuaireClient.Views.Sites
{
    /// <summary>
    /// Logique d'interaction pour ucSitesDetails.xaml
    /// </summary>
    public partial class ucSitesDetails : UserControl
    {
        public ucSitesDetails()
        {
            InitializeComponent();
        }

        private void UpdateSite_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var site = ((SitesViewModel)btn.DataContext).Site;
            SitesViewModel.Instance.UpdateSite(site);
            SitesViewModel.Instance.GetAllSites();
            MainViewModel.Instance.ChargerSites();
        }

        private void DeleteSite_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var siteId = ((SitesViewModel)btn.DataContext).Site.Id;
            SitesViewModel.Instance.DeleteSite(siteId);
            SitesViewModel.Instance.GetAllSites();
            MainViewModel.Instance.ChargerSites();
        }

        private void Retour_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.ChargerSites();
        }
    }
}
