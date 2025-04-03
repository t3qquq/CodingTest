using System;

public class Solution {
    public int solution(int chicken) {
        int answer = 0;
        
        int leftCP=chicken;
        int serviceChick=0;

        int i=1;
        while(leftCP>=10){
            Console.WriteLine($"{i++}번째 주문");
            Console.WriteLine($"현재 남아있는 쿠폰: {leftCP}, 주문가능한 치킨: {leftCP/10}");
            Console.WriteLine("쿠폰을 사용하여 치킨을 주문합니다.");
            
            
            
            serviceChick = leftCP/10;
            answer+=serviceChick;
            leftCP%=10;
            
            Console.Write($"서비스받은 총 치킨: {answer}, 남은쿠폰:{leftCP}");
            leftCP+=serviceChick;
            Console.WriteLine($", 총 남은쿠폰:{leftCP}\n");

        }
        
        
        return answer;
    }
}