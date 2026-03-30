public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        
        Dictionary<int,int>freq= new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++)
        {
            if(freq.ContainsKey(nums[i]) && Math.Abs(freq[nums[i]]-i)<=k )
            {
                return true;
            }
            else
            {
                freq[nums[i]]=i;
            }
        }
        return false;
        
    }
}