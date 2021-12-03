public class Solution {
    public bool IsSymmetric(TreeNode root) {
        if(root == null) return true;
        
        return IsMirror(root.left, root.right);
    }
    
    public bool IsMirror(TreeNode a, TreeNode b){
        if(a == null && b == null) return true;
        
        if(a == null || b == null) return false;
        
        return a.val == b.val && IsMirror(a.left, b.right) 
                    && IsMirror(a.right, b.left);
    }
}
