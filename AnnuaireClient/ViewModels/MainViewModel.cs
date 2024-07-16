using AnnuaireClient.Views.Login;
using AnnuaireClient.Views.Salaries;
using AnnuaireClient.Views.Services;
using AnnuaireClient.Views.Shared;
using AnnuaireClient.Views.Sites;
using AnnuaireModel.Dao;
using AnnuaireSalarie.ViewModels;
using AnnuaireService.ViewModels;
using AnnuaireSite.ViewModels;
using System.Windows.Controls;

namespace AnnuaireClient.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        #region Singleton
        private static MainViewModel instance = new MainViewModel();

        public static MainViewModel Instance { get => instance; }

        private MainViewModel() { }
        #endregion

        public bool LoggedIn
        {
            get { return GLOBALS.IsLoggedIn; }
            set { GLOBALS.IsLoggedIn = LoggedIn; }
        }

        private UserControl userControl;

        public UserControl UserControl
        {
            get { return userControl; }
            set { userControl = value; OnPropertyChanged(); }
        }

       

        #region Salaries

        public void ChargerSalaries()
        {
            var uc = new ucSalariesList();
            uc.DataContext = SalariesViewModel.Instance;
            UserControl = uc;
        }

        public void ChargerServices()
        {
            var uc = new ucServicesList();
            uc.DataContext = ServicesViewModel.Instance;
            UserControl = uc;
        }

        public void ChargerSites()
        {
            var uc = new ucSitesList();
            uc.DataContext = SitesViewModel.Instance;
            UserControl = uc;
        }

        public void ChargerSalarie(int id)
        {
            var uc = new ucSalariesDetails();
            uc.DataContext = SalariesViewModel.Instance;
            ((SalariesViewModel)uc.DataContext).GetSalarie(id);
            UserControl = uc;
        }

        public void ChargerService(int id)
        {
            var uc = new ucServicesDetails();
            uc.DataContext = ServicesViewModel.Instance;
            ((ServicesViewModel)uc.DataContext).GetService(id);
            UserControl = uc;
        }
        public void ChargerSite(int id)
        {
            var uc = new ucSitesDetails();
            uc.DataContext = SitesViewModel.Instance;
            ((SitesViewModel)uc.DataContext).GetSite(id);
            UserControl = uc;
        }

        public void CreateSalarie()
        {
            var uc = new ucSalariesCreate();
            uc.DataContext = SalariesViewModel.Instance;
            ((SalariesViewModel)uc.DataContext).Salarie = new Salarie();
            UserControl = uc;
        }

        public void CreateSite()
        {
            var uc = new ucSitesCreate();
            uc.DataContext = SitesViewModel.Instance;
            ((SitesViewModel)uc.DataContext).Site = new Site();
            UserControl = uc;
        }

        public void CreateService()
        {
            var uc = new ucServicesCreate();
            uc.DataContext = ServicesViewModel.Instance;
            ((ServicesViewModel)uc.DataContext).Service = new Service();
            UserControl = uc;
        }

        public void ChargerLogin()
        {
            var uc = new ucLogin();
            uc.DataContext = LoginViewModel.Instance;
            UserControl = uc;
        }
        #endregion
    }
}
