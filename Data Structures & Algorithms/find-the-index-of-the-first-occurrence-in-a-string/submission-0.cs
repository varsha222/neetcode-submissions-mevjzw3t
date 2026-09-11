public class Solution {
    public int StrStr(string haystack, string needle)
    {
        int l = needle.Length;

        for(int i = 0; i <= haystack.Length - l; i++)
        {
            if(needle == haystack.Substring(i, l))
            {
                return i;
            }
        }

        return -1;
    }

}