public class Solution {
    public bool IsValidSudoku(char[][] board) {
        int r = board.Length;
        for(int i=0;i<9;i++)
        {
            HashSet<char> map = new HashSet<char>();
            for(int j =0;j<9;j++)
            {
                if (board[i][j] == '.') continue;
                if(map.Contains(board[i][j]))
                {
                    return false;
                }
                map.Add(board[i][j]);
            }
        }
        for(int j=0;j<9;j++)
        {
            HashSet<char> map = new HashSet<char>();
            for(int i=0;i<9;i++)
            {
                if (board[i][j] == '.') continue;
                if(map.Contains(board[i][j]))
                {
                    return false;
                }
                map.Add(board[i][j]);
            }
        }
        for(int square =0; square<9;square++)
        {
            HashSet<char> map = new HashSet<char>();
            for(int i=0;i<3;i++)
            {
                for(int j =0;j<3;j++)
                {
                    int row = (square/3)*3+i;
                    int col = (square%3)*3+j;
                    if (board[row][col]=='.')
                    {
                        continue;
                    }
                    if(map.Contains(board[row][col]))
                    {
                        return false;
                    }
                    map.Add(board[row][col]);
                }
            }
        }

        return true;
    }
}
