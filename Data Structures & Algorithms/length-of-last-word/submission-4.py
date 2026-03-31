class Solution:
    def lengthOfLastWord(self, s: str) -> int:
        res=s.strip()
        print(res)
        n=len(res)-1
        l=0
        for i in res[::-1]:
            if i!=" ":
                l+=1
            else:
                break
        return l

        