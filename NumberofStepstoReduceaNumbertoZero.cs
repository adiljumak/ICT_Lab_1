using System;

namespace Lab1
{
    public class Solution {
    public int NumberOfSteps (int num) {
        int ans = 0;
        while(num != 0){
            if(num%2==0){
                num = num / 2;
                ans++;
            } else{
                num--;
                ans++;
            }
        }
        return ans;
    }
}
}
