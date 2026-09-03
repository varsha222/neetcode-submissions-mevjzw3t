public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        Array.Sort(strs);
        int n=strs.Length;
        int l=strs[0].Length;
        StringBuilder sb = new StringBuilder();
        for(int i=0;i<l;i++)
        {
            if(strs[0][i]!=strs[n-1][i])
            {
                return sb.ToString();
            }
            sb.Append(strs[0][i]);
        }
        return sb.ToString();
    }
    
}