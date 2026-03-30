public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        int i=0;
        while(i<nums.Length)
        {
            int j =i+1;
            while(j<nums.Length)
            {
                if(nums[i]==nums[j] && Math.Abs(i-j)<=k)
                {
                    return true;
                }
                j++;
            }
            
            i++;
        }
        return false;
}
}