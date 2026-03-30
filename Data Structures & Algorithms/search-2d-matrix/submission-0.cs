public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int m = matrix.Length;
        int n = matrix[0].Length;
        for(int i =0; i<m;i++)
        {
            int l = 0 ;
            int h = n-1;
            while(l<=h)
            {
                int mid = l + (h-l)/2;
                if(target<matrix[i][mid])
                {
                    h=mid-1;
                }
                if(target>matrix[i][mid])
                {
                    l=mid+1;
                }
                if(target==matrix[i][mid])
                {
                    return true;
                }
            }
        }
        return false;
    }
}
