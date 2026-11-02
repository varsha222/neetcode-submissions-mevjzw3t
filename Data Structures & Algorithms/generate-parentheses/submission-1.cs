public class Solution {  
    public List<string> GenerateParenthesis(int n) {
        List<string> res = new List<string>();
        string stack = "";
        backtrack(0,0,n,res,stack);
        return res;
    }
    public void backtrack(int open,int close,int n,List<string>res,string stack)
    {
        if(open==close && open==n)
        {
            res.Add(stack);
            return;
        }
        if(open<n)
        {
            backtrack(open+1,close,n,res,stack+'(');
        }
        if(close<open)
        {
            backtrack(open,close+1,n,res,stack+')');
        }

    }
}
