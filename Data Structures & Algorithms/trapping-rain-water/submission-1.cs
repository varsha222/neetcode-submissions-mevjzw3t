public class Solution {
    public int Trap(int[] height) {
        int l=0;
        int r=height.Length-1;
        int leftmax=height[l];
        int rightmax=height[r];
        int res=0;

        while(l<r)
        {
            if(leftmax<rightmax)
            {
                l++;
                leftmax=Math.Max(leftmax,height[l]);
                res=res+leftmax-height[l];
            }
            else
            {
                r--;
                rightmax=Math.Max(rightmax,height[r]);
                res=res+rightmax-height[r];
            }
        }
        return res;
    }
}
