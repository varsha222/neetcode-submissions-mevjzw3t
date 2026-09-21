public class Solution {
    List<List<int>> res = new List<List<int>>();
    public List<List<int>> PermuteUnique(int[] nums) {
        Array.Sort(nums);

        bool[] used = new bool[nums.Length];
        subset(nums,used,new List<int>());
        return res;
    }

    public void subset(int[] nums,bool[] used, List<int>temp)
    {
        if(temp.Count==nums.Length)
        {
            res.Add(new List<int>(temp));
        }
        for(int i=0;i<nums.Length;i++)
        {
            if(used[i])
            {
                continue;
            }
            if(i>0 && nums[i]==nums[i-1] && !used[i-1])
            {
                continue;
            }
            used[i]=true;
            temp.Add(nums[i]);
            subset(nums,used,temp);
            temp.RemoveAt(temp.Count-1);
            used[i]=false;
        }
       
    }
}