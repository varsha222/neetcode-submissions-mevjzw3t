class Solution:
    def countSeniors(self, details: List[str]) -> int:
        age=list(map(lambda x:x[11:13],details))
        n=0
        for i in age:
            if i>"60":
                n+=1
        return n
