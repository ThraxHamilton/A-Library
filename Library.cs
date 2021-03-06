using System.Collections.Generic;

namespace bookexercise {
    public class Library {
        // Constructor for new library
        public Library (List<Book> initialInventory, string name, string addy) {
            // Whenever a new library is created, use this initial info
            _bookList = initialInventory;
            Name = name;
            Address = addy;
        }
        public string Name { get; set; }
        public string Address { get; set; }

        // Don't really need the second half of this now that you have a constructor above
        private List<Book> _bookList = new List<Book> ();

        // Create method to add books to library
        public void AddBooks (Book book) {
            _bookList.Add (book);
        }
        // Method to checkout books
        public void Checkout (string isbn, CardHolder cardHolder) {
            // Create a var to hold the books you want to check out
            Book findBook = new Book ();
            // bool
            bool didFindBook = false;
            // Loop over books in book list
            foreach (Book book in _bookList) {
                // If book id matches, and is available, add to books to checkout
                if (book.ISBN == isbn && book.isAvailable) {
                    cardHolder.CheckoutBook (findBook);
                    book.isAvailable = false;
                }
            }
        }
        public bool isAvailable(string isbn) {
            foreach(Book book in _bookList){
                if(book.ISBN == isbn){
                    return book.isAvailable;
                }
            }
            return false;
        }
    };
}