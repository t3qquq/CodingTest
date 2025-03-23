using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        for(int i=1; i<=n; i++){
            if(i==1||i==2||i==3)
                ;
            else{
                int count=0;
                for(int j=0; j<i; j++){
                    if(i%(j+1)==0)
                        count++;
                    if(count>=3){
                        answer++;
                        break;
                    }
                }
            }
        }
        
        return answer;
    }
}