public class Solution {
    public bool MakeEqual(string[] words) {
        Dictionary<char,int> count = new Dictionary<char,int>();
        foreach(string st in words)
        {
            foreach(char ch in st)
            {
                if(count.ContainsKey(ch))
                {
                    count[ch]++;
                }
                else
                {
                    count[ch]=1;
                }
            }
        }
        foreach(int cnt in count.Values)
        {
            if(cnt%words.Length!=0)
            {
                return false;
            }
        }
        return true;
    }
}