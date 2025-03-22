using System;

public class Solution {
    public int[] solution(int[] array) {
        int[] answer = new int[2];
        
        int[] sortArr = new int[array.Length];
       
        
        for(int i=0; i<array.Length; i++){
            sortArr[i]=array[i];
        }
        
        Array.Sort(sortArr);
        Array.Reverse(sortArr);

        
        for(int i=0; i<array.Length; i++){
            if(array[i]==sortArr[0]){
                answer[0]=sortArr[0];
                answer[1]=i;
                break;
            }
        }
  

        
        return answer;
    }
}