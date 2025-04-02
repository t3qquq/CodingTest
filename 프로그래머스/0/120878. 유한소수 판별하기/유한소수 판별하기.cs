using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        
        
        for(int i=2; i<=b; i++){
            if(a%i==0 && b%i==0){
                a/=i;
                b/=i;
                i--;
            }
        }
        
        
        
        while (b % 2 == 0) {
            b /= 2;
        }
        while (b % 5 == 0) {
            b /= 5;
        }
        
        answer = b==1 ? 1 : 2;
        
        
        return answer;
    }
}