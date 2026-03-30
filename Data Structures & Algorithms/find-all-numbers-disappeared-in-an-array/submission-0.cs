public class Solution {
    public List<int> FindDisappearedNumbers(int[] nums) {
        HashSet<int> res = new HashSet<int>();
        for(int i=1;i<=nums.Length;i++)
        {
            res.Add(i);
        }
        for(int j=0;j<nums.Length;j++)
        {
            res.Remove(nums[j]);
        }
        return new List<int>(res);
    }
}