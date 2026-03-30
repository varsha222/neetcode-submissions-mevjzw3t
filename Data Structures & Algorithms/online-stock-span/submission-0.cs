public class StockSpanner {
    List<int> list;
    Stack<int> stack;
    public StockSpanner() {
       list = new List<int>(); 
       stack = new Stack<int>();
    }
    
    public int Next(int price) {
        list.Add(price);
        //int span = 1 ;
        while(stack.Count!=0 && list[stack.Peek()]<=price)
        {
            stack.Pop();
        }
        int previousgreatereindex = (stack.Count==0?-1:stack.Peek());
        int currentIndex = list.Count-1;
        int ans = currentIndex-previousgreatereindex;
        stack.Push(currentIndex);
        return ans;


    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */