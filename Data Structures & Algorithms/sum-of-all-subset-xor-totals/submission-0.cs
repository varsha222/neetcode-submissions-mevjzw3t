public class Solution {
    int res=0;
    public int SubsetXORSum(int[] nums) {
        BackTrack(nums,new List<int>(),0);
        return res;
    }
    public void BackTrack(int[] nums, List<int>cur,int start)
    {
        int xorr = 0;
        foreach(int num in cur)
        {
            xorr^=num;
            
        }
        res=res+xorr;
        
        for(int j=start;j<nums.Length;j++)
        {
            cur.Add(nums[j]);
            BackTrack(nums,cur,j+1);
            cur.RemoveAt(cur.Count-1);
        }
        
    }
}