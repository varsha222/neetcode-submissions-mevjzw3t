public class Solution {
    public int MaxProfit(int[] prices) {
        int left=0;
        int right=1;
        int MaxProfit = 0;
        while(right < prices.Length)
        {
            if(prices[right]>prices[left])
            {
                MaxProfit=Math.Max(MaxProfit,(prices[right]-prices[left]));
            }
            else
            {
                left = right;
            }
            right++;
        }
        return MaxProfit;
        
    }
}