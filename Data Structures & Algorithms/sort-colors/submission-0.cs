public class Solution {
    public int partition_key(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i=low-1;
        //int j=0;
        for(int j=low; j<=high-1;j++)
        {
            if(arr[j]<pivot)
            {
                i++;
                swap(arr,i,j);
            }
        }
        swap(arr, i+1,high);
        return i+1;

    }
    public void swap(int[] arr, int i, int j)
    {
        int temp=arr[i];
        arr[i]=arr[j];
        arr[j]=temp;
    }
    public void quicksortRecur(int[] arr, int low, int high)
    {
        if(low<high)
        {
            int k = partition_key(arr, low, high);
            quicksortRecur(arr, low, k-1);
            quicksortRecur(arr, k+1,high);

        }
        
    }
    public void quickSort(int[] arr)
    {
        int n = arr.Length;
        int high = n-1;
        int low=0;
        quicksortRecur(arr, low , n-1);

    }
    public void SortColors(int[] nums) {
        quickSort(nums);
        return;
    }
}