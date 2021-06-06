class ListNode {
        val: number
        next: ListNode | null
        constructor(val?: number, next?: ListNode | null) {
                this.val = (val === undefined ? 0 : val)
                this.next = (next === undefined ? null : next)
        }

        public print(): void {
                let currentHead: ListNode | null = this;
                while (currentHead) {
                        process.stdout.write(currentHead.val.toString());
                        currentHead = currentHead.next;
                }
                console.log();
        }
}

// O(max(m, n)) time & space
function addTwoNumbersCustom(l1: ListNode | null, l2: ListNode | null): ListNode | null {
        let dummyHead = new ListNode(0);
        let currentHead1: ListNode | null = l1;
        let currentHead2: ListNode | null = l2;
        let currentHead3: ListNode | null = dummyHead;
        let carry: number = 0;

        // case: not reach both ends of lists & case: extra carry of '1' at the end
        while (currentHead1 || currentHead2 || carry) {
                let x: number = (currentHead1?.val) ?? 0;
                let y: number = (currentHead2?.val) ?? 0;
                let sum: number = x + y + carry;

                carry = (sum / 10) >> 0 // slightly faster than Math.floor(sum/10)
                currentHead3.next = new ListNode(sum % 10);

                // advance heads
                currentHead1 = currentHead1?.next!;
                currentHead2 = currentHead2?.next!;
                currentHead3 = currentHead3.next!;
        }

        return dummyHead.next;
};

// test
let l1 = new ListNode(3, new ListNode(9, new ListNode(9)));
let l2 = new ListNode(9);

l1.print();
l2.print();
addTwoNumbersCustom(l1, l2)?.print();

