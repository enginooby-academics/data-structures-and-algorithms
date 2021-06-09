using System;

public class Problem3 {
        public static void Main(string[] args) {
                // Console.Write(CurrentSolution(""));
                // Console.Write(CurrentSolution(" "));
                // Console.Write(CurrentSolution("a"));
                // Console.Write(CurrentSolution("ad"));
                // Console.Write(CurrentSolution("abba"));
        }

        public static int SlidingWindow(string s) { // O(n) time & space
                int maxLength = 0;
                var visitedChars = new System.Collections.Hashtable(); // key: char & val: last visited index

                for (int left = 0, right = 0; right < s.Length; right++) {
                        if (visitedChars.ContainsKey(s[right])) {
                                left = Math.Max((int)visitedChars[s[right]] + 1, left);
                        }

                        visitedChars[s[right]] = right;
                        int currentLength = right - left + 1;
                        maxLength = Math.Max(maxLength, currentLength);
                }

                return maxLength;
        }

        public static int BruteForeSolution(string s) { // O(n^3) time & O(1) space
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