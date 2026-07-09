public class Solution {
    public int MajorityElement(int[] nums) {
        int major=nums.Length/2;
        Dictionary<int,int> freq=new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++)
        {
            if (freq.ContainsKey(nums[i]))
            {
                freq[nums[i]]++;
            }
            else
            {
                freq[nums[i]]=1;
            }
        

        }
        foreach(var data in freq)
        {
            if(data.Value>major)
            {
                return data.Key;
            }
        }
        return 0;
    }
}