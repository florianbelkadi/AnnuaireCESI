using AnnuaireClient;
using AnnuaireClient.Services;
using AnnuaireModel.Dao;
using System.Collections.ObjectModel;

namespace AnnuaireSite.ViewModels
{
    public class SitesViewModel : BaseViewModel
    {
        #region Singleton
        private static SitesViewModel instance = new SitesViewModel();

        public static SitesViewModel Instance { get => instance; }

        #endregion

        public Site Site { get; set; }

        public int SiteId { get; set; }

        public ObservableCollection<Site> ListeSites { get; set; }

        public SitesViewModel()
        {
            GetAllSites();
        }

        public bool LoggedIn
        {
            get { return GLOBALS.IsLoggedIn; }
            set { GLOBALS.IsLoggedIn = LoggedIn; }
        }
        public async void GetSite(int siteId)
        {
            Site = await HttpClientService.GetSite(siteId);
            SiteId = siteId;
            OnPropertyChanged(nameof(Site));
        }

        public async void GetAllSites()
        {
            ListeSites = await HttpClientService.GetAllSites();
            OnPropertyChanged(nameof(ListeSites));
        }

        public async void CreateSite(Site site)
        {
            await HttpClientService.CreateSite(site);
        }

        public async void UpdateSite(Site site) 
        {
            await HttpClientService.UpdateSite(site);
        }

        public async void DeleteSite(int id)
        {
            await HttpClientService.DeleteSite(id);
        }
    }
}
