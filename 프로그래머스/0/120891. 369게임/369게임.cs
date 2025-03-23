using System;

public class Solution {
    public int solution(int order) {
        int answer = 0;
        
        string num = order.ToString();
        
        for(int i=0; i<num.Length; i++){
            if(num[i]=='3'||num[i]=='6'||num[i]=='9')
                answer++;
        }
        
        return answer;
    }
}