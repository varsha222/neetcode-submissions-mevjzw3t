public class Solution {
    public int MinimumRecolors(string blocks, int k) {
        
        int cnt=0;

        for(int i=0;i<k;i++)
        {System.Console.WriteLine(blocks[i]);
            if(blocks[i]=='W')
            {
                cnt++;
            }
        }
        int mincnt=cnt;
        for(int i=k;i<blocks.Length;i++)
        {
            if(blocks[i-k]=='W')
            {
                cnt--;
            }
            if(blocks[i]=='W')
            {
                cnt++;
            }
            
            mincnt = Math.Min(mincnt,cnt);
        }
        return mincnt;
    
    }
}