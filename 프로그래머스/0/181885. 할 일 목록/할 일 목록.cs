using System;
using System.Linq;

public class Solution {
    public string[] solution(string[] todo_list, bool[] finished) {
        string[] answer = new string[finished.Where(n=>n==false).Count()];
        int index=0;
        for(int i=0; i<finished.Length; i++){
            if(!finished[i]){
                Array.Copy(todo_list, i, answer, index++, 1);
            }
        }
        
        return answer;
    }
}