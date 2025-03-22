using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        while(true){
            if(answer*7/n<=0)
                answer++;
            else
                break;
        }
        
        return answer;
    }
}