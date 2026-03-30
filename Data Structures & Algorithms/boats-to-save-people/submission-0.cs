public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        int l=0;
        int h=people.Length-1;
        int boat=0;
        Array.Sort(people);
        while(l<=h)
        {
            int remain = limit-people[h];
            h--;
            boat++;
            if(l<=h && remain >= people[l])
            {
                l++;
            }
            

        }

        return boat;
    }
}