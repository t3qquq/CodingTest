using System;

public class Solution {
    public int solution(int a, int b) {
        
        int answer = int.Parse(a.ToString()+b.ToString()) > 2*a*b ? int.Parse(a.ToString()+b.ToString()) : 2*a*b;
        
        return answer;
    }
}