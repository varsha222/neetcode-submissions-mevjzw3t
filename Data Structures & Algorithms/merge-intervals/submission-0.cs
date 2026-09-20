public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals,(a,b)=>a[0].CompareTo(b[0]));
        List<int[]> result = new List<int[]>();
        foreach(int[] interval in intervals)
        {
            if(result.Count==0)
            {
                result.Add(interval);
            }
            else if(interval[0]<=result[result.Count-1][1])
            {
                result[result.Count - 1][1] = Math.Max(result[result.Count - 1][1], interval[1]);
            }
            else
            {
                result.Add(interval);
            }
        }
        return result.ToArray();
        
    }
}
