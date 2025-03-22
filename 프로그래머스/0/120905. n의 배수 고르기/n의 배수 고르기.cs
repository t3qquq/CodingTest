using System;
using System.Linq;

public class Solution {
    public int[] solution(int n, int[] numlist) {
        int[] answer = new int[numlist.Length];
        
        answer=numlist;
        for(int i=0; i<numlist.Length; i++)
            if(numlist[i]%n!=0)
                answer[i]=-1;
        answer=answer.Where(num => num!= -1).ToArray();
        
        return answer;
    }
}