public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        Array.Sort(intervals,(a,b)=>a[1].CompareTo(b[1]));
        int revomecnt=0;
        int prevend=intervals[0][1];
        for(int i=1;i<intervals.Length;i++)
        {
            int start=intervals[i][0];
            int end=intervals[i][1];
            if(start<prevend)
            {
                revomecnt++;
            }
            else
            {
                prevend=end;
            }
        }
        return revomecnt;
        
       

    }
}
