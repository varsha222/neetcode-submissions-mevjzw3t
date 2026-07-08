public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int,int> freq = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++)
        {
            if(freq.ContainsKey(nums[i]))
            {
                return true;
            }
            else
            {
                freq[nums[i]]=1;
            }
        }
        return false;
    }
}