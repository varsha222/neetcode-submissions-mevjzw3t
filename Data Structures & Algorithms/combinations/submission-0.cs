public class Solution {
    public List<List<int>> Combine(int n, int k) {
        List<List<int>> res= new List<List<int>>();
        Backtracking(n,k,res,new List<int>(),1);
        return res;
    }
    public void Backtracking(int n, int k, List<List<int>> res, List<int> temp, int start)
    {
       
        if(temp.Count==k)
            {
                res.Add(new List<int>(temp));
                return;
            }


       for(int i=start;i<=n;i++)
       {
            temp.Add(i);
            
            Backtracking(n,k,res,temp,i+1);
            temp.RemoveAt(temp.Count-1);
       }
       

    }
}