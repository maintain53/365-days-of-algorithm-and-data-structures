public class Solution {
    public int TitleToNumber(string columnTitle) {
        
       var sum = 0; 
       foreach (var c in columnTitle){
           sum *= 26;
           int val = (c + 1) - 65;
           sum += val;
                
       }
        return sum;
        
    }
}
