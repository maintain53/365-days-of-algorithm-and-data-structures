public class Solution {
    public int RomanToInt(string s) {
        var numeralsMap = new Dictionary<char,int>();
        var result = 0;
        numeralsMap.Add('I',1);
        numeralsMap.Add('V',5);
        numeralsMap.Add('X',10);
        numeralsMap.Add('L',50);
        numeralsMap.Add('C',100);
        numeralsMap.Add('D',500);
        numeralsMap.Add('M',1000);
        
        for(int i = 0; i < s.Length - 1; i++){
            var currentValue = numeralsMap[s[i]];
            result += (numeralsMap[s[i+1]] > currentValue ? -1 : 1) * currentValue;
        }
        
        return result + numeralsMap[s[s.Length - 1]];
        
    }
}
