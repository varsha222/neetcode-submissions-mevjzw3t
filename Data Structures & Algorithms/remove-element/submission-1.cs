public class Solution {
    public int RemoveElement(int[] nums, int val) {
        List<int> expectednums = new List<int>();
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]!=val)
            {
                expectednums.Add(nums[i]);
            }

        }
        for(int i=0;i<expectednums.Count;i++)
        {
            nums[i]=expectednums[i];
        }
        return expectednums.Count;
    }
}