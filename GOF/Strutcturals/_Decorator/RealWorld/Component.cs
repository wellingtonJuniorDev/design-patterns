namespace GOF.Strutcturals._Decorator.RealWorld
{
    public abstract class LibraryItem<T>
    {
        public static int NumCopies { get; set; }
        public abstract void Display();
    }

    public class Book : LibraryItem<Book>
    {
        private readonly string author;
        private readonly string title;

        public Book(string author, string title, int numCopies)
        {
            this.author = author;
            this.title = title;
            NumCopies = numCopies;            
        }

        public override void Display()
        {
            Console.WriteLine("\nBook ----- ");
            Console.WriteLine($" Author: {author}");
            Console.WriteLine($" Title: {title}");
            Console.WriteLine($" # Copies: {NumCopies}");
        }
    }

    public class Video : LibraryItem<Video>
    {
        private readonly string director;
        private readonly string title;
        private readonly int playTime;
        
        public Video(string director, string title,
            int numCopies, int playTime)
        {
            this.director = director;
            this.title = title;
            NumCopies = numCopies;
            this.playTime = playTime;
        }

        public override void Display()
        {
            Console.WriteLine("\nVideo ----- ");
            Console.WriteLine($" Director: {director}");
            Console.WriteLine($" Title: {title}");
            Console.WriteLine($" # Copies: {NumCopies}");
            Console.WriteLine($" Playtime: {playTime}\n");
        }
    }
}
