public class Solution {
    public int PivotIndex(int[] nums) {
        
        for(int i=0;i<nums.Length;i++)
        {
            int leftsum=0;
            int rightsum=0;
            int pivot = i;
            for(int j=i+1;j<nums.Length;j++)
            {
                rightsum=rightsum+nums[j];
            }
            for(int k=0;k<i;k++)
            {
                leftsum=leftsum+nums[k];
            }
            if(rightsum==leftsum)
            {
                return pivot;
            }
        }
        return -1;
    }
}