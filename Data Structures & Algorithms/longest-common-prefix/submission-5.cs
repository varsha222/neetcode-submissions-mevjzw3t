public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        Array.Sort(strs);
        string first=strs[0];
        string last=strs[strs.Length-1];
        int l=0;
        for(int i=0;i<first.Length;i++)
        {
            if(first[i]==last[i])
            {
                l++;
            }
            else
            {
                break;
            }
        }
        return first.Substring(0,l);
    }
}