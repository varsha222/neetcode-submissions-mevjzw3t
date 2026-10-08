public class Solution {
    public int CoinChange(int[] coins, int amount) {
        if(amount<1)
        {
            return 0;
        }
        int n=coins.Length;
        int[] dp = new int[amount+1];
        for(int i=1;i<=amount;i++)
        {
            dp[i]=int.MaxValue;
            foreach(int coin in coins)
            {
                if(coin<=i && dp[i-coin]!=int.MaxValue)
                {
                    dp[i]=Math.Min(dp[i],1+dp[i-coin]);
                }
            }
            
        }
        if(dp[amount]==int.MaxValue)
            {
                return -1;
            }
        return dp[amount];
    }
}
