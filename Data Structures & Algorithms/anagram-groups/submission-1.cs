public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var res = new Dictionary<string,List<string>>();
        foreach(var s in strs)
        {
            char[] chararray = s.ToCharArray();
            Array.Sort(chararray);
            string S = new string(chararray);
            if(!res.ContainsKey(S))
            {
                res[S]=new List<string>();
            }
            res[S].Add(s);
        }
        return res.Values.ToList<List<string>>();
    }
}
