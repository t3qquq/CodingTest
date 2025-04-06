using System;
using System.Linq;

public class Solution {
    public int solution(int[,] lines) {
        int answer = 0;
        
        int[] num = {lines[0,0], lines[0,1], lines[1,0], lines[1,1], lines[2,0], lines[2,1]};
        int min = num.Min();
        int max = num.Max();
        
        int[] check = new int[max-min+1];
        
        for (int i = min; i < max; i++) {
            int cnt = 0;
            if (lines[0,0] <= i && i < lines[0,1]) cnt++;
            if (lines[1,0] <= i && i < lines[1,1]) cnt++;
            if (lines[2,0] <= i && i < lines[2,1]) cnt++;

            if (cnt >= 2) answer++;
        }        
        
        return answer;
    }
}