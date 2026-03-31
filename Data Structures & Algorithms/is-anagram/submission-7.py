class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        freqs=[0]*26
        freqt=[0]*26

        for i in range(len(s)):
            freqs[ord(s[i])-ord('a')]+=1

        for i in range(len(t)):
            freqt[ord(t[i])-ord('a')]+=1

        for i in range(0,26):
            if freqs[i]!=freqt[i]:
                return False

        return True

        