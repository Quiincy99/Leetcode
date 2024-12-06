



using Microsoft.VisualBasic;

ListNode ReverseList(ListNode head)
{
    ListNode cur = head;
    ListNode prev = null;

    while (cur != null)
    {
        var temp = cur.next;
        cur.next = prev;
        prev = cur;
        cur = temp;
    }

    return prev;
}

var a = new ListNode(1, new ListNode(2, new ListNode(3)));
var result = ReverseList(a);

while (result != null)
{
    Console.WriteLine(result.val);
    result = result.next;
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

}

