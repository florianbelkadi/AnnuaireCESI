using AnnuaireClient.Services;
using AnnuaireClient.ViewModels;
using AnnuaireModel.Dao;
using AnnuaireSalarie.ViewModels;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using static System.Net.Mime.MediaTypeNames;

namespace AnnuaireClient.Views.Salaries
{
    //
    // Logique d'interaction pour ucSalariesList.xaml
    //
    public partial class ucSalariesList : UserControl
    {
        public ucSalariesList()
        {
            InitializeComponent();
            SalariesViewModel.Instance.GetAllSalaries();
        }


        private void SalarieCreate_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.CreateSalarie();
        }
        private void SalarieDetails_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            MainViewModel.Instance.ChargerSalarie(((Salarie)btn.DataContext).Id);
        }



        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var txt = ((TextBox)sender).Text;
            var bsl = SalariesViewModel.Instance.BaseSalarieList;

            SearchList(txt, bsl);
        }


        //Barre de recherche 
        public void SearchList(string search, ObservableCollection<Salarie> list)
        {
            SalariesViewModel.Instance.ListeSalaries.Clear();

            list = new ObservableCollection<Salarie>(list.Where(s => s.Nom.ToLower().Contains(search.ToLower()) ||
                                                            s.Email.ToLower().Contains(search.ToLower()) ||
                                                            s.TelFixe.ToLower().Contains(search.ToLower()) ||
                                                            s.TelPort.ToLower().Contains(search.ToLower()) ||
                                                            s.Prenom.ToLower().Contains(search.ToLower())));

            foreach(var salarie in list)
            {
                SalariesViewModel.Instance.ListeSalaries.Add(salarie);
            }
        }
    }
}
