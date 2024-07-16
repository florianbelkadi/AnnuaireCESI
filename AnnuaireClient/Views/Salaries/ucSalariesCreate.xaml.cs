﻿using AnnuaireClient.ViewModels;
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

namespace AnnuaireClient.Views.Salaries
{
    /// <summary>
    /// Logique d'interaction pour ucSalariesCreate.xaml
    /// </summary>
    public partial class ucSalariesCreate : UserControl
    {
        public ucSalariesCreate()
        {
            InitializeComponent();
        }

        private void comboBoxServicesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Service service = (Service)((ComboBox)sender).SelectedItem;
            SalariesViewModel.Instance.Salarie.ServiceId = service.Id;
        }

        private void comboBoxSitesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Site site = (Site)((ComboBox)sender).SelectedItem;
            SalariesViewModel.Instance.Salarie.SiteId = site.Id;
        }

        private void CreateSalarie_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var salarie = ((SalariesViewModel)btn.DataContext).Salarie;
            SalariesViewModel.Instance.CreateSalarie(salarie);
            SalariesViewModel.Instance.GetAllSalaries();
            MainViewModel.Instance.ChargerSalaries();
        }

        private void Retour_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.ChargerSalaries();
        }
    }
}
