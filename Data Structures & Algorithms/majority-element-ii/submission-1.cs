public class Solution {
    public List<int> MajorityElement(int[] nums) {
        Dictionary<int, int> count = new Dictionary<int, int>();
        List<int> res = new List<int>();
        int n = nums.Length;

        foreach (int num in nums) {
            if (!count.ContainsKey(num)) {
                count[num] = 0;
            }
            count[num]++;
        }

        foreach (var kvp in count) {
            if (kvp.Value > n / 3) {
                res.Add(kvp.Key);
            }
        }

        return res;
    }
}