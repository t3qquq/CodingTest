using System;
using System.Linq;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        
        int[] distArr = array.Distinct().ToArray();
        Array.Sort(distArr);
        int[] distArrCount = new int[distArr.Length];
        
        for(int i=0; i<array.Length; i++){
            for(int j=0; j<distArr.Length; j++){
                if(array[i]==distArr[j])
                    distArrCount[j]++;
            }
        }
        
//         for(int i=0; i<distArrCount.Length; i++){
//             Console.Write($"{distArr[i]} ");
//         }
//         Console.WriteLine();
//         for(int i=0; i<distArrCount.Length; i++){
//             Console.Write($"{distArrCount[i]} ");
//         }
        
//         Console.WriteLine($"\n{Array.IndexOf(distArrCount, distArrCount.Max())}");  
        
        int mxCount=0;
        for(int i=0; i<distArrCount.Length; i++){
            if(distArrCount[i]==distArrCount.Max())
                mxCount++;
        }
        
        if(mxCount!=1)
            answer = -1;
        else{
            answer = distArr[Array.IndexOf(distArrCount, distArrCount.Max())];
        }
        
        
        return answer;
    }
}