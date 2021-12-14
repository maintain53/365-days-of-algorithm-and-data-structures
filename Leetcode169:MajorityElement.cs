public class Solution {
    public int MajorityElement(int[] nums) {
        var map = new Dictionary<int,int>();
        
        foreach(var num in nums){
            
            if(map.ContainsKey(num)){
                
                map[num]++;
                
            }else{
                
                map.Add(num,1);
                
            }
            
        }
        
        var count = nums.Length / 2;
        
        foreach(var pair in map){
            
            if(pair.Value > count) return pair.Key;
        }
        return 0;
        
    }
}
