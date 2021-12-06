public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var result = "";
        
        if(strs.Length == 0) return result;
       
        for(int i = 1; i <= strs[0].Length; i++){
            
            var prefix = strs[0].Substring(0,i);
            
            for(int j = 1; j < strs.Length; j++){
                
                if(i > strs[j].Length) return result;
                
                var currentPrefix = strs[j].Substring(0,i);
                
                if(prefix != currentPrefix) return result;
                
            }
            
            result = prefix;
            
        }
        return result;
        
    }
}
