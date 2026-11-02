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
        if(s.Length==start)
        {
            res.Add(new List<string>(curr));
            return;
        }
        for(int i=start;i<s.Length;i++)
        {
            if(IsPalindrome(s,start,i))
            {
                curr.Add(s.Substring(start,i-start+1));
                Backtrack(s,curr,i+1);
                curr.RemoveAt(curr.Count-1);
            }
        }
        
    }
}
