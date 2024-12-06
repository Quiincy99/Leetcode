
ListNode DeleteDuplicates(ListNode head)
{
    if (head == null)
    {
        return head;
    }

    var temp = head;
    while (temp.next != null)
    {
        if (temp.val == temp.next.val)
        {
            if (temp.next.next != null)
            {
                temp.next = temp.next.next;
            }
            else
            {
                temp.next = null;
            }
        }
        else
        {
            temp = temp.next;
        }
    }

    return head;
};

var head = new ListNode(1, new ListNode(1, new ListNode(3)));

head = DeleteDuplicates(head);

var temp = head;
while (temp != null)
{
    Console.WriteLine(temp.val);
    temp = temp.next;
}



public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
};

