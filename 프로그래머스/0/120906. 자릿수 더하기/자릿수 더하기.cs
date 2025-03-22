using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;

        string numString = n.ToString();
        for(int i=0; i<numString.Length; i++){
            answer+=int.Parse(numString[i].ToString());
        }

        
        return answer;
    }
}