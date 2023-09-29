using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Movie_Search_Engine.Model
{
    [DataContract]
    public class CMovies
    {
        [DataMember]
        private List<Movie> Search;
        public IEnumerator<Movie> GetEnumerator()
        {
            foreach (Movie movie in Search)
                yield return movie;
        }//GetEnumerator
    }//Class
    [DataContract]
    public class Movie
    {
        [DataMember]
        public string Title { get; private set; }
        [DataMember]
        public string Year { get; private set; }
        [DataMember]
        public string imdbID { get; private set; }
        [DataMember]
        public string Type { get; private set; }
        [DataMember]
        public string Poster { get; private set; }
        public Movie(string title, string year, string imdbID, string type, string poster)
        {
            Title = title;
            Year = year;
            this.imdbID = imdbID;
            Type = type;
            Poster = poster;
        }//Search
    }//Class
}//namespace
