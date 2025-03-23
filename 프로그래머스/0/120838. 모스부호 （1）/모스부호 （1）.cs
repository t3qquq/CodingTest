using System;

public class Solution {
    public string solution(string letter) {
        string answer = "";
        
        string[] letterArr = letter.Split(' ');
        
        string[] morse = new string[26] {".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", };
        
        for(int i=0; i<letterArr.Length; i++){
            for(int j=0; j<26; j++){
                if(letterArr[i] == morse[j])
                    answer=answer+(char)(j+97);
            }
        }
        
        return answer;
    }
}