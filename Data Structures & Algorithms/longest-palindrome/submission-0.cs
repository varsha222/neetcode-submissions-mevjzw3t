public class Solution {
    public int LongestPalindrome(string s) {
        Dictionary<char,int> map = new Dictionary<char,int>();
        foreach(char ch in s)
        {
            if(map.ContainsKey(ch))
            {
                map[ch]++;
            }
            else
            {
                map[ch]=1;
            }


            
        }

        int res=0;
        foreach(int cnt in map.Values)
        {
            res=res+(cnt/2)*2;
            if(res % 2==0 && cnt % 2==1)
            {
                res++;
            }
        }
        return res;
    }
}