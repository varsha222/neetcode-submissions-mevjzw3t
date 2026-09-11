public class Solution {
    public int MaxLengthBetweenEqualCharacters(string s) {
        
        int maxl=0;
        bool eq = false;
        for(int i=0;i<s.Length;i++)
        {
            int l=0;
            for(int j=i+1;j<s.Length;j++)
            {
                
                if(s[i]==s[j])
                {
                    eq=true;
                    l=j-i-1;
                }
                
            }
            maxl=Math.Max(l,maxl);
            
        }
        if(eq==false)
        {

            return -1;
        }
        return maxl;
        
    }
}