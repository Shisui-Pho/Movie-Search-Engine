using System.Windows;
using Movie_Search_Engine.Model;
using Movie_Search_Engine.WebServices;
namespace Movie_Search_Engine
{
    /// <summary>
    /// Interaction logic for CfrmMain.xaml
    /// </summary>
    public partial class CfrmMain : Window
    {
        
        public CfrmMain(string apikey)
        {
            InitializeComponent();

            //Set the Api key for the web Service
            WebService.ApiKey = apikey;
        }//ctor

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
      
        }//Window_Loaded
    }//class
}//namespace
