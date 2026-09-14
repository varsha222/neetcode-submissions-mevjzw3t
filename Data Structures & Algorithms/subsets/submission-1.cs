public class Solution
{
    public List<List<int>> Subsets(int[] nums)
    {
        List<List<int>> res = new List<List<int>>();
        BackTracking(nums, new List<int>(), res,0);
        return res;
    }

    public void BackTracking(int[] nums, List<int> curr,List<List<int>> res, int start)
    {
        res.Add(new List<int>(curr));
        for(int i=start;i<nums.Length;i++)
        {
            curr.Add(nums[i]);
            BackTracking(nums,curr,res,i+1);
            curr.RemoveAt(curr.Count-1);
        }
        
    }

    
    
}