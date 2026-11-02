public class Solution {
    public List<List<int>> Combine(int n, int k) {
        List<List<int>> res= new List<List<int>>();
        Backtracking(n,k,res,new List<int>(),1);
        return res;
    }
    public void Backtracking(int n, int k, List<List<int>> res, List<int> temp, int start)
    {
       if(k==0)
       {
            res.Add(new List<int>(temp));
            return;
       }
       if(start>n)
       {
            return;
       }
       temp.Add(start);
       Backtracking(n,k-1,res,temp,start+1);
       temp.RemoveAt(temp.Count-1);
       Backtracking(n,k,res,temp,start+1);


    }
}