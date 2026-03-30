public class Solution {
    public bool IsAnagram(string s, string t) {
        int n1 = s.Length;
        int n2 = t.Length;
        if(n1!=n2)
        {
            return false;
        }

        Dictionary<char, int> charCount = new Dictionary<char,int>();
        foreach (char ch in s) 
            charCount[ch] = 
                    charCount.GetValueOrDefault(ch, 0) + 1;
        foreach(char ch in t )
            charCount[ch]= charCount.GetValueOrDefault(ch,0) -1;

        foreach(var pair in charCount)
        {
            if(pair.Value!=0)
            {
                return false;
            }
        }
        return true;
        

    }
}
