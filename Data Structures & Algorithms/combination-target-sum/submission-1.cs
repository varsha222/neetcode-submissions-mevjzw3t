public class Solution {
    int sum=0;
    public List<List<int>> CombinationSum(int[] nums, int target) {
        List<List<int>> res = new List<List<int>>();
        Backtracking(nums,res,new List<int>(),0,target);
        return res;
    }
    public void Backtracking(int[] nums, List<List<int>> res, List<int> curr, int start,int remaining)
    {
        if(remaining == 0)
        {
            res.Add(new List<int>(curr));
            return;
        }

        if(remaining<0)
        {
            return;
        }
        for(int i=start;i<nums.Length;i++)
        {
            curr.Add(nums[i]);
            Backtracking(nums,res,curr,i,remaining-nums[i]);
            curr.RemoveAt(curr.Count-1);

        }
    }


}
