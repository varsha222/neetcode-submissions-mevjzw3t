public class Solution {
    public int MaxDifference(string s) {
        Dictionary<char,int> frequency = new Dictionary<char,int>();
        for(int i=0;i<s.Length;i++)
        {
            if(!frequency.ContainsKey(s[i]))
            {
                frequency[s[i]]=1;
            }
            else
            {
                frequency[s[i]]++;
            }
        }
        List<int> oddfreq= new List<int>();
        List<int> evenfreq=new List<int>();
        
        foreach(var pair in frequency)
        {
            if(pair.Value%2==0)
            {
                evenfreq.Add(pair.Value);
            }
            if(pair.Value%2!=0)
            {
                oddfreq.Add(pair.Value);
            }
        }
        int maxdiff=int.MinValue;
        foreach(int i in oddfreq)
        {
            foreach(int j in evenfreq)
            {
                maxdiff=Math.Max(maxdiff,(i-j));
            }
        }
        return maxdiff;
        
    }
}