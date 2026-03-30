public class Solution {
    public string MergeAlternately(string word1, string word2) {
        string word3="";
        int n1 = word1.Length;
        int n2 = word2.Length;
        int n3 = Math.Max(n1,n2);
        for(int i =0; i<n3;i++)
        {
            if(i<n1)
            {
               word3=word3+word1[i]; 
            }
            if(i<n2)
            {
                word3=word3+word2[i];
            }
            
        }
        return word3;

        
    }
}