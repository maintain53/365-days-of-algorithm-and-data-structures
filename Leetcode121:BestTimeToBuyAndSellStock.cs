public class Solution {
    public int MaxProfit(int[] prices) {
        
        var price = prices[0];
        var maxProfit = 0;
        
        for(int i = 1; i < prices.Length; i++){
            
            if(prices[i] < price){
                price = prices[i];
            }
            else{
                maxProfit = Math.Max(prices[i]-price, maxProfit);
            }
            
            
        }
        
        return maxProfit;
        
    }
}
