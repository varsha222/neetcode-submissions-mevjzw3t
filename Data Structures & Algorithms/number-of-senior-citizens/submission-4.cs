public class Solution {
    public int CountSeniors(string[] details) {
        List<String>age = new List<string>();
        foreach(string st in details)
        {
            string res = st.Substring(11,2);
            if(Convert.ToInt32(res)>60)
            {
                age.Add(res);
            }
        }
        return age.Count;

    }
}