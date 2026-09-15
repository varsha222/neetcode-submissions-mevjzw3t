public class Solution {
    List<List<int>> res = new List<List<int>>();
    public List<List<int>> Permute(int[] nums) {
        subset(nums,new List<int>());
        return res;
        
    }
    public void subset(int[] nums, List<int>temp)
    {
        if(temp.Count==nums.Length)
        {
            res.Add(new List<int>(temp));
            return;
        }
        for(int i=0;i<nums.Length;i++)
        {
            if(temp.Contains(nums[i]))
            {
                continue;
            }
            temp.Add(nums[i]);
            subset(nums,temp);
            temp.RemoveAt(temp.Count-1);
        }

    }
}
