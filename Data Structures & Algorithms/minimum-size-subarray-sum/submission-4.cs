public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int l=0;
        int minl=int.MaxValue;
        int sum=0;
        int left=0;
        for(int right=0;right<nums.Length;right++)
        {
            sum=sum+nums[right];
            while(sum>=target)
            {
                minl=Math.Min(right-left+1,minl);
                sum=sum-nums[left];
                left++;
            }
        }
        return minl == int.MaxValue ? 0 : minl;
    }
}