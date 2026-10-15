public class Solution {
    public int Rob(int[] nums) {
        int n=nums.Length;
        if(n<2)
        {
            return nums[0];
        }
        int[] dp1 = new int[n-1];
        int[] dp2 = new int[n-1];
        for(int i=0;i<n-1;i++)
        {
            dp1[i]=nums[i];
            dp2[i]=nums[i+1];
        }
        return Math.Max(houseRob(dp1),houseRob(dp2));

    }
    public int houseRob(int[] nums)
    {
        int n=nums.Length;
        if(n<2)
        {
            return nums[0];
        }
        int[] dp = new int[n];
        dp[0]=nums[0];
        dp[1]=Math.Max(dp[0],nums[1]);
        for(int i=2;i<n;i++)
        {
            dp[i]=Math.Max(dp[i-2]+nums[i],dp[i-1]);
        }
        return dp[n-1];
    }
}
