public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int max=0;
        int cnt=0;
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]==1)
            {
                cnt=cnt+1;
                max=Math.Max(cnt,max);
            }
            else
            {
                 cnt=0;
            }
              
        }
        return max;
    }
}