public class Solution
{
    public List<List<int>> Subsets(int[] nums)
    {
        List<List<int>> resultSet = new List<List<int>>();

        BackTracking(resultSet, new List<int>(), nums, 0);

        return resultSet;
    }

    private void BackTracking(
        List<List<int>> resultSet,
        List<int> tempSet,
        int[] nums,
        int start)
    {
        resultSet.Add(new List<int>(tempSet));

        for (int i = start; i < nums.Length; i++)
        {
            tempSet.Add(nums[i]); 
            BackTracking(resultSet, tempSet, nums, i + 1); 

            tempSet.RemoveAt(tempSet.Count - 1); 
        }
    }
}