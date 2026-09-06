public class Solution {
    public List<string> StringMatching(string[] words) {
        List<string>res = new List<string>();
        int n = words.Length;
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            {
                if(i==j)
                {
                    continue;
                }
                if(words[j].Contains(words[i]))
                {
                    res.Add(words[i]);
                    break;
                }
            }
        }
        return res;
        
        }
        
        
        
    }

