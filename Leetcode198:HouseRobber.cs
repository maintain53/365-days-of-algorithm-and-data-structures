public class Solution {
    public int Rob(int[] nums) {
        var even = 0;
        var odd = 0;
        for(int i = 0; i< nums.Length; i++){
            
            if(i % 2 == 0){
                even = Math.Max(even + nums[i], odd);
            }
            else{
                odd = Math.Max(odd + nums[i], even);
            }
           
                    
        }
        
        return Math.Max(even,odd);
        
    }
}
