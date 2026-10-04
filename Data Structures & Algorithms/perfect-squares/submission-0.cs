public class Solution {
    public int NumSquares(int n) {
        int[] dp =new int[n+1];
        dp[0]=0;
        for(int i=1;i<=n;i++)
        {
            dp[i]=int.MaxValue;

            for(int j=1;j*j<=i;j++)
            {
                int square =j*j;
                dp[i]=Math.Min(dp[i],dp[i-square]+1);
            }
        }
        return dp[n];
    }
}