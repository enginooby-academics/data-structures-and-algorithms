"use strict";
var _a;
class ListNode {
        constructor(val, next) {
                this.val = (val === undefined ? 0 : val);
                this.next = (next === undefined ? null : next);
        }
        print() {
                let currentHead = this;
                while (currentHead) {
                        process.stdout.write(currentHead.val.toString());
                        currentHead = currentHead.next;
                }
                console.log();
        }
}
// O(max(m, n)) time & space
function addTwoNumbersCustom(l1, l2) {
        var _a, _b;
        let dummyHead = new ListNode(0);
        let currentHead1 = l1;
        let currentHead2 = l2;
        let currentHead3 = dummyHead;
        let carry = 0;
        // case: not reach both ends of lists & case: extra carry of '1' at the end
        while (currentHead1 || currentHead2 || carry) {
                let x = (_a = (currentHead1 === null || currentHead1 === void 0 ? void 0 : currentHead1.val)) !== null && _a !== void 0 ? _a : 0;
                let y = (_b = (currentHead2 === null || currentHead2 === void 0 ? void 0 : currentHead2.val)) !== null && _b !== void 0 ? _b : 0;
                let sum = x + y + carry;
                carry = (sum / 10) >> 0; // slightly faster than Math.floor(sum/10)
                currentHead3.next = new ListNode(sum % 10);
                // advance heads
                currentHead1 = currentHead1 === null || currentHead1 === void 0 ? void 0 : currentHead1.next;
                currentHead2 = currentHead2 === null || currentHead2 === void 0 ? void 0 : currentHead2.next;
                currentHead3 = currentHead3.next;
        }
        return dummyHead.next;
}
;
// test
let l1 = new ListNode(3, new ListNode(9, new ListNode(9)));
let l2 = new ListNode(9);
l1.print();
l2.print();
(_a = addTwoNumbersCustom(l1, l2)) === null || _a === void 0 ? void 0 : _a.print();
