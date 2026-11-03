public class Solution
{
    List<List<int>>res=new List<List<int>>();
    public List<List<int>> Subsets(int[] nums)
    {
       BackTracking(nums,new List<int>(),0);
       return res;
    }

    public void BackTracking(int[] nums, List<int> curr, int start)
    {
        res.Add(new List<int>(curr));

        for(int i=start;i<nums.Length;i++)
        {
            curr.Add(nums[i]);
            BackTracking(nums,curr,i+1);
            curr.RemoveAt(curr.Count-1);
        }
        
    }

    
    
}