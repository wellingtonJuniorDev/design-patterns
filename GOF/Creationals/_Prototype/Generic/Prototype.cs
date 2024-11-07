namespace GOF.Creationals._Prototype.Generic
{
    public abstract class Prototype
    {
        readonly string id;

        protected Prototype(string id)
        {
            this.id = id;
        }

        public string Id { get { return id; } }

        public abstract Prototype Clone();
    }

    public class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(string id) : base(id) { }

        public override Prototype Clone()
        {
            return (Prototype) MemberwiseClone();
        }
    }

    public class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(string id) : base(id) { }

        public override Prototype Clone()
        {
            return (Prototype)MemberwiseClone();
        }
    }
}
