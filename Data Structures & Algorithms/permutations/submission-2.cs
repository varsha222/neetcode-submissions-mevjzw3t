public class Solution {
    List<List<int>> res = new List<List<int>>();
    public List<List<int>> Permute(int[] nums) {
        subset(nums,new List<int>());
        return res;
        
    }
    public void subset(int[] nums, List<int>temp)
    {
       if(temp.Count==nums.Length)
       {
            res.Add(new List<int>(temp));
            return;
       }
       foreach(int num in nums)
       {
            if(temp.Contains(num))
            {
                continue;
            }
            temp.Add(num);
            subset(nums,temp);
            temp.RemoveAt(temp.Count-1);
       }

       
    }
}
