public class Solution {
    public int NumDecodings(string s) {
        int n = s.Length;
        int[] dp = new int[n+1];
        dp[0]=1;
        dp[1]=s[0]=='0'?0:1;

        for(int i=2;i<=n;i++)
        {
            int onedigit = int.Parse(s.Substring(i-1,1));
            int twodigit = int.Parse(s.Substring(i-2,2));

            if(onedigit >=1)
            {
                dp[i]=dp[i]+dp[i-1];
            }
            if(twodigit >=10 && twodigit<=26)
            {
                dp[i]=dp[i]+dp[i-2];
            }
        }
        return dp[n];
    }
}
