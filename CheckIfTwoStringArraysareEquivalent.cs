using System;

namespace Lab1
{
    public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        string word11 = string.Join("",word1);
        string word22 = string.Join("",word2);
        
        if(word11.Equals(word22)){
            return true;
        }
            
        else{
            return false;
        }
    }
}
}
