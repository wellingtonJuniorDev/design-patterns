namespace GOF.Creationals._Builder.Generic
{
    public class Product
    {
        private readonly List<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\nProducts Parts ----------");

            _parts.ForEach(Console.WriteLine);
        }
    }
}
