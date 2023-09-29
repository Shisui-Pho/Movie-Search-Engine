using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Movie_Search_Engine.Model
{
    [DataContract]
    public class CMovie
    {
        //Properties
        [DataMember]
        public string Title { get; private set; }
        [DataMember]
        public string Released { get; private set; }
        [DataMember]
        public string Runtime { get; private set; }
        [DataMember]
        public string Genre { get; private set; }
        [DataMember]
        public string Director { get; private set; }
        [DataMember]
        public string Writer { get; private set; }
        [DataMember]
        public string Actors { get; private set; }
        [DataMember]
        public string Plot { get; private set; }
        [DataMember]
        public string Poster { get; private set; }
        [DataMember]
        private List<Rating> Ratings { get; set; }

        //Encapsulated Property
        [DataContract]
        private class Rating
        {
            [DataMember]
            public string Source { get;private set; }
            [DataMember]
            public string Value { get;private set; }
            public Rating(string source, string value)
            {
                Source = source;
                Value = value;
            }//ctor 1
        }//Rating

        //Methods.
        public IEnumerator<string> GetEnumerator(int iPadding = 20)
        {
            foreach (Rating rating in Ratings)
            {
                yield return String.Format($"{rating.Source.PadRight(iPadding)}: {rating.Source}");
            }//end foreach
        }//GetRating
    }//class
}//namespace
