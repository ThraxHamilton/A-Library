using System;
using System.Collections.Generic;

namespace bookexercise {
    class Program {
        static void Main (string[] args) {
            // Add books
            Book Pimp = new Book () {
                Title = "Pimp",
                Author = "Iceberg Slim",
                ISBN = "1451617135"
            };
            Book Goosebumps = new Book () {
                Title = "Goosebumps",
                Author = "RL Stine",
                ISBN = "1338149083"
            };
            Book ShookOne = new Book () {
                Title = "Shook One: Anxiety Playing Tricks On Me",
                Author = "Charlegemane Tha God",
                ISBN = "1501193252"
            };
            Book Playboy = new Book () {
                Title = "Playboy Centerfolds",
                Author = "Hugh Hefner",
                ISBN = "1452161038"
            };

            Book book1 = new Book () {
                Title = "book1",
                Author = "Dez N`uts",
                ISBN = "2B",
                // isAvailable = false
            };
            // For constructor. When constructed, all books in this list get put in the initial library
            List<Book> books = new List<Book>(){
                book1
            };
            // Add a library               Pass in arguments here inseaad of using objects
            Library library = new Library (books,"Public Library", "234 Over There Ln" ) {
                // Name = "Public Library",
                // Address = "234 Over There Ln"
            };
            // Call add method from Library.cs
            library.AddBooks (Pimp);
            library.AddBooks (Goosebumps);
            library.AddBooks (ShookOne);
            library.AddBooks (Playboy);

            // 2B ref to isbn for book1
            if(library.isAvailable("2B")){
                Console.WriteLine("2B is available");

            }
            else {
                Console.WriteLine("2B isn't available");
            }
        }
    }
}