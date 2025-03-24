using System;

public class Solution {
    public int solution(string before, string after) {
        int answer = 0;
        
        char[] beforeArr = before.ToCharArray();
        char[] afterArr = after.ToCharArray();
        
        Array.Sort(beforeArr);
        Array.Sort(afterArr);
        
        String bfString = String.Join("", beforeArr);
        String afString = String.Join("", afterArr);
        
        if(bfString==afString)
            answer=1;
        
        
        return answer;
    }
}