public class Solution {
    public int CountSeniors(string[] details) {
        int cnt=0;
        for(int i=0;i<details.Length;i++)
        {
            string str=details[i];
            string ph=str.Substring(0,10);
            string age=str.Substring(11,2);
            string seat=str.Substring(13,2);
            if(int.Parse(age)>60)
            {
                cnt++;
            }
        
        }
        
        
        
        return cnt;
    }
    
}

















