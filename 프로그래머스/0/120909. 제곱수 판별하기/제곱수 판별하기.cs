using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        answer=2;
        
        for(int i=1; i<n; i++){
            if(i*i==n){
                answer=1;
                break;
            }
                
        }
        
        return answer;
    }
}