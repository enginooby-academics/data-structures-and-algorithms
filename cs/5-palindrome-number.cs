using System;

public class Problem5 {
        static void Main(String[] args) {
                Console.WriteLine(Solution(12));
                Console.WriteLine(Solution(0));
                Console.WriteLine(Solution(-121));
                Console.WriteLine(Solution(121));
        }

        static bool StringSolution(int x) { // O(n) time - O(n) space
                string xString = x.ToString();
                char[] xArray = xString.ToCharArray();  // O(n) time & space
                Array.Reverse(xArray);  // O(n) time

                return (xString == new String(xArray));
        }
}