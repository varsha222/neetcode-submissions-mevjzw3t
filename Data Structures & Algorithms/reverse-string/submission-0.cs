public class Solution {
    public void ReverseString(char[] s) {
        int n = s.Length;
        int low = 0;
        int high = n-1;

        while(low<high)
        {
            char temp=s[low];
            s[low]=s[high];
            s[high]=temp;
            low++;
            high--;
        }
        
    }
}