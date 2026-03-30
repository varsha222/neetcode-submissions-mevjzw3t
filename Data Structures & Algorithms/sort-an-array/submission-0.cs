public class Solution {
    public void simple_merge(int[] arr, int low,int mid, int high)
    {
        int i=low;
        int j=mid+1;
        int n=high-low+1;
        int k=0;
        int [] res = new int[n];
        while(i<=mid && j<=high)
        {
            if(arr[i]<arr[j])
            {
                res[k]=arr[i];
                i++;
                k++;
            }
            else
            {
                res[k]=arr[j];
                j++;
                k++;
            }
        }
        while(i<=mid)
        {
            res[k]=arr[i];
            i++;
            k++;
        }
        while(j<=high)
        {
            res[k]=arr[j];
            j++;
            k++;
        }
        for(int l=0;l<n;l++)
        {
            arr[low+l]=res[l];
        }
        
    }
    public void SortArrayRecur(int[] arr, int low, int high)
    {
        if(low==high)
        {
            return;
        }
        int middle = (low+high)/2;
        SortArrayRecur(arr,low, middle);
        SortArrayRecur(arr,middle+1,high);
        simple_merge(arr,low,middle,high);
    }
    public int[] SortArray(int[] nums) {
        int n=nums.Length;
        int low=0;
        int high=n-1;
        SortArrayRecur(nums,low,high);
        return nums;

    }
}