public class Solution {
    public int MaxScore(string s) {
        int zero=0;
        int one=0;
        int res=0;
        foreach(char ch in s)
        {
            if(ch=='1')
            {
                one++;
            }
        }
        for(int i=0;i<s.Length-1;i++)
        {
            if(s[i]=='0')
            {
                zero++;
            }
            else
            {
                one--;
            }
            res=Math.Max(res,one+zero);
        }
        return res;
        
        
        
        
    }
}