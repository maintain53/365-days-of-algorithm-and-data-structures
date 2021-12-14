public class Solution {
    public bool IsPalindrome(string s) {
        s = s.ToLower();
        
        var itr = s.Length - 1;
        var i = 0;
        
        while(i < s.Length){
            if(char.IsLetterOrDigit(s[i]) && char.IsLetterOrDigit(s[itr])){
               
                if(s[i] != s[itr]) return false; 
               
                i++;
                itr--;
                
            }else if (!char.IsLetterOrDigit(s[i])){
                
                i++;
                
            }else if (!char.IsLetterOrDigit(s[itr])){
                
                itr--;
                
            }                 
        }
        return true;
        
    }
}
