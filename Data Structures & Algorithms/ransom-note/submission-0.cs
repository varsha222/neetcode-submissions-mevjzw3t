public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        int[] freqmagazine = new int[26];
        foreach(char ch in magazine)
        {
            freqmagazine[ch-'a']++;
        }

        foreach(char ch in ransomNote)
        {
            if(freqmagazine[ch-'a']==0)
            {
                return false;
            }
            freqmagazine[ch-'a']--;
        }
        
        return true;
    }
}