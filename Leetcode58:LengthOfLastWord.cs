public class Solution {
    public int LengthOfLastWord(string s) {
        var words = s.Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        
        for(var i = words.Length -1; i>=0; i++){
            
            var word = words[i].Trim();
            
            if(word.Length > 0) return word.Length;
                     
        }
        return 0;
        
    }
}
