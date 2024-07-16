using AnnuaireService.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace AnnuaireClient.Views.Login
{
    //
    /// Logique d'interaction du login
    //
    public partial class ucLogin : UserControl
    {
        public ucLogin()
        {
            InitializeComponent();
        }

        private void Valider_Click(object sender, RoutedEventArgs e)
        {
            LoginViewModel.Instance.Login(pwd.Text);
        }

    }
}
