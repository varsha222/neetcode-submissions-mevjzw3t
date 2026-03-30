public class Solution {
    public int Trap(int[] height) {
        int l =0;
        int r = height.Length-1;
        int LeftMax = height[l];
        int RightMax = height[r];
        int res =0;
        while(l<r)
        {
            if(LeftMax<RightMax)
            {
                l++;
                LeftMax=Math.Max(LeftMax,height[l]);
                res = res+LeftMax-height[l];
            }
            else
            {
                r--;
                RightMax=Math.Max(RightMax,height[r]);
                res= res+RightMax-height[r];
            }
        }
        return res;
        
    }
}
