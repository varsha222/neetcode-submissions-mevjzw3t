public class Solution {
    public int Rob(int[] nums) {
        int n = nums.Length;
        if(n<2)
        {
            return nums[0];
        }
        int[] dpsf = new int[n-1];
        int[] dpsl = new int[n-1];
        for(int i=0;i<n-1;i++)
        {
            dpsl[i]=nums[i];
            dpsf[i]=nums[i+1];
        }
        int rob1 = houseRob(dpsl);
        int rob2 = houseRob(dpsf);

        int res = Math.Max(rob1,rob2);
        return res;


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
