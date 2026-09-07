public class Solution {
    public int NumUniqueEmails(string[] emails) {
        HashSet<string>uniqueEmail=new HashSet<String>();
        foreach(string st in emails)
        {
           string[] parts = st.Split('@');
           string local=parts[0];
           string domain=parts[1];
           local = local.Split('+')[0];
           local = local.Replace(".","");
           uniqueEmail.Add(local + "@" + domain);
        }
        return uniqueEmail.Count;
    }
}