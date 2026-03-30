public class Solution {
    public int ScoreOfString(string s) {
        int sum=0;
        for(int i=0;i<s.Length;i++)
        {
            if(i+1<s.Length)
            {
                sum=sum+Math.Abs(s[i]-s[i+1]);
            }
            
        }
        return sum;
    }
}