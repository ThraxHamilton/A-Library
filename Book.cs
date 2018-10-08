namespace bookexercise{
    public class Book {
        public Book (){
            isAvailable = true;
        }
        public string Title {get; set;}
        public string Author {get; set;}
        public string ISBN {get; set;}
        public bool isAvailable {get; set;}
    }
}