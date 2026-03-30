public class Solution {
    public int Reverse(int x) {
        const int MIN = -2147483648;
        const int MAX = 2147483647;
        int rev=0;
        while(x!=0)
        {
            int r=x%10;
            x=x/10;
            if(rev>MAX/10 || (rev==MAX/10 && rev>MAX%10))
            {
                return 0;
            }
            if(rev<MIN/10 || (rev==MIN/10 && rev<MIN%10))
            {
                return 0;
            }
            rev=rev*10+r;
        }
        return rev;
    }
}
