namespace GOF.Strutcturals._Bridge.RealWorld
{
    public class CustomersBase(IDataObject<string> dataObject)
    {
        public virtual void Next() => dataObject.NextRecord();
        public virtual void Prior() => dataObject.PriorRecord();
        public virtual void Add(string name) => dataObject.AddRecord(name);
        public virtual void Delete(string name) => dataObject.DeleteRecord(name);
        public virtual void Show() => dataObject.ShowRecord();
        public virtual void ShowAll() => dataObject.ShowAllRecords();
    }

    public class Customers(IDataObject<string> dataObject) : CustomersBase(dataObject)
    {
        public override void ShowAll()
        {
            Console.WriteLine("---------------------------");
            base.ShowAll();
            Console.WriteLine("---------------------------");
        }
    }
}
