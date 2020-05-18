using System;
namespace MediaLibrary
{
    class Movie : MediaType
    {
        public string Director { get; private set;}

        public string DisplayText => "The movie " + Title + " was directed by " + Director + OnLoanDisplayText;

        public Movie(string title, string director)
            : base(title)
        {
            Director = director;
        }
    }
}