ListNode Mergered(ListNode list1, ListNode list2)
{
    if (list1 == null)
        return list2;
    else if (list2 == null)
        return list1;

    ListNode cur = null;
    ListNode tempHead = cur;
    ListNode temp1 = list1;
    ListNode temp2 = list2;

    while (temp1 != null || temp2 != null)
    {
        if (temp1.val >= temp2.val)
        {
            cur = temp1;

            if (temp1.next == null)
            {
                cur.next = temp2;
                return tempHead;
            }
            else
            {
                temp1 = temp1.next;
            }

        }
        else
        {
            cur = temp2;
            if (temp2.next == null)
            {
                cur.next = temp1;
                return tempHead;
            }
            else
            {
                temp2 = temp2.next;
            }
        }

        cur.next = null;
    }

    return tempHead;
}

var a = new ListNode(1, new ListNode(2, new ListNode(4)));
var b = new ListNode(1, new ListNode(3, new ListNode(4)));
var result = Mergered(a, b);

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

