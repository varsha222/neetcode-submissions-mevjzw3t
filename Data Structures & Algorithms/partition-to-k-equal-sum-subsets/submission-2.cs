public class Solution {
    public bool CanPartitionKSubsets(int[] nums, int k) {
        int sum = nums.Sum();
        if(sum%k!=0)
        {
            return false;
        }
        int target = sum/k;
        Array.Sort(nums);
        Array.Reverse(nums);
        int[] bucket = new int[k];
        return Backtrack(nums,0,bucket,target);
    }

    public bool Backtrack(int[] nums, int index,int[] bucket, int target)
    {
        if(index==nums.Length)
        {
            return true;
        }
        int num = nums[index];
        for(int i=0;i<bucket.Length;i++)
        {
            if(bucket[i]+num>target)
            {
                continue;
            }
            bucket[i]+=num;
            if(Backtrack(nums,index+1,bucket,target))
            {
                return true;
            }
            bucket[i]-=num;
            if(bucket[i]==0)
            {
                break;
            }
        }
        return false;
    }
}