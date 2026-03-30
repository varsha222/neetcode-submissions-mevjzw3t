public class Solution {
    public int MajorityElement(int[] nums) {
        
        Array.Sort(nums);
        int n =nums.Length;
        int count = 0;
        int candidate = nums[n/2];

        foreach (int num in nums) {
            if (num==candidate) {
                count++;
            }
            
        }
        if(count>n/2)
        {
            return candidate;
        }

        return -1;
    }

        
    }
