namespace MediaLibrary
{
    class Book : MediaType
    {
        public string Author {get; private set;}
        public bool AR {get; private set;}
        public string DisplayText => 
            "The book " + Title + " was written by " + Author + " and is AR " + AR + OnLoanDisplayText;

        public Book(string title, string author, bool ar)
            : base(title)
        {
            Author = author;
            AR = ar;
        }          
    }
}