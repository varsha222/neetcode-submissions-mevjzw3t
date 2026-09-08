public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        int n=0;
        HashSet<char> allowedset = new HashSet<char>(allowed);
        foreach(string st in words)
        {
            bool flag =true;
            foreach(char ch in st)
            {
                if(!allowedset.Contains(ch))
                {
                    flag=false;
                    break;
                }
            }
            if(flag==true)
            {
                n=n+1;
            }

        }
        return n;
    }
}