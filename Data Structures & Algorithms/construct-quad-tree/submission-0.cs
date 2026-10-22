/*
// Definition for a QuadTree node.
public class Node {
    public bool val;
    public bool isLeaf;
    public Node topLeft;
    public Node topRight;
    public Node bottomLeft;
    public Node bottomRight;

    public Node() {
        val = false;
        isLeaf = false;
        topLeft = null;
        topRight = null;
        bottomLeft = null;
        bottomRight = null;
    }
    
    public Node(bool _val, bool _isLeaf) {
        val = _val;
        isLeaf = _isLeaf;
        topLeft = null;
        topRight = null;
        bottomLeft = null;
        bottomRight = null;
    }
    
    public Node(bool _val,bool _isLeaf,Node _topLeft,Node _topRight,Node _bottomLeft,Node _bottomRight) {
        val = _val;
        isLeaf = _isLeaf;
        topLeft = _topLeft;
        topRight = _topRight;
        bottomLeft = _bottomLeft;
        bottomRight = _bottomRight;
    }
}
*/

public class Solution {
    public Node Construct(int[][] grid) {
        return Solve(grid,0,0,grid.Length);
    }
    public bool IsAllSame(int[][] grid,int x,int y,int n)
    {
        int data = grid[x][y];
        for(int i=x;i<x+n;i++)
        {
            for(int j=y;j<y+n;j++)
            {
                if(grid[i][j]!=data)
                {
                    return false;
                }

            }
        }
        return true;
    }
    public Node Solve(int[][] grid,int x, int y,int n)
    {
        if(IsAllSame(grid,x,y,n))
        {
            return new Node(grid[x][y]==1,true);
        }
        else
        {
            Node temp = new Node(true,false);
            temp.topLeft = Solve(grid,x,y,n/2);
            temp.topRight = Solve(grid,x,y+n/2,n/2);
            temp.bottomLeft = Solve(grid,x+n/2,y,n/2);
            temp.bottomRight = Solve(grid,x+n/2,y+n/2,n/2);
            return temp;
        }
        
    }
}