public class Solution {
    public int[] CountBits(int n) {
        int[] arr = new int[n+1];
        for(int num=1;num<=n;num++)
        {
            int i=num;
            int cnt=0;
            while(i!=0)
            {
                cnt++;
                i=i&(i-1);
            }
            arr[num]=cnt;
        }
        return arr;
    }
}
