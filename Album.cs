namespace MediaLibrary
{
    class Album : MediaType
    {
        public string Artist {get; private set;}
        public string DisplayText => "The album " + Title + " by " + Artist + OnLoanDisplayText;

        public Album(string artist, string title)
            : base(title)
        {
            Artist = artist;
        } 
    }
}