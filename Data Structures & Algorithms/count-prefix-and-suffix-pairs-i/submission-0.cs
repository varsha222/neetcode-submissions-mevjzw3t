public class Solution {
    public int CountPrefixSuffixPairs(string[] words) {
        int cnt=0;
        for(int i=0;i<words.Length;i++)
        {
            for(int j=i+1;j<words.Length;j++)
            {

                if(isPrefixAndSuffix(words[i],words[j]))
                {
                    cnt++;
                }
            }
        }
        return cnt;
    }
    public bool isPrefixAndSuffix(string st1,string st2)
    {
        if(st1.Length>st2.Length)
        {
            return false;
        }
        
        return st2.StartsWith(st1) && st2.EndsWith(st1);
    }
}