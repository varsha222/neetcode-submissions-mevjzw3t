public class Solution {
    public int PivotIndex(int[] nums) {
        int total=0;
        foreach(int num in nums)
        {
            total=total+num;
        }
        int leftsum=0;
        for(int i =0;i<nums.Length;i++)
        {
            int rightsum=total-nums[i]-leftsum;
            if(leftsum==rightsum)
            {
                return i;
            }
            leftsum=leftsum+nums[i];
        }
        return -1;
    }
}