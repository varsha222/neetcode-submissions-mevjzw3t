public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
        Dictionary<int,string> map = new Dictionary<int,string>();
        for(int i=0;i<heights.Length;i++)
        {
            map[heights[i]]=names[i];
        }
        Array.Sort(heights);
        string[] res = new string[heights.Length];
        for(int i=0;i<heights.Length;i++)
        {
            res[i]=map[heights[heights.Length-1-i]];
        }
        return res;
    }
}