public class Solution {
    public void swap(int[] arr, int i, int j)
    {
        int temp;
        temp=arr[i];
        arr[i]=arr[j];
        arr[j]=temp;
    }
    public int Partition_key(int[] arr, int low, int high)
    {
        int i=low-1;
        int pivot = arr[high];
        for(int j=low; j<=high-1; j++)
        {
            if(arr[j]<pivot)
            {
                i++;
                swap(arr,i,j);
            }
        }
        swap(arr,i+1,high);
        return i+1;
    }
    public void SortArrayRecur(int[] arr, int l, int h)
    {
        if(l<h)
        {
            int k = Partition_key(arr,l,h);
            SortArrayRecur(arr,l,k-1);
            SortArrayRecur(arr,k+1,h);

        }
        
    }
    public int[] SortArray(int[] nums) {
        int low=0;
        int high=nums.Length-1;
        SortArrayRecur(nums,low,high);
        return nums;
    }
}