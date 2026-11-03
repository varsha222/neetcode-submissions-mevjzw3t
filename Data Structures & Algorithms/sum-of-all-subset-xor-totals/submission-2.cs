public class Solution {
    int res=0;
    public int SubsetXORSum(int[] nums) {
        BackTrack(nums,new List<int>(),0);
        return res;
    }
    public void BackTrack(int[] nums, List<int>cur,int start)
    {
        int xor = 0;
        foreach(int num in cur)
        {
            xor=xor^num;
        }
        res=res+xor;
        for(int i=start;i<nums.Length;i++)
        {
            cur.Add(nums[i]);
            BackTrack(nums,cur,i+1);
            cur.RemoveAt(cur.Count-1);
        }
        

    }
}