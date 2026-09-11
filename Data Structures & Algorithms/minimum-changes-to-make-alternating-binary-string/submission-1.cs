public class Solution {
    public int MinOperations(string s) {
        int startWith0 = 0;
        int startWith1 = 0;
        for(int i=0;i<s.Length;i++)
        {
            char expectedzero = (i % 2 == 0) ? '0' : '1';
            char expectedone = (i % 2 == 0) ? '1' : '0';
            if(s[i]!=expectedzero)
            {
                startWith0++;
            }
            if(s[i]!=expectedone)
            {
               startWith1++;
            }
        }

        return Math.Min(startWith0,startWith1);
    }
}