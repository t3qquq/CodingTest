using System;

public class Solution {
    public string[] solution(string[] quiz) {
        string[] answer = new string[quiz.Length];
        
        for(int i=0; i<quiz.Length; i++){
            string[] formula = quiz[i].Split('=');
            string[] leftStr = formula[0].Trim().Split(' ');
            string rightStr = formula[1].Trim();
            
            int leftInt = leftStr[1]=="+" ? int.Parse(leftStr[0])+int.Parse(leftStr[2]) : int.Parse(leftStr[0])-int.Parse(leftStr[2]);
            int rightInt = int.Parse(rightStr);

            answer[i] = leftInt==rightInt ? "O" : "X";
        }
        
        return answer;
    }
}