using System;
using System.Collections.Generic;

namespace LinkedListAgain
{

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

    class Solution
    {

        public static Node removeDuplicates(Node head)
        {
            if (head == null)
            {
                return head;
            }

            Node current = head;

            while (current.next != null)
            {
                if (current.data == current.next.data)
                {
                    // remove the duplicate node by skipping over it, 
                    // let memory management handle the now skipped/lost node
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }
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

        static void Main(String[] args)
        {
            Node head = null;

            Console.WriteLine("Give # of ints to expect:");
            int T = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Give {0} ints: ", T);
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }

            head = removeDuplicates(head);

            display(head);
        }
    }
}
