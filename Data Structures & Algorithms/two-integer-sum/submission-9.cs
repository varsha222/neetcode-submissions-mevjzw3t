public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] res= new int[2];
        for(int i=0;i<nums.Length;i++)
        {
            int newtarget=target-nums[i];
            for(int j=0;j<nums.Length;j++)
            {
                if(i==j)
                {
                    continue;
                }
                if(nums[j]==newtarget)
                {
                    res[0]=i;
                    res[1]=j;
                    return res;
                }
            }
        }
        return res;
    }
}

