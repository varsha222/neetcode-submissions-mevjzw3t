public class Solution
{
    List<List<int>> res = new List<List<int>>();
    public List<List<int>> CombinationSum2(int[] candidates, int target)
    {
        Array.Sort(candidates);
        Dfs(candidates,target,0,new List<int>());
        return res;
    }

    private void Dfs(int[] candidates, int target, int start, List<int> cur)
    {
        if(target == 0)
        {
            res.Add(new List<int>(cur));
            return;
        }
        if(target<0)
        {
            return;
        }
        for(int i=start;i<candidates.Length;i++)
        {
            if(i>start && candidates[i]==candidates[i-1])
            {
                continue;
            }
            cur.Add(candidates[i]);
            Dfs(candidates,target-candidates[i],i+1,cur);
            cur.RemoveAt(cur.Count-1);

        }
    }
}
