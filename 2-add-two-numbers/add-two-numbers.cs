/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int sum;
        ListNode dummyNode = new ListNode(0, null); //dummy node def
        ListNode sumptr = dummyNode;
        int carry = 0;
        while(l1 != null || l2 != null || carry > 0)
        {
            sum = ((l1 != null)? l1.val : 0) + ((l2 != null)? l2.val : 0) + carry;
            carry = sum / 10;
            sumptr.next = new ListNode(sum%10);
            sumptr = sumptr.next;
            l1 = (l1 != null)? l1.next : null;
            l2 = (l2 != null)? l2.next : null;
        }

        return dummyNode.next;
    }
}