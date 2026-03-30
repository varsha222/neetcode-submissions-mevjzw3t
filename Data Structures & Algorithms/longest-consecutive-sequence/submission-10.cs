public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length==0)
        {
            return 0;
        }
        Array.Sort(nums);
        int res = 0, count =0, curr = nums[0], i=0;
        while(i<nums.Length)
        {
            if(curr!=nums[i])
            {
                curr = nums[i];
                count = 0;
            }
            while(i<nums.Length && nums[i]==curr)
            {
                i++;
            }
            count++;
            curr++;
            res = Math.Max(res, count);
        }
        return res;
        
    }
}
