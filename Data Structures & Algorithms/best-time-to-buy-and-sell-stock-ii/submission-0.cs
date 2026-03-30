public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0;
       for(int i =0 ; i<prices.Length-1;i++)
       {
            for(int j=i+1;j<prices.Length;j++)
            {
                if(prices[j]>prices[i])
                {
                    profit=profit+prices[j]-prices[i];
                    break;
                }
                else
                {
                    break;
                }
            }
       } 
       return profit;
    }
}