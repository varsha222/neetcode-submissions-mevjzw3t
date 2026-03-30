public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int n = numbers.Length;
        List<int> res = new List<int>();
        HashSet<int> map = new HashSet<int>(numbers);
        for(int i=0;i<n;i++)
        {
            int complement = target-numbers[i];
            if(map.Contains(complement) && complement!=numbers[i])
            {
                res.Add(i+1);
            }
            else
            {
                map.Add(numbers[i]);
            }
        }
        return(res.ToArray());
    }
}
