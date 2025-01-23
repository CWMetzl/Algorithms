public class BinarySearchTree<T>  where T : IComparable {
    public TreeNode<T>? Root { get; set; } = null;

    public BinarySearchTree() {

    }

    public BinarySearchTree(T[] values) {
        InsertValues(values);
    }

    public bool InsertValues(T[] values) {
        try {
            foreach(var val in values) {
                InsertValue(val);
            }
        } catch (Exception) {
            return false;
        }
        return true;
    }

    public bool InsertValue(T value) {
        try {
        this.Root = _insertValue(this.Root, value);
        } catch (Exception) {
            return false;
        }
        return true;
    }

    private TreeNode<T> _insertValue(TreeNode<T> root, T value) {
        if (root == null) return new TreeNode<T>(value);
        if (value.CompareTo(root.Val) > 0) {
            root.Right = _insertValue(root.Right, value);
        } else {
            root.Left = _insertValue(root.Left, value);
        }
        return root;
    }
}