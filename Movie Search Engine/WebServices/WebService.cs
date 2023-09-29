using Movie_Search_Engine.Model;
using Newtonsoft.Json;
using System.Net;
namespace Movie_Search_Engine.WebServices
{
    public static class WebService
    {
        public static string ApiKey;
        public static string BaseAdress = @"https://www.omdbapi.com/";
        public static CMovies LoadMoviesBasedOnTitles(string Title)
        {
            string dataString;
            using (WebClient webClient = new WebClient())
            {
                dataString = webClient.DownloadString(string.Format($"{BaseAdress}?s={Title}&apikey={ApiKey}"));
            }//end using
            return JsonConvert.DeserializeObject<CMovies>(dataString);
        }//LoadMoviesBasedOnTitles
        public static CMovie LoadMovieDetails(string fullTitle, int releaseYear)
        {
            string dataString;
            using (WebClient webClient = new WebClient())
            {
                dataString = webClient.DownloadString(string.Format($"{BaseAdress}?t={fullTitle}&y={releaseYear}&plot=full&apikey={ApiKey}"));
            }//end using
            return JsonConvert.DeserializeObject<CMovie>(dataString);
        }//LoadMovieDetails   
        public static CMovie LoadMovieDetails(string fullTitle, string imbd)
        {
            string dataString;
            using (WebClient webClient = new WebClient())
            {
                dataString = webClient.DownloadString(string.Format($"{BaseAdress}?t={fullTitle}&i={imbd}&plot=full&apikey={ApiKey}"));
            }//end using
            return JsonConvert.DeserializeObject<CMovie>(dataString);
        }//LoadMovieDetails
    }//class
}//namespace
