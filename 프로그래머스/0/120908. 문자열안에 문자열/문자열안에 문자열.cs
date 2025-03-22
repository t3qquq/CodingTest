using System;

public class Solution {
    public int solution(string str1, string str2) {
        int answer = 0;
        
        if(str1.Length<str2.Length)
            answer=2;
        else{
            for(int i=0; i<str1.Length-str2.Length+1; i++){
                answer = 2;
                if(str1[i]==str2[0]){
                    if(str1.Substring(i,str2.Length)==str2){
                        answer=1;
                        break;
                    }
                }
            }
        }

        
        return answer;
    }
}