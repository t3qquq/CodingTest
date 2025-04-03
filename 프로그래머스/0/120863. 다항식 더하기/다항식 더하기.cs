using System;

public class Solution {
    public string solution(string polynomial) {
        string answer = "";
        
        string[] arr = polynomial.Split(" ");
        
        // for(int i=0; i<arr.Length; i++){
        //     Console.WriteLine(arr[i]);
        // }
        
        int coeff=0;
        int constant=0;
        
        for(int i=0; i<arr.Length; i++){
            if(i%2==0){
                if(arr[i]=="x")
                    coeff++;
                else if(arr[i][arr[i].Length-1]=='x'){
                    coeff+=int.Parse(arr[i].Substring(0, arr[i].Length-1));
                }
                else
                    constant+=int.Parse(arr[i]);
            }
        }
        
        answer = constant==0 ? (coeff==1 ? "x" :$"{coeff}x") : (coeff==1 ? $"x + {constant}": (coeff==0? $"{constant}": $"{coeff}x + {constant}"));
        
        return answer;
    }
}