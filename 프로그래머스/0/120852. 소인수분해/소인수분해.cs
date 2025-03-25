using System;
using System.Linq;

public class Solution {
    public int[] solution(int n) {
        
        string eq="";
        
        int divider=2;
        while(divider<=n){
            if(n%divider==0){
                while(n%divider==0){
                    n/=divider;
                }
                
                eq = eq+divider.ToString()+" ";
            }
            else
                divider++;
        }
        
        var arr = eq.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] answer = new int[arr.Length];
        for(int i=0; i<arr.Length; i++){
            answer[i] = int.Parse(arr[i]);
        }
        
        return answer;
    }
}