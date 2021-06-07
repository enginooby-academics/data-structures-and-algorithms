import math

# Definition for singly-linked list.


class ListNode:
    def display(self):
        currentHead = self
        while(currentHead):
            print(currentHead.val, end="")
            currentHead = currentHead.next
        print()

    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next


def addTwoNumbers(l1: ListNode, l2: ListNode) -> ListNode:
    dummyHead = ListNode()
    currentHead1 = l1
    currentHead2 = l2
    currentHead3 = dummyHead
    carry = 0

    # case: not reach both ends of lists & case: extra carry of '1' at the end
    while(currentHead1 or currentHead2 or carry):
        x = currentHead1.val if currentHead1 else 0
        y = currentHead2.val if currentHead2 else 0
        sum = x + y + carry

        carry = sum // 10  # math.floor(sum / 10)
        currentHead3.next = ListNode(sum % 10)

        # advance heads
        currentHead1 = currentHead1.next if currentHead1 else None
        currentHead2 = currentHead2.next if currentHead2 else None
        currentHead3 = currentHead3.next

    return dummyHead.next


# test
l1 = ListNode(3, ListNode(9, ListNode(9)))
l2 = ListNode(9)

addTwoNumbers(l1, l2).display()
