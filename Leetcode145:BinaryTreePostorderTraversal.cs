/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<int> PostorderTraversal(TreeNode root) {
        var result = new List<int>();
        Traverse(root, result);
        return result;
    }
    
    public void Traverse(TreeNode root, IList<int> result){
        
        if(root == null) return;
             
        Traverse(root.left, result);
        Traverse(root.right, result);
        result.Add(root.val);
    }
}
