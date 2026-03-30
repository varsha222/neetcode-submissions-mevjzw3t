public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int sum = 0;
        int l =0;
        int min_length=int.MaxValue;
        for(int r = 0; r<nums.Length;r++)
        {
            sum=nums[r]+sum;
            while(sum>=target)
            {
                min_length=Math.Min(min_length,r-l+1);
                sum=sum-nums[l];
                l++;
            }
            
        }
        return min_length == int.MaxValue?0:min_length;
    }
}