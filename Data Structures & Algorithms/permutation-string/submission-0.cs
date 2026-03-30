public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length>s2.Length)
        {
            return false;
        }
        int[] s1count = new int[26];
        int[] s2count = new int[26];
        for(int i =0; i<s1.Length;i++)
        {
            s1count[s1[i]-'a']++;
        }
        for(int i=0;i<s2.Length;i++)
        {
            s2count[s2[i]-'a']++;
            if(i>=s1.Length)
            {
                s2count[s2[i-s1.Length]-'a']--;
            }
            if(AreEqual(s1count,s2count))
            {
                return true;
            }
        }
        return false;
        
    }

    private bool AreEqual(int[] a, int[] b)
    {
        for (int i = 0; i < 26; i++)
        {
            if (a[i] != b[i])
                return false;
        }
        return true;
    }
}

