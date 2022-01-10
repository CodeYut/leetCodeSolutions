public class Solution {
    public int MaxProfit(int[] prices) {
        
        if(prices == null || prices.Length == 0)
        {
            return 0;
        }
        
        int [] res = new int [prices.Length];
        int diff =  -prices[0];
        
        for(int i = 1; i < prices.Length; i++)
        {
            res[i] = Math.Max(res[i - 1], prices[i] + diff);
            diff = Math.Max(diff, -prices[i]);
        }
        return res[prices.Length - 1];
    }
    
}
