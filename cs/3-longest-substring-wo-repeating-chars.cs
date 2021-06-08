using System;

public class Problem3 {
        public static void Main(string[] args) {
                Console.Write(BruteForeSolution(""));
        }

        public static int BruteForeSolution(string s) {
                if (s.Length <= 1) return s.Length;

                int maxLength = 0;

                for (int start = 0; start < s.Length - 1; start++) {
                        for (int end = start; end < s.Length; end++) {
                                int subLength = end - start + 1;
                                string subString = s.Substring(start, subLength);
                                if (!AllCharsUnique(subString)) break;
                                maxLength = Math.Max(maxLength, subLength);
                        }
                }

                return maxLength;
        }

        public static bool AllCharsUnique(string aString) {
                for (int i = 0; i < aString.Length - 1; i++) {
                        string subString = aString.Substring(i + 1, aString.Length - 1 - i);
                        if (subString.IndexOf(aString[i]) != -1) return false;
                }

                return true;
        }
}