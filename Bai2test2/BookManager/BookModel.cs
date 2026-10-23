
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BookManager
{
    public class BookModel : INotifyPropertyChanged
    {
        private string bookId = "";
        private string bookName = "";
        private string author = "";
        private string category = "";
        private decimal price;
        private int quantity;
        private string coverPath = "";

        public event PropertyChangedEventHandler? PropertyChanged;

        private void Notify([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(name));
        }

        public string BookId
        {
            get => bookId;
            set { bookId = value; Notify(); }
        }

        public string BookName
        {
            get => bookName;
            set { bookName = value; Notify(); }
        }

        public string Author
        {
            get => author;
            set { author = value; Notify(); }
        }

        public string Category
        {
            get => category;
            set { category = value; Notify(); }
        }

        public decimal Price
        {
            get => price;
            set { price = value; Notify(); Notify(nameof(Total)); }
        }

        public int Quantity
        {
            get => quantity;
            set { quantity = value; Notify(); Notify(nameof(Total)); }
        }

        public string CoverPath
        {
            get => coverPath;
            set { coverPath = value; Notify(); }
        }

        public decimal Total => Price * Quantity;
    }
}
