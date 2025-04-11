using System;

public class Solution {
    public int solution(string ineq, string eq, int n, int m) {
        int answer = 0;
        bool ans;
        if(ineq=="<" && eq=="=")
            ans = n<=m;
        else if(ineq=="<" && eq=="!")
            ans = n<m;
        else if(ineq==">" && eq=="=")
            ans = n>=m;
        else
            ans = n>m;
        
        return ans ? 1 : 0;
    }
}