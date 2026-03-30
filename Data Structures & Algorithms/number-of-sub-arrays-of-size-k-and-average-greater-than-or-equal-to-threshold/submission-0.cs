public class Solution {
    public int NumOfSubarrays(int[] arr, int k, int threshold) {
        int sum=0;
        int avg;
        for(int i=0;i<k;i++)
        {
            sum=sum+arr[i];
        }
        
        int cnt=0;
        if(sum >= threshold * k)
        {
            cnt++;
        }
        for(int i=k;i<arr.Length;i++)
        {
            sum=sum+arr[i]-arr[i-k];
            if(sum >= threshold * k)
            {
                cnt++;
            }
        }
        return cnt;
    }
}