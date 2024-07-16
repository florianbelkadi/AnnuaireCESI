using AnnuaireClient;
using AnnuaireClient.Services;
using AnnuaireClient.ViewModels;
using AnnuaireModel.Dao;
using System.Collections.ObjectModel;
using System.Windows;

namespace AnnuaireService.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        #region Singleton
        private static LoginViewModel instance = new LoginViewModel();

        public static LoginViewModel Instance { get => instance; }

        #endregion

        public bool IsLoggedIn { get; set; }

        public LoginViewModel()
        {

        }

        //Permet de se log avec le bon mdp, sinon message erreur
        public async void Login(string pwd)
        {
            IsLoggedIn = await HttpClientService.Login(pwd);
            if (IsLoggedIn)
            {
                MainViewModel.Instance.ChargerSalaries();
                GLOBALS.IsLoggedIn = true;
            }
            else
            {
                MessageBox.Show("Mauvais mot de passe/ou adresse email, réessayez.");
            }
        }
    }
}
