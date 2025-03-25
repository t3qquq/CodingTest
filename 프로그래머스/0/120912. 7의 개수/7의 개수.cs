using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        string arrToString = "";
        
        for(int i=0; i<array.Length; i++){
            arrToString+=array[i].ToString();
        }
        
        for(int i=0; i<arrToString.Length; i++){
            if(arrToString[i]=='7')
                answer++;
        }
        
        return answer;
    }
}