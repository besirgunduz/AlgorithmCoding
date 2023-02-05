namespace AlgorithmCoding
{
    public class MiddleLinkedList
    {
        //Given the head of a singly linked list, return the middle node of the linked list.
        //If there are two middle nodes, return the second middle node.

        //Input: head = [1,2,3,4,5]
        //Output: [3,4,5]
        //Explanation: The middle node of the list is node 3.

        public static ListNode MiddleNode(ListNode head)
        {
            ListNode slowPointer = head;
            ListNode fastPointer = head;

            while (fastPointer != null && fastPointer.next != null)
            {
                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next.next;
            }

            return slowPointer;
        }
    }
}
