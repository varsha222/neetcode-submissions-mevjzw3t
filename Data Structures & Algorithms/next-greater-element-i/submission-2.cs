public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        List<int> res = new List<int>();
        foreach(int num in nums1)
        {
            int index=Array.IndexOf(nums2,num);
            int nextGreater=-1;
            for(int i=index+1;i<nums2.Length;i++)
            {
                if(num<nums2[i])
                {
                    nextGreater=nums2[i];
                    break;
                }
            }
            res.Add(nextGreater);
        }
        return res.ToArray();
    }
}