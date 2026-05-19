class Solution:
    def isSubsequence(self, s: str, t: str) -> bool:
        if len(s)>len(t):
            return False
        j=0
        i=0
        
        while j<len(t) and i<len(s):
            if s[i]==t[j]:
                i+=1
            j+=1

        return i==len(s)