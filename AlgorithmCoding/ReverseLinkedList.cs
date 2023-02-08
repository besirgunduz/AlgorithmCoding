namespace AlgorithmCoding
{
    public class ReverseLinkedList
    {
        //Given the head of a singly linked list, reverse the list, and return the reversed list.

        //Input: head = [1,2,3,4,5]
        //Output: [5,4,3,2,1]

        public static ListNode ReverseList(ListNode head)
        {
            ListNode previous = null;

            while (head != null)
            {
                var next = head.next;
                head.next = previous;
                previous = head;
                head = next;
            }

            return previous;
        }
    }
}
