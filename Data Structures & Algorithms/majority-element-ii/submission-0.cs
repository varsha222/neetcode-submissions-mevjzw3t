public class Solution {
    public List<int> MajorityElement(int[] nums) {
        int n = nums.Length;
        Dictionary<int,int> freq = new Dictionary<int,int>();
        List<int> res = new List<int>();
        foreach(int x in nums)
        {
            if(!freq.ContainsKey(x))
            {
                freq[x]=1;
            }
            else
            freq[x]+=1;
        }
        foreach( var entry in freq)
        {
            if(entry.Value > n/3)
            {
                res.Add(entry.Key);
            }
        }
        return res;

    }
}