using System;
// using System.Linq;

public class Solution {
    public int solution(int[,] board) {
        int answer = 0;
        
        int n = board.GetLength(0);

        int[,] bigBoard = new int[n+2,n+2];
        
        for(int i=0; i<n+2; i++){
            for(int j=0; j<n+2; j++){
                if(i==0||i==n+1||j==0||j==n+1)
                    bigBoard[i,j]=9;
                else{
                    bigBoard[i,j] = board[i-1,j-1]; 
                }
            }
        }
        
        for(int i=1; i<n+1; i++){
            for(int j=1; j<n+1; j++){
                if(bigBoard[i,j]==0&&(bigBoard[i-1,j-1]==1||bigBoard[i-1,j]==1||bigBoard[i-1,j+1]==1||bigBoard[i,j-1]==1||bigBoard[i,j+1]==1||bigBoard[i+1,j-1]==1||bigBoard[i+1,j]==1||bigBoard[i+1,j+1]==1))
                    bigBoard[i,j]=2;
            }
        }
        
        for(int i=0; i<n+2; i++){
            for(int j=0; j<n+2; j++){
                if(bigBoard[i,j]==0)
                    answer++;
            }
        }
        
        return answer;
    }
}