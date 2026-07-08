public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int n=nums.Length;
        int[] ans = new int[2*n];
        for(int j=0;j<n;j++)
        {
            ans[j]=ans[n+j]=nums[j];
        }
        return ans;
    }
}