class Solution:
    def countSeniors(self, details: List[str]) -> int:
        n=0
        for s in details:
            age=(ord(s[11])-ord('0'))*10+ord(s[12])-ord('0')
            if age>60:
                n+=1

        return n

        