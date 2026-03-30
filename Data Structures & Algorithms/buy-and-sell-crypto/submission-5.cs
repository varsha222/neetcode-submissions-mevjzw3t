public class Solution {
    public int MaxProfit(int[] prices) {
        int left=0;
        int maxp = int.MinValue;
        for(int right=0;right<prices.Length;right++)
        {
            while(prices[right]<prices[left])
            {
                left++;
                
            }
            if(prices[right]>prices[left])
            {
               maxp=Math.Max(maxp,prices[right]-prices[left]);
            }
        }
        return maxp==int.MinValue?0:maxp;
    }
}