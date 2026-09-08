public class Solution {
    public string LargestGoodInteger(string num) {
        string res = "0";
        for(int i=0;i<=num.Length-3;i++)
        { 
            if(num[i]==num[i+1] && num[i+1]==num[i+2])
            {
                string temp=num.Substring(i,3);
                if(string.Compare(temp,res)>0)
                {
                    res=temp;
                }
            }
            
        }
        return res=="0"?"":res;
        
    }
}