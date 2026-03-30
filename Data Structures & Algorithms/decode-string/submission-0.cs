public class Solution {
    public string DecodeString(string s) {
       Stack<int>numberstack = new Stack<int>();
       Stack<string>stringstack = new Stack<string>();
       string cur ="";
       int k = 0;
       foreach(char val in s)
       {
        if(char.IsDigit(val))
        {
            k = k*10+(val-'0');
        }
        
        else if(val=='[')
        {
            stringstack.Push(cur);
            numberstack.Push(k);
            cur="";
            k=0;
        }
        else if(val==']')
        {
            string temp = cur;
            cur=stringstack.Pop();
            int n = numberstack.Pop();
            for(int i=0;i<n;i++)
            {
                cur+=temp;
            }
        }
        else
        {
            cur=cur+val;
        }
        
       }
       return cur;
    }
}