using System;

public class Solution {
    public int[] solution(int num, int total) {
        int[] answer = new int[num];
        
        for(int i=1; i<num; i++){
            total-=i;
        }

        answer[0]=total/num;
        
        for(int i=0; i<num; i++){
            answer[i]=answer[0]+i;
        }
        
        return answer;
    }
}