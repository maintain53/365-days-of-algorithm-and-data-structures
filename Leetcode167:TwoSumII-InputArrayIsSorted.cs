public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var itr = numbers.Length - 1;
        var i = 0;
        
        while(i < numbers.Length){
            
            var sum = numbers[i] + numbers[itr];
            if(sum == target) return new int[]{i+1, itr+1};
            
            if(sum < target){
                i++;
            }else if (sum > target){
                itr--;
            }
            
        }
        
        return new int[2];
        
    }
}
