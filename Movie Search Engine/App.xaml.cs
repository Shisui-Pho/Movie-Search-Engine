using System.Windows;

namespace Movie_Search_Engine
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //Get the API key from the command line
            CfrmMain window = new CfrmMain(e.Args[0]);
            window.Show();
        }//Application_Startup
    }//class
}//namespace
