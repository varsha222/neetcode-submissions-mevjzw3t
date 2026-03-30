public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> nums1 = new HashSet<int>(nums);
        int res=0;
        foreach( int x in nums1)
        {
            int curr = x;
            int count = 0;
            while(nums1.Contains(curr))
            {
                curr++;
                count++;
            }
            res = Math.Max(res,count);
        }
        return res;
        
    }
}
