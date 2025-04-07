using System;

public class Solution {
    public string solution(string str1, string str2) {
        string answer = "";
        
        for(int i=0; i<str1.Length+str2.Length; i++){
            if(i%2==0)
                answer+=str1[i/2];
            else
                answer+=str2[(i-1)/2];
        }
        
        return answer;
    }
}