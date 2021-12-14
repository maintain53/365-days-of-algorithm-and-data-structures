public class Solution {
    public string ConvertToTitle(int columnNumber) {
       
        var builder = new StringBuilder();
        
        while(columnNumber != 0){
            
            var rem = (columnNumber - 1) % 26;
            
            var c = (char) (rem + 65);
            
            builder.Insert(0,c);
            
            columnNumber = (columnNumber - 1) / 26;
            
        }
        return builder.ToString();
        
    }
}
