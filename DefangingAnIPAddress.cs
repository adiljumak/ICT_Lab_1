using System;

namespace Lab1
{
    public class Solution {
    public string DefangIPaddr(string address) {
        return address.Replace(".","[.]");
    }
}
}
