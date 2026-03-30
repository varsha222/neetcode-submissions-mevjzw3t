public class Solution {
    public int CharacterReplacement(string s, int k) {
      int res=0;
      int left=0;
      int maxcnt=0;
      int[] freq = new int[26];
      for(int right=0;right<s.Length;right++)
      {
        freq[s[right]-'A']++;
        maxcnt=Math.Max(maxcnt,freq[s[right]-'A']);
        while((right-left+1)-maxcnt>k)
        {
            freq[s[left]-'A']--;
            left++;
        }
        res=Math.Max(res,right-left+1);
      }
      return res;
          
    }
}