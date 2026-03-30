public class Solution {
    public bool IsSubsequence(string s, string t) {
        if (s.Length == 0) return true;
        if(t.Length<s.Length)
        {
            return false;
        }
        Stack<char> stack = new Stack<char>();
        int k=0;
        bool flag=false;
        for(int i=0;i<s.Length;i++)
        {
            int j=k;
            while(j<t.Length && s[i]!=t[j])
            {
                stack.Push(t[j]);
                j++;
            }
            if(j < t.Length && s[i]==t[j])
            {
                k=j+1;
                flag=true;
            }
            else
            {
                return false;
            }
            while(stack.Count>0)
            {
                stack.Pop();
            }

        }
        return flag;

    }
}