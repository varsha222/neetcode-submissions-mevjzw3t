public class Solution {
    List<List<int>> res = new List<List<int>>();
    public List<List<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums);
        subset(nums,new List<int>(),0);
        return res;
    }
    public void subset(int[] nums, List<int>temp,int start)
    {
       
        res.Add(new List<int>(temp));
        for(int i=start;i<nums.Length;i++)
        {
            if(i>start && nums[i]==nums[i-1])
            {
                continue;
            }
            temp.Add(nums[i]);
            subset(nums,temp,i+1);
            temp.RemoveAt(temp.Count-1);
        }

    }
}
