public class Solution {
    public List<string> StringMatching(string[] words) {
        return words.Where(w=>words.Any(other=>other!=w && other.Contains(w))).ToList();
    }
}