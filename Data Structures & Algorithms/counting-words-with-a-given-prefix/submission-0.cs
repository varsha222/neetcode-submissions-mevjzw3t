public class Solution {
    public int PrefixCount(string[] words, string pref) {
        int cnt=0;
        foreach(string word in words)
        {
            if(word.StartsWith(pref))
            {
                cnt++;
            }
        }
        return cnt;
    }
}