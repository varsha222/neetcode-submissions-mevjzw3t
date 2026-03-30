public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> nums1 = new HashSet<int>(nums);
        int count =0;
        foreach(int x in nums1)
        {
            if(!nums1.Contains(x-1))
            {
                int l =1;
                while(nums1.Contains(x+l))
                {
                    l++;
                }
                count = Math.Max(l,count);
            }
        }
        return count;
    }
}
