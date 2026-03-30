public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        
        int[] arr = new int[nums.Length];
        int n = arr.Length;
        //int i = 0;
        //int prod = 1;
        for(int i =0;i<n;i++)
        {
            int prod = 1;
            for(int j = 0;j<n;j++)
            {
                if(i!=j)
                {
                    prod=prod*nums[j];
                }
            }
            arr[i]=prod;
        }
        return arr;
    }
}
