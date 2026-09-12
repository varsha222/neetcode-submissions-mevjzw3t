public class Solution {
    public int MinOperations(string[] logs) {
        int op=0;

        for(int i=0;i<logs.Length;i++)
        {
            if(logs[i]=="./")
            {
              continue;
            }
            if(logs[i]=="../")
            {
                op=Math.Max(0,op-1);
            }
            else
            {
                op++;
            }
            
        }
        return op;
        
    }
}