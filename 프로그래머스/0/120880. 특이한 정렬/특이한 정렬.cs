using System;

public class Solution {
    public int[] solution(int[] numlist, int n) {
        int[] answer = new int[numlist.Length];
        
        // for(int i=0; i<numlist.Length; i++){
        //     numlist[i] = Math.Abs(numlist[i]-n);
        // }
        
        Array.Sort(numlist, (a, b) => Math.Abs(a - n) - Math.Abs(b - n));
        
        for(int i=0; i<numlist.Length-1; i++){
            if(Math.Abs(numlist[i]-n)==Math.Abs(numlist[i+1]-n) && numlist[i]<numlist[i+1]){
                int tmp=numlist[i];
                numlist[i]=numlist[i+1];
                numlist[i+1]=tmp;
            }
        }       
        
        answer=numlist;
        
        return answer;
    }
}