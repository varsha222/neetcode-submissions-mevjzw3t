public class Solution {
    List<string> res  = new List<string>();
    Dictionary<char,string> map = new Dictionary<char,string>{{'2',"abc"}, {'3', "def"}, {'4', "ghi"}, {'5', "jkl"},
        {'6', "mno"}, {'7', "qprs"}, {'8', "tuv"}, {'9', "wxyz"}
    };
    public List<string> LetterCombinations(string digits) {
        
        if(string.IsNullOrEmpty(digits))
        {
            return res;
        }
        Backtrack(digits,0,"");
        return res;
    }
    public void Backtrack(string digits, int index, string curr)
    {
        if(index==digits.Length)
        {
            res.Add(curr);
            return;
        }
        string letters = map[digits[index]];
        foreach(char ch in letters)
        {
            Backtrack(digits,index+1,curr+ch);
        }
    }
}
