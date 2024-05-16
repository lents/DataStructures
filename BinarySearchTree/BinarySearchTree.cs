public class BinarySearchTree<T> where T : IComparable<T>
{
    private TreeNode<T> root;

    public BinarySearchTree()
    {
        root = null;
    }

    public void Insert(T value)
    {
        root = Insert(root, value);
    }

    private TreeNode<T> Insert(TreeNode<T> node, T value)
    {
        if (node == null)
        {
            return new TreeNode<T>(value);
        }

        if (value.CompareTo(node.Value) < 0)
        {
            node.Left = Insert(node.Left, value);
        }
        else if (value.CompareTo(node.Value) > 0)
        {
            node.Right = Insert(node.Right, value);
        }

        return node;
    }

    public bool Search(T value)
    {
        return Search(root, value);
    }

    private bool Search(TreeNode<T> node, T value)
    {
        if (node == null)
        {
            return false;
        }

        if (value.CompareTo(node.Value) == 0)
        {
            return true;
        }
        else if (value.CompareTo(node.Value) < 0)
        {
            return Search(node.Left, value);
        }
        else
        {
            return Search(node.Right, value);
        }
    }
}
