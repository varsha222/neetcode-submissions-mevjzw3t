public class Solution {
    public int RemoveDuplicates(int[] nums) {
        List<int> res = new List<int>();
        HashSet<int> freq = new HashSet<int>();
        int idx=0;
        for(int i=0;i<nums.Length;i++)
        {
            if(!freq.Contains(nums[i]))
            {
                freq.Add(nums[i]);
                nums[idx]=nums[i];
                idx++;
            }
        }
        return idx;
    }
}