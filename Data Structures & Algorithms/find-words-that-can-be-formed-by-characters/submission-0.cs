public class Solution {
    public int CountCharacters(string[] words, string chars) {
        Dictionary<char,int>map=new Dictionary<char,int>();
        int l=0;

        foreach(char ch in chars)
        {
            if(map.ContainsKey(ch))
            {
                map[ch]=map[ch]+1;
            }
            else
            {
                map[ch]=1;
            }
        }

        foreach(string st in words)
        {
            bool flag=true;
            Dictionary<char,int> res = new Dictionary<char,int>();
            foreach(char ch in st)
            {
                if(res.ContainsKey(ch))
                {
                    res[ch]=res[ch]+1;
                }
                else
                {
                    res[ch]=1;
                }
            }
            foreach(char ch in st){
                if(!map.ContainsKey(ch) || map[ch]<res[ch])
                {
                    flag=false;
                    break;
                }
                
            }
            if(flag==true)
            {
                l=l+st.Length;
            }
            

        }

    return l;
        
    }
}