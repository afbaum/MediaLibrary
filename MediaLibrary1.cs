using System;

namespace MediaLibrary
{
    class MediaLibrary1
    {
        private MediaType[] _items;
        public int NumberOfItems => _items.Length;

        public MediaLibrary1(MediaType[] items)
        {
            _items = items;
        }

        public MediaType GetItemAt(int index)
        {
            return (index < _items.Length) ? _items[index] : null;
        }

        public void DisplayItems()
        {
            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i] == null)
                {
                    return;
                }

                if (_items[i] is Album)
                {
                    Console.WriteLine(_items[i].Title + " is a Album"); 
                }
                else if (_items[i] is Book)
                {
                    Console.WriteLine(_items[i].Title + " is a Book"); 
                }
                else if (_items[i]  is Movie)
                {
                    Console.WriteLine(_items[i].Title + " is a Movie"); 
                }
                else 
                {
                    throw new Exception("Unexpected media subtype detected.");
                }
            }
        }

        public MediaType FindItem(string criteria)
        {
            MediaType itemToReturn = null;

            foreach (var item in _items)
            {
                if (item.Title.ToLower().Contains(criteria.ToLower()))
                {
                    itemToReturn = item;
                    break;
                }
            }
            return itemToReturn;
        }
    }
}