using System;

namespace MediaLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var MediaLib = new MediaLibrary1(new MediaType[]
                {
                    new Album("Indigo Girls", "Rites of Passage"),
                    new Book("Owl Diaries", "Rebecca", false),
                    new Movie("Stargate", "A Name")
                });

                Console.WriteLine("Number of items: " + MediaLib.NumberOfItems);
            
                var item = MediaLibrary1.FindItem("stargate");
                // MediaLib.DisplayItems();

                // Display(MediaLib.GetItemAt(0));
                // Display(MediaLib.GetItemAt(1));
                // Display(MediaLib.GetItemAt(2));

                // Console.WriteLine(items[0].GetDisplay());    
                // Console.WriteLine(items[1].GetDisplay());
                // Console.WriteLine(items[2].GetDisplay());

                // items[2].Loan();
                // Console.WriteLine(items[2].GetDisplay());

                // items[2].Return();
                // Console.WriteLine(items[2].GetDisplay());
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }
        public static void Display(MediaType item)
        {
            if (item == null)
            {
                return;
            }

            if (item is Album)
            {
                var album = (Album)item;
                Console.WriteLine(album.DisplayText);
            }
            else if (item is Book)
            {
                var book = (Book)item;
                Console.WriteLine(book.DisplayText);
            }
            else if (item is Movie)
            {
               var movie = (Movie)item;
               Console.WriteLine(movie.DisplayText);
            }
            else 
            {
                throw new Exception("Unexpected media subtype detected.");
            }
        }
        public static void DetectMediaType(MediaType item)
        {
            if (item == null)
            {
                return;
            }

            if (item is Album)
            {
                Console.WriteLine(item.Title + " is a Album"); 
            }
            else if (item is Book)
            {
                Console.WriteLine(item.Title + " is a Book"); 
            }
            else if (item is Movie)
            {
                Console.WriteLine(item.Title + " is a Movie"); 
            }
            else 
            {
                throw new Exception("Unexpected media subtype detected.");
            }
        }
    }
}
