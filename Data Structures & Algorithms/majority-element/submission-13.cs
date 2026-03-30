public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int,int> frequency = new Dictionary<int,int>();
        for(int i =0; i<nums.Length;i++)
        {
            if(!frequency.ContainsKey(nums[i]))
            {
                frequency[nums[i]]=1;
            }
            else
            {
                frequency[nums[i]]++;
            }
        }
        foreach(var pair in frequency)
        {
            if(pair.Value>(nums.Length/2))
            {
                return pair.Key;
            }
            
        }
        return 0;
    }
}