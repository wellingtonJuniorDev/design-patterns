namespace GOF.Strutcturals._Composite.RealWorld
{
    public class Shape(string name) : IComparable<Shape>
    {
        public override string ToString() => name;
        public int CompareTo(Shape other) => (this == other) ? 0 : -1;
    }
}
