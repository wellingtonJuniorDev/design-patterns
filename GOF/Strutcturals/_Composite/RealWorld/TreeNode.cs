namespace GOF.Strutcturals._Composite.RealWorld
{
    public class TreeNode<T> where T : IComparable<T>
    {
        public T Node { get; set; } = default!;
        public List<TreeNode<T>> Children { get; } = [];

        public TreeNode<T> Add(T child)
        {
            var newNode = new TreeNode<T> { Node = child };
            Children.Add(newNode);

            return newNode;
        }
       
        public void Remove(T child)
        {
            foreach (var treeNode in Children)
            {
                if (treeNode.Node.CompareTo(child) == 0)
                {
                    Children.Remove(treeNode);
                    return;
                }
            }
        }
                
        public static void Display(TreeNode<T> node, int indentation)
        {
            var line = new string('-', indentation);
            Console.WriteLine(line + " " + node.Node);

            node.Children.ForEach(n => Display(n, indentation + 1));
        }
    }
}
