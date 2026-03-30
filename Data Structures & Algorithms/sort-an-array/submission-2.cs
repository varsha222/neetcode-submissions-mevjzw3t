public class Solution {
    private void Heapify(int[] arr, int n, int i)
    {
        int largest = i;
        int l = 2*i+1;
        int r = 2*i+2;
        if(l<n && arr[l]>arr[largest])
        {
            largest = l;
        }
        if(r<n && arr[r]>arr[largest])
        {
            largest = r;
        }
        if(largest!=i)
        {
            swap(arr,largest,i);
            Heapify(arr,n,largest);
        }
        

    }
    private void swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i]=arr[j];
        arr[j]=temp;
    }
    private void BuildHeap(int[] arr, int n)
    {
        int startidx = n/2-1;
        for(int i=startidx;i>=0;i--)
        {
            Heapify(arr,n,i);
        }
    }
    public int[] SortArray(int[] nums) {
        int n = nums.Length;
        //BuildHeap( nums, n);
        int startidx = n/2-1;
        for(int j=startidx;j>=0;j--)
        {
            Heapify(nums,n,j);
        }
        for( int i =n-1; i>=0;i--)
        {
            swap(nums,0,i);
            Heapify(nums,i,0);
        }
        return nums;
    }
}