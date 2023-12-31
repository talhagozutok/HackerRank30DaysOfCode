﻿namespace Day_23_BSTLevelOrderTraversal;

class Node
{
    public Node left, right;
    public int data;
    public Node(int data)
    {
        this.data = data;
        left = right = null;
    }
}

internal class Solution
{
    static void levelOrder(Node root)
    {
        //Write your code here

        List<int> nodeDataList = new();
        Queue<Node> levelOrderQueue = new();

        Node tempNode = root;
        while (tempNode != null)
        {
            nodeDataList.Add(tempNode.data);

            if (tempNode.left != null)
            {
                levelOrderQueue.Enqueue(tempNode.left);
            }
            if (tempNode.right != null)
            {
                levelOrderQueue.Enqueue(tempNode.right);
            }

            tempNode = levelOrderQueue.Any()
                ? levelOrderQueue.Dequeue()
                : null!;
        }

        string result = string.Join(" ", nodeDataList);
        Console.Write(result);
    }

    static Node insert(Node root, int data)
    {
        if (root == null)
        {
            return new Node(data);
        }
        else
        {
            Node cur;
            if (data <= root.data)
            {
                cur = insert(root.left, data);
                root.left = cur;
            }
            else
            {
                cur = insert(root.right, data);
                root.right = cur;
            }
            return root;
        }
    }

    static void Main(string[] args)
    {
        Node root = null;
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            int data = Int32.Parse(Console.ReadLine());
            root = insert(root, data);
        }
        levelOrder(root);
    }
}
