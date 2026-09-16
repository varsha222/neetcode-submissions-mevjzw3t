public class Solution {
    List<string> res=new List<string>();
    public List<string> RestoreIpAddresses(string s) {
        Backtrack(s,new List<string>(),0);
        return res;
    }
    public bool IsValid(string s)
    {
        if(s.Length>1 && s[0]=='0')
        {
            return false;
        }
        long num=long.Parse(s);
        return num<=255;
    }

    public void Backtrack(string s, List<string>parts, int start)
    {
        if(parts.Count==4)
        {
            if(start==s.Length)
            {
                res.Add(string.Join(".",parts));
            }
            return;
        }
        for(int l=1;l<s.Length;l++)
        {
            if(start+l>s.Length)
            {
                break;
            }
            string segment = s.Substring(start,l);
            if(!IsValid(segment))
            {
                continue;
            }
            parts.Add(segment);
            Backtrack(s,parts,start+l);
            parts.RemoveAt(parts.Count-1);
        }
    }
}