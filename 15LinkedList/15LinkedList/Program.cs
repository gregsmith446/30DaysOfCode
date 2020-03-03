using System;

/*
 Complete the insert function in your editor so that it creates a new Node (pass "data" as the Node constructor argument) 
 and inserts it at the tail of the linked list referenced by the parameter. 
 Once the new node is added, return the reference to the "head" node.
 */

namespace _15LinkedList
{
    /* A Node object has an integer data field "data", and a Node instance pointer "next", pointing to another node (i.e.: the next node in a list) */
    class Node
    {
        public int data;
        public Node next;

        // method that takes in data, setting the last pointer to null
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }

    class Program
    {
        static void Main(String[] args)
        {

            Node head = null;

            Console.WriteLine("How many nodes to insert: ");
            int T = Int32.Parse(Console.ReadLine());

            Console.WriteLine("{0} Space Separated Nodes To Insert: ", T);

            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = Insert(head, data);
            }
            display(head);
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

        /*
         The Node insert function is declared. 
         It has two parameters: a pointer "head", pointing to the first node of a linked list, 
         and an integer, "data" value that must be added to the end of the list as a new Node object.
         */

        public static Node Insert(Node head, int data)
        {
            Node node = new Node(data);

            // if head is null, set it equal to the first int from data
            if (head == null)
            {
                head = node;
            }
            // if head.next is null, set equal to the node made above  
            else
            {
                if (head.next == null)
                {
                    head.next = node;
                }
                // traverse with a temp head called "current"
                // while the head doesn't equal null, keep adding a pointer to a new node + 
                // set it equal to the 
                else
                {
                    Node current = head;
                    while(current.next != null)
                    {
                        current = current.next;
                    }
                    current.next = node;
                }
            }
            // returning the head of the full list gives us access to the whole linked list
            return head;
        }
    }
}


/*
  public static Node Insert(Node head, int data)
        {
            // if head is null(linked list is empty), seat head equal to the given int from data parameter
            if (head == null)
            {
                head = new Node(data);
            }
            // if the head is equal to a value (an int)
            // create a new node, which will contain the next int
            // then set "node" equal to head.next
            else
            {
                Node node = Insert(head.next, data);
                head.next = node;
            }
            return head;
        }
 */
