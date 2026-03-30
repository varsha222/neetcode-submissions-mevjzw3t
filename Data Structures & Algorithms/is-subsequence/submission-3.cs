public class Solution {
    public bool IsSubsequence(string s, string t) {
        int m = s.Length;
        int n = t.Length;
        int i = 0;
        int j = 0;
        while(i<m && j<n)
        {
            if(s[i]==t[j])
            {
                i++;
            }
            j++;

        }
        return i==m;

    }
}