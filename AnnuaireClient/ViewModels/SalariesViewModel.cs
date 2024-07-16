using AnnuaireClient;
using AnnuaireClient.Services;
using AnnuaireClient.ViewModels;
using AnnuaireModel.Dao;
using AnnuaireSite.ViewModels;
using System.Collections.ObjectModel;

namespace AnnuaireSalarie.ViewModels
{
    public class SalariesViewModel : BaseViewModel
    {
        #region Singleton
        private static SalariesViewModel instance = new SalariesViewModel();

        public static SalariesViewModel Instance { get => instance; }

        #endregion

        public Salarie Salarie { get; set; }

        public int SalarieId { get; set; }

        public ObservableCollection<Salarie> ListeSalaries { get; set; }

        public ObservableCollection<Salarie> BaseSalarieList { get; set; }

        public ObservableCollection<Site> ListeSites { get; set; }

        public ObservableCollection<Service> ListeServices { get; set; }


        public bool LoggedIn
        {
            get { return GLOBALS.IsLoggedIn; }
            set { GLOBALS.IsLoggedIn = LoggedIn; }
        }

        public SalariesViewModel()
        {
            GetAllSalaries();
        }

        public async void GetSalarie(int salarieId)
        {
            Salarie = await HttpClientService.GetSalarie(salarieId);
            SalarieId = salarieId;
            OnPropertyChanged(nameof(Salarie));
        }

        public async void GetAllSalaries()
        {
            ListeSalaries = await HttpClientService.GetAllSalaries();
            BaseSalarieList = await HttpClientService.GetAllSalaries();
            OnPropertyChanged(nameof(ListeSalaries));
            
        }

        public async void CreateSalarie(Salarie salarie)
        {
            await HttpClientService.CreateSalarie(salarie);
        }

        public async void DeleteSalarie(int id)
        {
            await HttpClientService.DeleteSalarie(id);
        }
        public async void UpdateSalarie(Salarie salarie) 
        {
            await HttpClientService.UpdateSalarie(salarie);
        }

        public async void GetAllSitesAndServices()
        {
            ListeSites = await HttpClientService.GetAllSites();
            ListeServices = await HttpClientService.GetAllServices();
            ListeServices.Add(new Service() { Id = 0, Nom = "" });
            ListeSites.Add(new Site() { Id = 0, Ville = "" });
            OnPropertyChanged(nameof(ListeServices));
            OnPropertyChanged(nameof(ListeSites));
        }
    }
}
