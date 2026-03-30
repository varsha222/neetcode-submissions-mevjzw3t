public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> freq = new Dictionary<int,int>();
        //List<int[]> arr = new List<int[]>();
        foreach(int num in nums)
        {
            if(freq.ContainsKey(num))
            {
                freq[num]++;
            }
            else
              freq[num] = 1;
        }
        List<int[]> arr = freq.Select(entry => new int[]{entry.Value,entry.Key}).ToList();
        arr.Sort((a,b)=> b[0].CompareTo(a[0]));
        int[] res = new int[k];
        for(int j =0; j<k; j++)
        {
            res[j] = arr[j][1];

        }
        return res;
        
    }
}
