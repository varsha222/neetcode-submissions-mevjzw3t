public class Solution {
    public int CountSeniors(string[] details) {
        string[] age= details.Where(str=>int.Parse(str.Substring(11,2))>60).ToArray();
        return age.Length;

    }
}