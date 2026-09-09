public class Solution {
    public bool IsPathCrossing(string path) {
        var visits = new HashSet<string>();
        int x=0;
        int y=0;

        visits.Add($"{x},{y}");

        foreach(char ch in path)
        {
            if(ch=='N')
            {
                y++;
            }
            else if(ch=='S')
            {
                y--;
            }
            else if(ch=='E')
            {
                x++;
            }
            else if(ch=='W')
            {
                x--;
            }
            if(visits.Contains($"{x},{y}"))
            {
                return true;
            }
            visits.Add($"{x},{y}");
        }
        
        return false;
    }
}