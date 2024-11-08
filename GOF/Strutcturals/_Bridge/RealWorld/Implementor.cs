namespace GOF.Strutcturals._Bridge.RealWorld
{
    public interface IDataObject<T>
    {
        void NextRecord();
        void PriorRecord();
        void AddRecord(T t);
        void DeleteRecord(T t);
        T GetCurrentRecord();
        void ShowRecord();
        void ShowAllRecords();
    }

    public class CustomersData : IDataObject<string>
    {
        private readonly string city;
        private readonly List<string> customers;
        private int current = 0;

        public CustomersData(string city)
        {
            this.city = city;

            // simulate loading from database
            customers = [
                "Jim Jones", "Samuel Jackson", "Allan Good", "Ann Stills", "Lisa Giolani"
            ];
        }

        public void AddRecord(string t) => customers.Add(t);

        public void DeleteRecord(string t) => customers.Remove(t);

        public string GetCurrentRecord() => customers[current];

        public void NextRecord()
        {
            if (current <= customers.Count - 1)
                current++;
        }

        public void PriorRecord()
        {
            if (current > 0)
                current--;
        }

        public void ShowAllRecords()
        {
            Console.WriteLine($"Customer Group: {city}");
            customers.ForEach(x => Console.WriteLine(" {0}", x));
        }

        public void ShowRecord() => Console.WriteLine(customers[current]);
    }
}
