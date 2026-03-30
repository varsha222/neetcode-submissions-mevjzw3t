public class Solution {
    public bool hasDuplicate(int[] nums) {
        int n = nums.Length;
        for(int i=0; i<n-1; i++)
        {
            int j=i+1;
            while(j<n)
            {
                if(nums[i]==nums[j])
                {
                    return true;
                }
                j++;
            }

        }

        return false;
        
    }
}