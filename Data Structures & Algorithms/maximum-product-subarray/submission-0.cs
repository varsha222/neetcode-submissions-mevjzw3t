public class Solution {
    public int MaxProduct(int[] nums) {
        int n=nums.Length;
        int ans = int.MinValue;
        int leftmul = 1;
        int rightmul = 1;
        int left=0;
        int right=n-1;
        while(left<n && right>=0)
        {
            leftmul=leftmul==0?1:leftmul;
            rightmul=rightmul==0?1:rightmul;

            leftmul=leftmul*nums[left];
            rightmul=rightmul*nums[right];

            ans = Math.Max(ans,Math.Max(leftmul,rightmul));
            left++;
            right--;
        }
        return ans;

    }
}
