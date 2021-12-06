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
    public TreeNode SortedArrayToBST(int[] nums) {
        
        if(nums.Length == 0) return null;
        
        return CreateTree(nums,0, nums.Length - 1);
        
    }
    
    public TreeNode CreateTree(int[] nums, int low, int high){
        if(low > high) return null;
        
        var mid = (high + low)/ 2;
        
        var node = new TreeNode(nums[mid]);
        
        node.left = CreateTree(nums, low, mid-1);
        node.right = CreateTree(nums, mid + 1, high);
        
        return node;
        
    }
}
