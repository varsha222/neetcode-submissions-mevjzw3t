public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int n1=word1.Length;
        int n2=word2.Length;
        int n=Math.Max(n1,n2);
        string res="";
        for(int i=0;i<n;i++)
        {
            if(i<n1)
            {
                res=res+word1[i];
            }
            if(i<n2)
            {
                res=res+word2[i];
            }

        }
        return res;
    }
}