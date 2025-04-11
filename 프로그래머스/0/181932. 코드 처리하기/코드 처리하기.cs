using System;
using System.Text;

public class Solution {
    public string solution(string code) {
        StringBuilder s = new StringBuilder(); 
        char mode='0';
        
        for(int i=0; i<code.Length; i++){
            if(code[i]=='1')
                mode = mode=='0' ? '1' : '0';
            else{
                if(mode=='0' && i%2==0)
                    s.Append(code[i]);
                else if(mode=='1' && i%2==1)
                    s.Append(code[i]);
            }
        }
        
        return s.ToString()=="" ? "EMPTY" : s.ToString();
    }
}