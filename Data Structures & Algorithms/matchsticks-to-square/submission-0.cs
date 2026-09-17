public class Solution {
    public bool Makesquare(int[] matchsticks) {
        int sum = matchsticks.Sum();
        int target=sum/4;
        if(sum%4!=0)
        {
            return false;
        }
        Array.Sort(matchsticks);
        Array.Reverse(matchsticks);
        int[] sides = new int[4];
        return Backtrack(matchsticks,target,0,sides);
    }
    public bool Backtrack(int[] matchsticks,int  target,int index,int[] sides)
    {
        if(index==matchsticks.Length)
        {
            return sides[0]==target && sides[1]==target && sides[2]==target && sides[3]==target;
        }
        int stick = matchsticks[index];
        for(int i=0;i<4;i++)
        {
            if(sides[i]+stick>target)
            {
                continue;
            }

            sides[i]=sides[i]+stick;
            if(Backtrack(matchsticks,target,index+1,sides))
            {
                return true;
            }
            sides[i]-=stick;
        }
        return false;
    }
}