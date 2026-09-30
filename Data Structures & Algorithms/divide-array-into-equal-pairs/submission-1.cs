public class Solution {
    public bool DivideArray(int[] nums) {
        int n=nums.Length;
        int k=n/2;
        Dictionary<int,int> map= new Dictionary<int,int>();

        for(int i=0; i<nums.Length;i++)
        {
            if(map.ContainsKey(nums[i]))
            {
                map[nums[i]]++;
            }
            else
            {
                map[nums[i]]=1;
            }
        }

        foreach(int val in map.Values)
        {
            if(val%2!=0)
            {
                return false;
            }
        }

        return true;;
    }
}