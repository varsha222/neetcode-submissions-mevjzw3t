class Solution:
    def stringMatching(self, words: List[str]) -> List[str]:
        lst=[]
        for s in words:
            for t in words:
                if s==t or len(s)>=len(t):
                    continue
                elif s in t:
                    lst.append(s)
                    break
        return lst

            
        