public class Solution {
    public int CalPoints(string[] operations) {
       Stack<int> stack = new Stack<int>();
        foreach(string op in operations)
        {
            if(op=="C")
            {
                if(stack.Count>0)
                {
                    stack.Pop();
                }
            }
            else if(op=="D")
            {
                if(stack.Count>0)
                {
                    int top= stack.Peek();
                    top=top*2;
                    stack.Push(top);
                }
                

            }
            else if(op=="+")
            {
                if(stack.Count>=2)
                {
                    int top=stack.Pop();
                    int newtop = stack.Peek();
                    int sum=top+newtop;
                    stack.Push(top);
                    stack.Push(sum);
                }
                
            }
            else
            {
                stack.Push(int.Parse(op));
            }
        }
        int total=0;
        while(stack.Count!=0)
        {
            total=total+stack.Pop();
        }
        return total;
    }
}