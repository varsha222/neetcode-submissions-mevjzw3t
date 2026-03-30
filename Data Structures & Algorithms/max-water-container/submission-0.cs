public class Solution {
    public int MaxArea(int[] heights) {
        int res = 0;
        int l =0;
        int h = heights.Length-1;
        while(l<h)
        {
            int area = Math.Min(heights[l],heights[h])*(h-l);
            res=Math.Max(res,area);
            if(heights[l]<=heights[h])
            {
                l++;
            }
            else
            {
                h--;
            }
        }
        return res;
        
    }
}
