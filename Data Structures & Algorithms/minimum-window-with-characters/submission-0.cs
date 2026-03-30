public class Solution {
    public string MinWindow(string s, string t) {
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)) return ""; Dictionary<char, int> need = new Dictionary<char, int>(); foreach (char c in t) { if (!need.ContainsKey(c)) need[c] = 0; need[c]++; } Dictionary<char, int> have = new Dictionary<char, int>(); int required = need.Count; int formed = 0; int left = 0, right = 0; int minLen = int.MaxValue; int minLeft = 0; while (right < s.Length) { char c = s[right]; if (!have.ContainsKey(c)) have[c] = 0; have[c]++; if (need.ContainsKey(c) && have[c] == need[c]) formed++; while (left <= right && formed == required) { if (right - left + 1 < minLen) { minLen = right - left + 1; minLeft = left; } char lc = s[left]; have[lc]--; if (need.ContainsKey(lc) && have[lc] < need[lc]) formed--; left++; } right++; } return minLen == int.MaxValue ? "" : s.Substring(minLeft, minLen);
        
    }
}
