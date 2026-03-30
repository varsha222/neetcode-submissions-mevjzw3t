public class Solution {
    public int MaxProfit(int[] prices) {
        int n = prices.Length;
        int profit = 0;
        for(int i=0; i<n-1;i++)
        {
            int buy = prices[i];
            for(int j=i+1;j<n;j++)
            {
                int sell = prices[j];
                if(prices[j]>prices[i])
                {
                    profit=Math.Max(profit,sell-buy);
                    
                }
            }
        }
        return profit;
    }
}
