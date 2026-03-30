public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char,int> roman = new Dictionary<char,int>(){
            {'I',1},{'V',5},{'X',10},{'L',50},{'C',100},{'D',500},{'M',1000}
            };

        int result = 0;
        for(int i=0;i<s.Length;i++)
            {
                if(i+1<s.Length && roman[s[i+1]]>roman[s[i]])
                {
                    result=result-roman[s[i]];
                }
                else
                {
                    result=result+roman[s[i]];
                }
            }
        return result;
    }
        
}
