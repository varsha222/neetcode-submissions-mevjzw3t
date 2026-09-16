public class Solution {
    List<List<string>> res = new List<List<string>>();
    public List<List<string>> Partition(string s) {
        Backtrack(s,new List<string>(),0);
        return res;
        
    }
    public bool IsPalindrome(string s, int l,int r)
    {
        while(l<r)
        {
            if(s[l]!=s[r])
            {
                return false;
            }
            l++;
            r--;
        }
        return true;
    }
    public void Backtrack(string s, List<string> curr, int start)
    {
        if(start==s.Length)
        {
            res.Add(new List<string>(curr));
            return;
        }
        for(int end=start;end<s.Length;end++)
        {
            if(IsPalindrome(s,start,end))
            {
                curr.Add(s.Substring(start,end-start+1));
                Backtrack(s,curr,end+1);
                curr.RemoveAt(curr.Count-1);
            }
        }
        
    }
}
