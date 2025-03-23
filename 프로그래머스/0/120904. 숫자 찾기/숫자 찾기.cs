using System;

public class Solution {
    public int solution(int num, int k) {
        int answer = -1;
        
        string str = num.ToString();
        char kChar=(char)(k+48);
        
        for(int i=0; i<str.Length; i++){
            if(str[i]==kChar){
                answer=i+1;
                break;
            }
                
        }
        
        return answer;
    }
}