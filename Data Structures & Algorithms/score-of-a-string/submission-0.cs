public class Solution {
    public int ScoreOfString(string s) {
        int score=0;
        for(int i = 0;i<s.Length-1;i++)
        {
            score=score+Math.Abs((int)s[i]-(int)s[i+1]);
        }
        return score;
    }
}