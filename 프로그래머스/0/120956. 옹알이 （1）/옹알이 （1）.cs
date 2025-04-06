using System;

public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        
        for(int i=0; i<babbling.Length; i++){
            
            while(true){
                if(babbling[i].Length>=3 && babbling[i].Substring(0,3)=="aya"){
                    babbling[i] = babbling[i].Substring(3);
                }
                else if(babbling[i].Length>=2 && babbling[i].Substring(0,2)=="ye"){
                    babbling[i] = babbling[i].Substring(2);
                }
                else if(babbling[i].Length>=3 && babbling[i].Substring(0,3)=="woo"){
                    babbling[i] = babbling[i].Substring(3);
                }
                else if(babbling[i].Length>=2 && babbling[i].Substring(0,2)=="ma"){
                    babbling[i] = babbling[i].Substring(2);
                }
                else
                    break;
                
                if(babbling[i].Length==0){
                    answer++;
                    break;
                }
            }
            
            
        }
        
        return answer;
    }
}