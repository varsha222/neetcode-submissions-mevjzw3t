public class Solution {
    public List<int> FindClosestElements(int[] arr, int k, int x) {
        List<int> res = new List<int>();
        int l=0; 
        int r=arr.Length-k;
        while(l<r)
        {
            int m = (l+r)/2;
            if(x-arr[m]>arr[m+k]-x)
            {
                l=m+1;
            
            }
            else
            {
                r=m;
            }
        }
        for(int i = l;i<l+k;i++)
        {
            res.Add(arr[i]);
        }
        return res;
    }
}