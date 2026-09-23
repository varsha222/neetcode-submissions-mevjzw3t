public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        List<int[]> result = new List<int[]>();
        foreach(int[] interval in intervals)
        {
            if(interval[0]>newInterval[1])
            {
                result.Add(newInterval);
                newInterval=interval;
            }
            if(interval[1]<newInterval[0])
            {
                result.Add(interval);
            }
            else
            {
                newInterval[0]=Math.Min(interval[0],newInterval[0]);
                newInterval[1]=Math.Max(interval[1],newInterval[1]);
            }
        }
        result.Add(newInterval);
        return result.ToArray();
    }
}
