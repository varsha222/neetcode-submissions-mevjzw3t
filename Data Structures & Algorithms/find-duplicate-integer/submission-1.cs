public class Solution {
    public int FindDuplicate(int[] nums) {
        HashSet<int> duplicate = new HashSet<int>();
        for(int i=0; i<nums.Length;i++)
        {
            if(duplicate.Contains(nums[i]))
            {
                return nums[i];
            }
            else
            {
                duplicate.Add(nums[i]);
            }
        }
        return 0;
    }
}
