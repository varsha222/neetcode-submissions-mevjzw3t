public class Solution {
    public int MaxDepth(string s) {
        int cnt=0;
        int maxcnt=0;
        Stack<char> depth = new Stack<char>();
        foreach(char ch in s)
        {
            if(ch=='(')
            {
                depth.Push(ch);
                cnt=Math.Max(cnt,depth.Count);
            }
            else if(ch==')')
            {
                depth.Pop();
            }
        }
        return cnt;
    }
}