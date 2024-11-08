using GOF.Strutcturals._Composite.Generic;
using GOF.Strutcturals._Composite.RealWorld;

namespace GOF.Strutcturals._Composite
{
    /// <summary>
    /// <para>The composite design pattern composes objects into tree structures to represent part-whole hierarquies.</para>
    /// <para>This pattern lets clients treat individual objects and compositions of objects uniformly.</para>
    /// </summary>
    public class CompositePattern : IDesignPattern
    {
        public void GenericCase()
        {
            Composite root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite composite = new Composite("Composite X");
            composite.Add(new Leaf("Leaf XA"));
            composite.Add(new Leaf("Leaf XB"));

            root.Add(composite);
            root.Add(new Leaf("Leaf C"));

            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            root.Display(1);
        }

        public void RealLifeCase()
        {
            var root = new TreeNode<Shape> { Node = new("Picture") };
            root.Add(new Shape("Red Line"));
            root.Add(new Shape("Blue Circle"));
            root.Add(new Shape("Green Box"));

            var branch = root.Add(new Shape("Two Circles"));
            branch.Add(new Shape("Black Circle"));
            branch.Add(new Shape("White Circle"));

            var shape = new Shape("Yellow Line");

            root.Add(shape);
            root.Remove(shape);
            root.Add(shape);
            
            TreeNode<Shape>.Display(root, 1);
        }
    }
}
