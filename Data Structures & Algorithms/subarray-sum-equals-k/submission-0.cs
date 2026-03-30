public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int n = nums.Length;
        int cnt=0;
        //int sum = nums[0];
        for(int i=0; i<n;i++)
        {
           int sum = nums[i];
           if(nums[i]==k)
            {
                cnt++;
            }
            for(int j=i+1; j<n;j++)
            {
                sum=sum+nums[j];
                if(sum==k)
                {
                    cnt++;
                }

            }
           
        }
        return cnt;
    }
}