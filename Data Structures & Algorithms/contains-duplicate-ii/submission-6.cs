public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        for (int i = 0; i < nums.Length; i++) {
        // Only check the next k elements
            for (int j = i + 1; j <= i + k && j < nums.Length; j++) {
                if (nums[i] == nums[j]) {
                    return true;
                }
            }
        }
        return false;
            
}
}