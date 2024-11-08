namespace GOF.Strutcturals._Decorator.RealWorld
{
    public abstract class Decorator<T>(LibraryItem<T> libraryItem) : LibraryItem<T>
    {
        public override void Display() => libraryItem.Display();
    }

    public class Borrowable<T> : Decorator<T>
    {
        private readonly List<string> borrowers = [];
       
        public Borrowable(LibraryItem<T> libraryItem)
            : base(libraryItem)
        {
        }

        public void BorrowItem(string name)
        {
            borrowers.Add(name);
            NumCopies--;
        }

        public void ReturnItem(string name)
        {
            borrowers.Remove(name);
            NumCopies++;
        }

        public override void Display()
        {
            base.Display();
            borrowers.ForEach(b => Console.WriteLine(" borrower: " + b));
        }
    }
}
