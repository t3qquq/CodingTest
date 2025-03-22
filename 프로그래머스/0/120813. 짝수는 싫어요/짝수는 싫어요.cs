using System;

public class Solution {
    public int[] solution(int n) {        
        if(n%2!=0)
            n++;
        n/=2;
        int[] answer = new int[n];
        
        for(int i=0; i<n; i++){
            answer[i]=2*i+1;
        }
        
        return answer;
    }
}