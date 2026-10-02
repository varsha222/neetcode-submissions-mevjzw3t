public class Solution {
    public bool WordBreak(string s, List<string> wordDict) {
        HashSet<string> dict = new HashSet<string>(wordDict);
        int maxl = 0;
        foreach(string st in dict)
        {
            int l=st.Length;
            maxl=Math.Max(maxl,l);
        }
        int n = s.Length;
        bool[] dp = new bool[n+1];
        dp[0]=true;

        for(int i=1;i<=n;i++)
        {
            for(int j=i-1; j>=Math.Max(0,i-maxl);j--)
            {
                if(dp[j] && dict.Contains(s.Substring(j,i-j)))
                {
                    dp[i]=true;
                    break;
                }
            }
        }
        return dp[n];
    }
}
