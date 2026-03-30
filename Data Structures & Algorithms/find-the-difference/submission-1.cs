public class Solution {
    public char FindTheDifference(string s, string t) {
       int[] count = new int[26];
       //int[] freqt = new freq[26];
       foreach(char ch in s)
        {
            count[ch - 'a']++;
        } 
       foreach(char ch in t)
       {
            if(count[ch-'a']==0)
            {
                return ch;
            }
            else
            {
                count[ch-'a']--;
            }
       }
       return ' ';
    }
}