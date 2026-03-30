public class Solution {
    public string SimplifyPath(string path) {
        Stack<string> stack = new Stack<string>();
        string[] parts = path.Split('/');
        foreach(string s in parts)
        {
            if(s=="..")
            {
                if(stack.Count>0)
                {
                    stack.Pop();
                }
                
            }
            else if( s!="" && s!=".")
                {
                    stack.Push(s);
                }
        }
        var result= new List<string>(stack);
        result.Reverse();
        return "/"+string.Join("/",result);
        
    }
}