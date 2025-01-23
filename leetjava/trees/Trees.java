package trees;
import java.util.ArrayList;

import java.util.List;

public class Trees {
  public int maxDepth(TreeNode root) {
    if(root == null) return 0;

    int leftSize = maxDepth(root.left);
    int rightSize = maxDepth(root.right);

    return Math.max(leftSize, rightSize) + 1;
    
  }

  public boolean isSameTree2(TreeNode p, TreeNode q) {
    List<Integer> treeOne = treeToArray(p);
    List<Integer> treeTwo = treeToArray(q);
    if (treeOne.size() != treeTwo.size()) return false;

    for(int i = 0;i < treeOne.size();i++) {
      if (treeOne.get(i) != treeTwo.get(i)) return false;
    }
    return true;
  }

  public List<Integer> treeToArray(TreeNode root) {
    List<Integer> result = new ArrayList<>();
    inOrderTraversal(root, result);
    return result;
  }

  public TreeNode buildTree(int[] preorder, int[] inorder) {
    TreeNode root = TreeBuilder(preorder, 0, preorder.length - 1, inorder, 0, inorder.length - 1);

    return root;
  }

  public void flatten(TreeNode root) {
    // pre order traversal
    
  }

  public TreeNode TreeBuilder(int[] pre, int preStart, int preEnd, int[] in, int inStart, int inEnd) {
    // Handle the null case  
    if (preStart > preEnd || inStart > inEnd) return null;

    // create the node to insert
    int rVal = pre[preStart];
    TreeNode rootNode = new TreeNode(rVal);

    // find the inOrder root
    int rootIndex = 0;
    for (int i = inStart; i <= inEnd; i++) {
        if (in[i] == rVal) {
            rootIndex = i;
            break;
        }
    }
    // Calculate the number of nodes in the left subtree
    int leftTreeSize = rootIndex - inStart;

    // Recursively build the left subtree
    rootNode.left = TreeBuilder(pre, preStart + 1, preStart + leftTreeSize, in, inStart, rootIndex - 1);

    // Recursively build the right subtree
    rootNode.right = TreeBuilder(pre, preStart + leftTreeSize + 1, preEnd, in, rootIndex + 1, inEnd);

    return rootNode;
  }

  private void inOrderTraversal(TreeNode node, List<Integer> result) {
      if (node == null) {
          return;
      }
      inOrderTraversal(node.left, result);
      result.add(node.val);
      inOrderTraversal(node.right, result);
  }

  public boolean isSymmetric2(TreeNode root) {
      if (root == null) return true;
      return isMirror(root.left, root.right);
  }

  private boolean isMirror(TreeNode t1, TreeNode t2) {
      // If both nodes are null, they are mirrors of each other
      if (t1 == null && t2 == null) return true;
      // If one of the nodes is null and the other is not, they are not mirrors
      if (t1 == null || t2 == null) return false;
      // Check if the current nodes have the same value and their respective subtrees are mirrors
      return (t1.val == t2.val) 
          && isMirror(t1.left, t2.right) 
          && isMirror(t1.right, t2.left);
  }

  public boolean isSymmetric(TreeNode root) {
    // invert it first
    TreeNode inverted = invertTree(root);
    return isSameTree(root, inverted);
  }

  public TreeNode invertTree(TreeNode root) {
      if (root == null) return null;

      TreeNode temp = root.left;
      root.left = root.right;
      root.right = temp;

      invertTree(root.left);
      invertTree(root.right);

      return root;
  }

  public boolean isSameTree(TreeNode p, TreeNode q) {
    // If both trees are empty, they are the same
    if (p == null && q == null) return true;
    // If one tree is empty and the other is not, they are not the same
    if (p == null || q == null) return false;
    // If the current nodes have different values, they are not the same
    if (p.val != q.val) return false;
    // Recursively compare the left and right subtrees
    return isSameTree(p.left, q.left) && isSameTree(p.right, q.right);
}


  public static void main(String[] args) {
    Trees treeOps = new Trees();

    // create
  }
}
