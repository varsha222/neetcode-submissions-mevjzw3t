public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        foreach(string i in tokens)
        {
            
            if( i == "+")
            {
                int a = stack.Pop();
                int b = stack.Pop();
                stack.Push(a+b);
            }
            else if( i == "-")
            {
                int a = stack.Pop();
                int b = stack.Pop();
                stack.Push(b-a);
            }
            else if( i == "*")
            {
                stack.Push(stack.Pop()*stack.Pop());
            }
            else if( i == "/")
            {
                int a = stack.Pop();
                int b = stack.Pop();
                stack.Push((int)((double)b/a));
            }
            else
            {
                stack.Push(int.Parse(i));
            }

        }
        return stack.Pop();
    }
}
