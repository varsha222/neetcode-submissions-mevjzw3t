public class Solution {
    public int RemoveDuplicates(int[] nums) {
        
        HashSet<int> res = new HashSet<int>();
        int idx=0;
        for(int i =0; i<nums.Length;i++)
        {
            if(!res.Contains(nums[i]))
            {
                res.Add(nums[i]);
                nums[idx]=nums[i];
                idx++;
            }
        }
        
        return idx;

    }
}