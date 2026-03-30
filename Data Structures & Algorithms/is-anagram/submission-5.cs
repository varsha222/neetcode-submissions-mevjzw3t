public class Solution {
    public bool IsAnagram(string s, string t) {
        int n1=s.Length;
        int n2=t.Length;
        if(n1!=n2) return false;
        Dictionary<char,int> frequencyS = new Dictionary<char,int>();
        foreach(char x in s)
        {
            if(!frequencyS.ContainsKey(x))
            {
                frequencyS[x]=1;
            }
            else
            {
                frequencyS[x]++;
            }
        }
        //int cnt=1;
        foreach(char i in t)
        {
            if(frequencyS.ContainsKey(i))
            {
                frequencyS[i]--;
            }
        }
        foreach(var pair in frequencyS)
        {
            if(pair.Value!=0) return false;
        }
        return true;
    }
}
