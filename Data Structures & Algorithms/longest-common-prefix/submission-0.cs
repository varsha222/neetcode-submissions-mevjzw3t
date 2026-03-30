public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        Array.Sort(strs);
        int n = strs.Length;
        string First = strs[0];
        string Last = strs[n-1];
        int minLength = Math.Min(First.Length,Last.Length);
        int i = 0;
        while(i<minLength && First[i]==Last[i])
        {
            i++;
        }
        return First.Substring(0,i);
    }
}