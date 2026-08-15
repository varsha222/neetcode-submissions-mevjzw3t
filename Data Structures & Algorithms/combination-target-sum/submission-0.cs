public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        var results = new List<List<int>>();
        Backtrack(nums, target, 0, new List<int>(), results);
        return results; 
    }
    private void Backtrack(int[] nums, int remaining, int start, List<int> path, List<List<int>> results)
    {
        if (remaining == 0)
        {
            results.Add(new List<int>(path));
            return;
        }
        if (remaining < 0) return;

        for (int i = start; i < nums.Length; i++)
        {
            path.Add(nums[i]);
            Backtrack(nums, remaining - nums[i], i, path, results);
            path.RemoveAt(path.Count - 1); 
        }
    }
    
   
}
