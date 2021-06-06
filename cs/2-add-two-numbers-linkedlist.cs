using System;

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
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
                ListNode dummyHead = new ListNode(0);
                ListNode currentHead1 = l1;
                ListNode currentHead2 = l2;
                ListNode currentHead3 = dummyHead;
                int carry = 0;

                // reach both ends of lists or case: extra carry of one at the end
                while (currentHead1 != null || currentHead2 != null || carry == 1) {
                        int x = (currentHead1 != null) ? currentHead1.val : 0;
                        int y = (currentHead2 != null) ? currentHead2.val : 0;
                        int sum = x + y + carry;

                        carry = sum / 10;
                        currentHead3.next = new ListNode(sum % 10);

                        currentHead1 = currentHead1?.next;
                        currentHead2 = currentHead2?.next;
                        currentHead3 = currentHead3.next;
                }

                return dummyHead.next;
        }
        static void Main(string[] args) {
                ListNode l1 = new ListNode(2, new ListNode(9, new ListNode(9)));
                ListNode l2 = new ListNode(9, null);

                l1.Print();
                l2.Print();
                AddTwoNumbers(l1, l2).Print();
        }
}
