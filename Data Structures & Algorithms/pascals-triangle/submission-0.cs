public class Solution {
    public List<List<int>> Generate(int numRows) {
        List<List<int>> res = new List<List<int>>();
        for(int row=0;row<numRows;row++)
        {
            List<int> arr=new List<int>();
            for(int i=0;i<=row;i++)
            {
                if(row==i||i==0)
                {
                    arr.Add(1);
                }
                else
                {
                    arr.Add(res[row-1][i-1]+res[row-1][i]);
                }
            }
            res.Add(arr);
        }
        return res;
    }
}