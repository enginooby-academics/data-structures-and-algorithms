using System;
using System.Linq;

public class Problem4 {
        static void Main(string[] args) {
                // Console.WriteLine(Solution(13434));
                // Console.WriteLine(Solution(-124301));
                // Console.WriteLine(Solution(-2147483647));
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

        private static int LinqSolution(int x) {
                long[] reverseArray = Enumerable.Reverse(Math.Abs(x).ToString().Select(o => long.Parse(o.ToString()))).ToArray();
                long result = reverseArray.Aggregate((result, x) => result * 10 + x);
                return Math.Abs(result) > Int32.MaxValue ? 0 : (int)result * (x / Math.Abs(x));
        }
}