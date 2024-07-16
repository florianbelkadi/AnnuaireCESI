﻿using AnnuaireClient.ViewModels;
using AnnuaireModel.Dao;
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

namespace AnnuaireClient.Views.Sites
{
    /// <summary>
    /// Logique d'interaction pour ucSitesList.xaml
    /// </summary>
    public partial class ucSitesList : UserControl
    {
        public ucSitesList()
        {
            InitializeComponent();
        }
        private void SiteDetails_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            MainViewModel.Instance.ChargerSite(((Site)btn.DataContext).Id);
        }
        private void SiteCreate_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.CreateSite();
        }


    }
}
