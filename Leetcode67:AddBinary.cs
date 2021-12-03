public class Solution {
    public string AddBinary(string a, string b) {
        var aIndex = a.Length - 1;
        var bIndex = b.Length - 1;
        
        var result = new StringBuilder();
        var rem = 0;
        while(aIndex >= 0 || bIndex >= 0){
            
            var firstNum = aIndex < 0 ? 0 : Int16.Parse(a[aIndex].ToString());
            
            var secondNum = bIndex < 0 ? 0 : Int16.Parse(b[bIndex].ToString());
            
            var sum = firstNum + secondNum + rem;
            
            rem = sum / 2;
            
            result.Append(sum % 2); 
            
            bIndex--;
            aIndex--;
        }
        if(rem > 0){
            result.Append(rem); 
        }
        
        return String.Join("",result.ToString().Reverse());
        
    }
}
