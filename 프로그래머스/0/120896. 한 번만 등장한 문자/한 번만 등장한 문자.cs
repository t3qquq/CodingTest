using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        char[] sString = new char[s.Length];
        char[] sStringCopy = new char[s.Length];
        
        for(int i=0; i<s.Length; i++){
            sString[i]=s[i];
            sStringCopy[i]=s[i];
        }
        
        Array.Sort(sString);
        Array.Sort(sStringCopy);
        if(s.Length==1)
            answer += s[0];
        else if(s.Length==2){
            if(s[0]!=s[1])
                answer=answer+s[0]+s[1];
        }
        else{
            for(int i=1; i<sString.Length-1; i++){
                if(sStringCopy[i]==sStringCopy[i-1] || sStringCopy[i]==sStringCopy[i+1])
                    sString[i]='0';
            }
            if(sStringCopy[0]==sStringCopy[1])
                sString[0]='0';
            if(sStringCopy[sString.Length-1]==sStringCopy[sString.Length-2])
                sString[sString.Length-1]='0';

            for(int i=0; i<sString.Length; i++){
                if(sString[i]!='0')
                    answer+=sString[i];
            }
        }

        
        return answer;
    }
}