public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        
        List<int> res = new List<int>();
        int maxv = nums[0];
        for(int i=0;i<k;i++)
        {
            if(nums[i]>maxv)
            {
                maxv=nums[i];
            }
        }
        res.Add(maxv);

        for(int j=k;j<nums.Length;j++)
        {
            int st=j-k+1;
            int end=k+st;
            int maxn=nums[st];
            while(st<end)
            {
                if(nums[st]>maxn)
                {
                    maxn=nums[st];

                }
                st++;
            }
            res.Add(maxn);
        }
        return res.ToArray();
    }
}
