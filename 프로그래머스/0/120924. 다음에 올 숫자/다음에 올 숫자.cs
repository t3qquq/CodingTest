using System;

public class Solution {
    public int solution(int[] common) {
        int answer = 0;
        
        answer = common[2]-common[1]==common[1]-common[0] ? common[common.Length-1]+common[1]-common[0] : common[common.Length-1]*common[1]/common[0];
        
        return answer;
    }
}