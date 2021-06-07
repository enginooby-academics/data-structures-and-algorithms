using System;
using System.Collections.Generic;

// custom defined list node
public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null) {
                this.val = val;
                this.next = next;
        }

        public void Print() {
                ListNode head = this;

                while (head != null) {
                        Console.Write(head.val);
                        head = head?.next;
                }
                Console.WriteLine();
        }
}

public class AddTwoNumbersLinkedList {

        // O(max(m,n)) time & space
        public static ListNode AddTwoNumbersCustom(ListNode l1, ListNode l2) {
                ListNode dummyHead = new ListNode(0);
                ListNode currentHead1 = l1;
                ListNode currentHead2 = l2;
                ListNode currentHead3 = dummyHead;
                int carry = 0;

                // case: not reach both ends of lists & case: extra carry of '1' at the end
                while (currentHead1 != null || currentHead2 != null || carry == 1) {
                        int x = currentHead1?.val ?? 0;
                        int y = currentHead2?.val ?? 0;
                        int sum = x + y + carry;

                        carry = sum / 10;
                        currentHead3.next = new ListNode(sum % 10);

                        //  advance heads
                        currentHead1 = currentHead1?.next;
                        currentHead2 = currentHead2?.next;
                        currentHead3 = currentHead3.next;
                }

                return dummyHead.next;
        }

        public static LinkedList<int> AddTwoNumbersBuiltIn(LinkedList<int> l1, LinkedList<int> l2) {
                var result = new LinkedList<int>();
                LinkedListNode<int> currentHead1 = l1.First;
                LinkedListNode<int> currentHead2 = l2.First;
                int carry = 0;

                // case: not reach both ends of lists & case: extra carry of '1' at the end
                while (currentHead1 is not null || currentHead2 is not null || carry == 1) {
                        int x = currentHead1?.Value ?? 0;
                        int y = currentHead2?.Value ?? 0;
                        int sum = x + y + carry;
                        carry = sum / 10;
                        result.AddLast(sum % 10);

                        //  advance heads
                        currentHead1 = currentHead1?.Next;
                        currentHead2 = currentHead2?.Next;
                }

                return result;
        }

        static void Main(string[] args) {
                // TestCustomLinkedList();
                TestBuilInLinkedList();
        }

        private static void TestCustomLinkedList() {
                ListNode l1 = new ListNode(2, new ListNode(9, new ListNode(9)));
                ListNode l2 = new ListNode(9, null);

                l1.Print();
                l2.Print();
                AddTwoNumbersCustom(l1, l2).Print();
        }

        private static void TestBuilInLinkedList() {
                var l1 = new LinkedList<int>(new int[] { 2, 9, 9 });
                var l2 = new LinkedList<int>(new int[] { 9 });

                PrintLinkedList<int>(AddTwoNumbersBuiltIn(l1, l2));
        }

        // HELPER
        private static void PrintLinkedList<T>(LinkedList<T> list) {
                foreach (T element in list) {
                        Console.Write(element.ToString());
                }

                Console.WriteLine();
        }
}
