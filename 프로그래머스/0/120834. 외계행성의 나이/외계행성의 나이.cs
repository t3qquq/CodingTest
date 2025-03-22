using System;

public class Solution {
    public string solution(int age) {
        string answer = "";
        String tmp = age.ToString();
        
        for(int i=0; i<tmp.Length; i++){
            answer+=(char)(tmp[i]+49);
        }

        
        return answer;
    }
}