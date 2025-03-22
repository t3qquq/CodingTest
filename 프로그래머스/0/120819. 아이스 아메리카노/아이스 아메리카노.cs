using System;

public class Solution {
    public int[] solution(int money) {
        int[] answer = new int[2] {-1,-1};
        
        answer[0] = money/5500;
        answer[1] = money%5500;
        
        return answer;
    }
}