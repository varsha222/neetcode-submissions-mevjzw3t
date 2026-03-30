public class Solution {  
    public void Backtrack(int open, int close, int n, List<string> res,string stack)
    {
        if(open==close && open==n)
        {
            res.Add(stack);
            return;
        }
        if(open<n)
        {
            Backtrack(open+1,close,n,res,stack+'(');
        }
        if(close<open)
        {
            Backtrack(open,close+1,n,res,stack+')');
        }
    }
    public List<string> GenerateParenthesis(int n) {
        
        List<string> res = new List<string>();
        string stack="";
        Backtrack(0,0,n,res,stack);
        return res;

    }
}
