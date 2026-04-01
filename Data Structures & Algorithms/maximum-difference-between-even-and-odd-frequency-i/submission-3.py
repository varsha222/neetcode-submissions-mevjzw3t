class Solution:
    def maxDifference(self, s: str) -> int:
        freq={}
        for i in range(len(s)):
            if s[i] not in freq:
                freq[s[i]]=1
            else:
                freq[s[i]]+=1
        evenmin=sys.maxsize
        oddmax=0
        for val in freq.values():
            if val%2==0:
                evenmin=min(val,evenmin)
            else:
                oddmax=max(val,oddmax)
        return oddmax-evenmin
        
        
        