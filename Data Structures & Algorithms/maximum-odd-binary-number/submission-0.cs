public class Solution {
    public string MaximumOddBinaryNumber(string s) {
        int cnt=0;
        foreach(char ch in s)
        {
            if(ch=='1')
            {
                cnt++;
            }
        }
        return new string('1',cnt-1)+new string('0',s.Length-cnt)+"1";

    }
}