class Solution:
    def lengthOfLastWord(self, s: str) -> int:
        n=0
        t=s.strip()
        for i in range(len(t)-1,-1,-1):
            if t[i]!=" ":
                n+=1
            else:
                break
        return n



        
        