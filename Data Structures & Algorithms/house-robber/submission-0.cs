public class Solution {
    public int Rob(int[] nums) {
        int n=nums.Length;
        if(n==0) return 0;
        if(n==1) return nums[0];
        int secondlast=0;
        int last=nums[0];
        int res=0;
        for(int i=1;i<nums.Length;i++)
        {
            res=Math.Max(nums[i]+secondlast,last);
            secondlast=last;
            last=res;
        }
        return res;
    }
}
