namespace Day_24_MoreLinkedList;

class Node
{
    public int data;
    public Node next;
    public Node(int d)
    {
        data = d;
        next = null;
    }
}

internal class Solution
{
    public static Node removeDuplicates(Node head)
    {
        //Write your code here
        if (head == null || head.next == null)
        {
            return head;
        }

        List<int> nodeListData = new();
        Node currentNode = head;
        Node previousNode = null!;

        while (currentNode != null)
        {
            if (!nodeListData.Contains(currentNode.data))
            {
                previousNode = currentNode;
                nodeListData.Add(currentNode.data);
            }
            else
            {
                previousNode.next = currentNode.next;
            }

            currentNode = currentNode.next;
        }

        return head;
    }

    public static Node insert(Node head, int data)
    {
        Node p = new Node(data);

        if (head == null)
            head = p;
        else if (head.next == null)
            head.next = p;
        else
        {
            Node start = head;
            while (start.next != null)
                start = start.next;
            start.next = p;

        }
        return head;
    }

    public static void display(Node head)
    {
        Node start = head;
        while (start != null)
        {
            Console.Write(start.data + " ");
            start = start.next;
        }
    }

    static void Main(string[] args)
    {
        Node head = null;
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            int data = Int32.Parse(Console.ReadLine());
            head = insert(head, data);
        }
        head = removeDuplicates(head);
        display(head);
    }
}
