public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int l =0;
        int r = nums.Length-1;
        int n = nums.Length ;
        
        while(l<=r)
        {
            int mid = (l+r)/2;
            if(target>nums[mid])
            {
                l=mid+1;

            }
            if(target<nums[mid])
            {
                n=mid;
                r=mid-1;
            }
            if(target==nums[mid])
            {
                return mid;
            }

        }
        return n;
    }
}