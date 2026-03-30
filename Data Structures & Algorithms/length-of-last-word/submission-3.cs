public class Solution {
    public int LengthOfLastWord(string s) {
        string t=s.Trim();
        int i=t.Length-1;
        int l=0;
        while(i>=0)
        {
            if(t[i]!=' ')
            {
                l++;
                i--;
            }
            else
            {
                break;
            }
        }
        return l;
    }
}