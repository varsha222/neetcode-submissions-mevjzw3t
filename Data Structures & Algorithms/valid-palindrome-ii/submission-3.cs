public class Solution {
    
    public bool ValidPalindrome(string s) {
        bool isPalindrome(int l, int r)
        {
            while(l<r)
            {
                if(s[l]==s[r])
                {
                    l++;
                    r--;
                }
                else
                {
                    return false;
                }
            }
            return true;

        }
        int left=0;
        int right=s.Length-1;
        while(left<right)
        {
            if(s[left]!=s[right])
            {
                return isPalindrome(left+1,right)|| isPalindrome(left,right-1);
            }
            left++;
            right--;
        }
        return true;
    }
}