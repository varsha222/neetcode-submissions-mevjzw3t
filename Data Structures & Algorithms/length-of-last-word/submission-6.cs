public class Solution {
    public int LengthOfLastWord(string s) {
        string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int l = words.Length;
        return words[l-1].Length;
        
    }
}