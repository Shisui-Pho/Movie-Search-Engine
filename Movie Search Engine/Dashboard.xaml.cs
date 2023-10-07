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
using System.Windows.Shapes;

namespace Movie_Search_Engine
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        private readonly ResourceDictionary resources;
        public Dashboard(string apiKey, ResourceDictionary resources)
        {
            InitializeComponent();
            //Getr the resource dictionary from the app service class
            this.resources = resources;
        }//ctor

        private void btnMovies_Click(object sender, RoutedEventArgs e)
        {

        }//btnMovies_Click

        private void btnTvShows_Click(object sender, RoutedEventArgs e)
        {

        }//btnTvShows_Click

        private void btnAnime_Click(object sender, RoutedEventArgs e)
        {

        }//btnAnime_Click
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            //Do not accept nulls and white space movie name
            if (string.IsNullOrEmpty(txtSearch.Text) || string.IsNullOrWhiteSpace(txtSearch.Text))
                return;

        }//btnSearch_Click

        private void CfrmDashboard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                btnSearch_Click(sender, e);
        }//CfrmDashboard_KeyDown
    }//class
}//namespace
