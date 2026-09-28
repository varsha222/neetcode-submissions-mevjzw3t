public class Solution {
    public string AddBinary(string a, string b) {
        long x = Convert.ToInt64(a,2);
        long y = Convert.ToInt64(b,2);
        while(y!=0)
        {
            long carry = (x&y)<<1;
            x=x^y;
            y=carry;
        }
        return Convert.ToString(x, 2);
        
    }
}