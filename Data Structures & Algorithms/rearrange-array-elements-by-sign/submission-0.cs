public class Solution {
    public int[] RearrangeArray(int[] nums) {
        List<int> pos = new List<int>();
        List<int> neg = new List<int>();
        foreach(int i in nums)
        {
            if(i>0)
            {
                pos.Add(i);
            }
            else
            {
                neg.Add(i);
            }
        }
        int j = 0;
        List<int> res = new List<int>();
        while(j<pos.Count && j<neg.Count)
        {
            res.Add(pos[j]);
            res.Add(neg[j]);
            j++;

        }
        while(j<pos.Count)
        {
            res.Add(pos[j]);
            j++;
        }
        while(j<neg.Count)
        {
            res.Add(neg[j]);
            j++;
        }
        for(int i=0;i<nums.Length;i++)
        {
            nums[i]=res[i];
        }
        return nums;
    }
}