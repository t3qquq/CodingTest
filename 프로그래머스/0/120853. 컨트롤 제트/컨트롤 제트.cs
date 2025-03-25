using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        
        string[] sToArr = s.Split(' ');
        
        for(int i=0; i<sToArr.Length; i++){
            if(sToArr[i]=="Z"){
                sToArr[i-1]="0";
                sToArr[i]="0";
            }
        }
        
        for(int i=0; i<sToArr.Length; i++){
            answer+=int.Parse(sToArr[i]);
        }
        
        return answer;
    }
}