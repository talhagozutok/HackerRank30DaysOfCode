namespace Day_15_LinkedList;

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
    public static Node insert(Node head, int data)
    {
        //Complete this method
        if (head == null)
        {
            return new Node(data);
        }

        Node currentNode = head;
        while (currentNode.next != null)
        {
            currentNode = currentNode.next;
        }

        currentNode.next = new Node(data);
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
        int T = int.Parse(Console.ReadLine());

        while (T-- > 0)
        {
            int data = int.Parse(Console.ReadLine());
            head = insert(head, data);
        }
        display(head);
    }
}
