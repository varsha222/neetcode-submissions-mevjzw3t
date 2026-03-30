public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int n=nums.Length;
        Dictionary<int,int> map = new Dictionary<int,int>();
        //int [] res = new int[2];
        for(int i=0;i<n;i++)
        {
            int complement = target-nums[i];
            if(map.ContainsKey(complement))
            {
                
                int j = map[complement];
                return j < i ? new int[] { j, i } : new int[] { i, j };
            }
            if(!map.ContainsKey(nums[i]))
            {
                map[nums[i]]=i;
            }
        }
        return null;
        

    }
}
