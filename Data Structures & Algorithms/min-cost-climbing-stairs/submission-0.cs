public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        if(cost.Length==1) return cost[0];
        int secondlast=cost[0];
        int last=cost[1];
        //int res=0;
        for(int i=2;i<cost.Length;i++)
        {
            int curr = cost[i]+Math.Min(secondlast,last);
            secondlast=last;
            last=curr;
        }
        return Math.Min(secondlast,last);
    }
}
