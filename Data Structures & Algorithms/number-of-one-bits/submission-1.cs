public class Solution {
    public int HammingWeight(uint n) {
        int cnt=0;
        while(n!=0)
        {
            cnt++;
            n=n&(n-1);
        }
        return cnt;
    }
}
