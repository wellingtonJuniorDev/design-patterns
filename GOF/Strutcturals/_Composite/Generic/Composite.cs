namespace GOF.Strutcturals._Composite.Generic
{
    public class Composite : Component
    {
        List<Component> children = new List<Component>();

        public Composite(string name) : base(name) { }

        public override void Add(Component component)
        {
           children.Add(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);

            children.ForEach(component => component.Display(depth + 2));
        }

        public override void Remove(Component component)
        {
            children.Remove(component);
        }
    }
}
