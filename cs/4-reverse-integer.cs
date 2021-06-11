using System;

public class Problem4 {
        static void Main(string[] args) {
                // Console.WriteLine(Solution(1));
                // Console.WriteLine(Solution(-124301));
                // Console.WriteLine(Solution(-214743647));
        }

        private static int MathSolution(int x) {    // O(log(n)) time & O(1)
                long reverse = 0;

                while (x != 0) {
                        // pop the most right digit
                        int pop = x % 10;
                        x /= 10;
                        // push  digit to the right side
                        reverse = reverse * 10 + pop;
                        // edge case: overflow
                        if (Math.Abs(reverse) > Int32.MaxValue) return 0;
                }

                return (int)reverse;
        }
}