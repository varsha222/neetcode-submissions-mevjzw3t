public class Solution {
    public int RemoveElement(int[] nums, int val) {
       //List<int> newlist = new List<int>();
       int n = nums.Length;
       int k=0;
       for(int i=0;i<n;i++)
       {
            if(nums[i]!= val)
                {
                    nums[k]=nums[i];
                    k++;
            
                }
       }
       return k;
    }
}