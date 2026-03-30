public class Solution {
    public int LengthOfLastWord(string s) {
        string x = s.Trim();
        int length=0;
        for(int i=0;i<x.Length;i++)
        {
            if(x[i]==' ')
            {
                length=0;
            }
            else
            {
                length++;
            }
        }
        return length;
    }
}