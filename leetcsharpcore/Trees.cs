
public class Trees {
    private static TreeNode<int> TestTree() {
        var a = new TreeNode<int>(1);
        var b = new TreeNode<int>(2);
        var c = new TreeNode<int>(3);
        var d = new TreeNode<int>(4);
        var e = new TreeNode<int>(5);
        var f = new TreeNode<int>(6);
        a.Left = b;
        a.Right = c;
        b.Left = d;
        b.Right = e;
        c.Right = f;
        return a;
    }

     public static int[] TestDFT() {
        
        return DepthFirstTraversal(TestTree());
    }
    public static int[] TestDFTRecursive() {
        
        return DepthFirstTraversalRecursive(TestTree());
    }
    public static int[] DepthFirstTraversalRecursive(TreeNode<int> root) {
        if (root == null) return new int[0];
        var leftVal = DepthFirstTraversalRecursive(root.Left);
        var rightVal = DepthFirstTraversalRecursive(root.Right);
        
        var result = new int[]{root.Val};
        if (leftVal != null) result = result.Concat(leftVal).ToArray();
        if (rightVal != null) result = result.Concat(rightVal).ToArray();
        return result;
    }

    public static int[] DepthFirstTraversal(TreeNode<int> root) {
        if (root == null) return new int[0];
        var stack = new Stack<TreeNode<int>>();
        stack.Push(root);
        var result = new List<int>();

        while(stack.Count > 0) {
            var current = stack.Pop();
            result.Add(current.Val);
            if (current.Right != null) stack.Push(current.Right);
            if (current.Left != null) stack.Push(current.Left);
        }
        return result.ToArray();
    }

    public static int[] TestBFT() {
        
        return BredthFirstTraversal(TestTree());
    }
    public static int[] BredthFirstTraversal(TreeNode<int> root) {
        if (root == null) return new int[0];
        var queue = new Queue<TreeNode<int>>();
        queue.Enqueue(root);
        var result = new List<int>();

        while(queue.Count > 0) {
            var current = queue.Dequeue();
            result.Add(current.Val);
            if (current.Left != null) queue.Enqueue(current.Left);
            if (current.Right != null) queue.Enqueue(current.Right); 
        }
        return result.ToArray();
    }

    public static int[] BredthFirstTraversalRecursive(TreeNode<int> root) {
        if (root == null) return new int[0];
        var rightVal = DepthFirstTraversalRecursive(root.Right);
        var leftVal = DepthFirstTraversalRecursive(root.Left);
        
        var result = new int[]{root.Val};
        if (rightVal != null) result = result.Concat(rightVal).ToArray();
        if (leftVal != null) result = result.Concat(leftVal).ToArray();
        return result;
    }

    public static int TestSumTree() {
        
        return SumTree(TestTree());
    }
    public static int SumTree(TreeNode<int> root) {
        if (root == null) return 0;
        var stack = new Stack<TreeNode<int>>();
        int sum = 0;
        stack.Push(root);
        while(stack.Count > 0) {
            var curr = stack.Pop();
            sum += curr.Val;
            if (curr.Left != null) stack.Push(curr.Left);
            if (curr.Right != null) stack.Push(curr.Right);
        }
        return sum;
    }

    public static int TestTreeLargestValue() {
        
        return TreeLargestValue(TestTree());
    }
    public static int TreeLargestValue(TreeNode<int> root) {
        if (root == null) return 0;
        var stack = new Stack<TreeNode<int>>();
        int largest = Int32.MinValue;
        stack.Push(root);
        while(stack.Count > 0) {
            var curr = stack.Pop();
            if (curr.Val > largest) largest = curr.Val;
            if (curr.Left != null) stack.Push(curr.Left);
            if (curr.Right != null) stack.Push(curr.Right);
        }
        return largest;
    }
    public static int TestTreeSumValueRecursive() {
        
        return TreeSumValueRecursive(TestTree());
    }
    public static int TreeSumValueRecursive(TreeNode<int> root) {
        if (root == null) return 0;

        return root.Val + TreeSumValueRecursive(root.Left) + TreeSumValueRecursive(root.Right);
    }

    public static int TestTreeLeastValue() {
        
        return SumTreeLeastValue(TestTree());
    }
    public static int SumTreeLeastValue(TreeNode<int> root) {
        if (root == null) return 0;
        var stack = new Stack<TreeNode<int>>();
        int least = Int32.MaxValue;
        stack.Push(root);
        while(stack.Count > 0) {
            var curr = stack.Pop();
            if (curr.Val < least) least = curr.Val;
            if (curr.Left != null) stack.Push(curr.Left);
            if (curr.Right != null) stack.Push(curr.Right);
        }
        return least;
    }

    public static int TestTreeLeastValueRecursive() {
        
        return TreeLeastValueRecursive(TestTree());
    }

    public static int TreeLeastValueRecursive(TreeNode<int> root) {
        if (root == null) return Int32.MaxValue;
        var right = TreeLeastValueRecursive(root.Right);
        var left = TreeLeastValueRecursive(root.Left);
        return new int[]{root.Val, right, left}.Min();
    }

    public static int TestTreeLargestValueRecursive() {
        
        return TreeLargestValueRecursive(TestTree());
    }

    public static int TreeLargestValueRecursive(TreeNode<int> root) {
        if (root == null) return Int32.MinValue;
        var right = TreeLargestValueRecursive(root.Right);
        var left = TreeLargestValueRecursive(root.Left);
        return new int[]{root.Val, right, left}.Max();
    }
}