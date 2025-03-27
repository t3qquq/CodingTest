using System;
using System.Linq;

public class Solution {
    public int solution(int[,] dots) {
        int answer = 0;
        
        int[] x = new int[4];
        int[] y = new int[4];
        
        for(int i=0; i<4; i++){
            x[i]=dots[i,0];
        }
        for(int i=0; i<4; i++){
            y[i]=dots[i,1];
        }
        
        answer = (x.Max()-x.Min())*(y.Max()-y.Min());
        
        return answer;
    }
}


// [[1, 1],
//  [2, 1],
//  [2, 2],
//  [1, 2]]
 

// [[-1, -1],
//  [1, 1],
//  [1, -1],
//  [-1, 1]]