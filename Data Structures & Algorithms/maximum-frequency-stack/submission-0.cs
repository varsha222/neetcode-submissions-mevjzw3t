public class FreqStack {
    private Dictionary<int,int> cnt;
    private Dictionary<int,Stack<int>> stacks;
    private int maxcnt;
    public FreqStack() {
        cnt = new Dictionary<int,int>();
        stacks = new Dictionary<int, Stack<int>>();
        maxcnt=0;
    }
    
    public void Push(int val) {
        int valcnt = cnt.ContainsKey(val)?cnt[val]+1:1;
        cnt[val]=valcnt;
        if(!stacks.ContainsKey(valcnt))
        {
            stacks[valcnt]=new Stack<int>();
        }
        stacks[valcnt].Push(val);
        if(valcnt>maxcnt)
        {
            maxcnt=valcnt;
        }
    }
    
    public int Pop() {
        int res = stacks[maxcnt].Pop();
        cnt[res]--;
        if (stacks[maxcnt].Count == 0) {
            maxcnt--;
    }
    return res;
}
}

/**
 * Your FreqStack object will be instantiated and called as such:
 * FreqStack obj = new FreqStack();
 * obj.Push(val);
 * int param_2 = obj.Pop();
 */