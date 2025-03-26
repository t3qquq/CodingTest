using System;

public class Solution {
    public int solution(int balls, int share) {
        int answer = 1;
        
        double a =1;

        if(balls!=share){
            for(int i=share+1; i<=balls; i++){
                a*=i;
            }
            for(int i=balls-share; i>1; i--)
                a/=i;
            answer = (int)a;
        }
        
        

        
        return answer;
    }
}