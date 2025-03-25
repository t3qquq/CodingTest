using System;

public class Solution {
    public int solution(int[] array, int n) {
        int answer = 0;
        
        int[] arrCopy = new int[array.Length];
        for(int i=0; i<array.Length; i++){
            arrCopy[i] = array[i];
        }
        
        for(int i=0; i<array.Length; i++){
            arrCopy[i] = (arrCopy[i]-n)*(arrCopy[i]-n);
        }
        
        Array.Sort(arrCopy);
        Array.Sort(array);
        
        for(int i=0; i<array.Length; i++){
            if((array[i]-n)*(array[i]-n) == arrCopy[0]){
                answer = array[i];
                break;
            }
        }
        
        return answer;
    }
}