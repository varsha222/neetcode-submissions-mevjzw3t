public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        
        Stack<int> stack = new Stack<int>();
        int n = temperatures.Length;
        int[] res = new int[n];
        //int i = 1;
        for(int i = 0; i<n;i++)
        {
            while(stack.Count!=0 && temperatures[stack.Peek()]<temperatures[i])
            {
                res[stack.Peek()]=i-stack.Peek();
                stack.Pop();
            }
            stack.Push(i);
        }
        return res;
    }
}
