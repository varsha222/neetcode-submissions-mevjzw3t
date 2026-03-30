public class Solution {
    public int FindDuplicate(int[] nums) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++)
        {
            if(map.ContainsKey(nums[i]))
            {
                return nums[i];
            }
            else
            {
                map[nums[i]]=1;
            }
        }
        return -1;
    }
}
