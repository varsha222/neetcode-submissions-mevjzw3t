public class Solution {
    public string ConvertToTitle(int columnNumber) {
        StringBuilder sb = new StringBuilder();
        while(columnNumber>0)
        {
            columnNumber=columnNumber-1;
            char ch=(char)('A'+columnNumber%26);
            sb.Insert(0,ch);
            columnNumber=columnNumber/26;

        }
        return sb.ToString();
        
    }
}