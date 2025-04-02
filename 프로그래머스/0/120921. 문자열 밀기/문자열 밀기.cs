using System;

public class Solution {
    public int solution(string A, string B) {
        int answer = -1;

        for(int i=0; i<A.Length; i++){
            string front = A.Substring(A.Length-i);
            string back = A.Substring(0, A.Length-i);
            if(B==front+back){
                answer=i;
                break;
            }
        }
        
        return answer;
    }
}