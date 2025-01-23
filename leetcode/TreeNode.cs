using System.Text;

public class TreeNode<T> where T : IComparable {
    public TreeNode(T Value) {
        this.Val = Value;
    }
    public T Val { get; set; }
    public TreeNode<T>? Left { get; set; } = null;
    public TreeNode<T>? Right { get; set; } = null; 

    public string DisplayNode() {
        var output = new StringBuilder();
        displayNode(output, 0);
        return output.ToString();
    }

    private void displayNode(StringBuilder output, int depth) {
        if (this.Right != null) {
            Right.displayNode(output, depth + 1);
        }

        output.Append('\t', depth);
        output.AppendLine(this.Val.ToString());

        if (this.Left != null) {
            Left.displayNode(output, depth + 1);
        }
    }
}