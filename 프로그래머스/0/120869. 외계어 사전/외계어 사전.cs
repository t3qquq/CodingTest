using System;

public class Solution {
    public int solution(string[] spell, string[] dic) {
        int answer = 2;
        
        string spellString = "";
        
        Array.Sort(spell);

        for(int i=0; i<spell.Length; i++){
            spellString+=spell[i];
        }
        
        for(int i=0; i<dic.Length; i++){
            char[] tmp = dic[i].ToCharArray();
            Array.Sort(tmp);
            dic[i] = string.Join("", tmp);
            if(dic[i]==spellString){
                answer=1;
                break;
            }
        }
        
        
        
        return answer;
    }
}