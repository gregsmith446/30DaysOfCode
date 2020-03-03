using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _23LevelOrderTraversalBST
{
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


    class Solution
    {
        static void Main(String[] args)
        {
            Node root = null;
            Console.WriteLine("How many ints to add to Binary Search Tree: ");
            int T = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Give {0} ints, hitting enter after each one.", T);
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            levelOrder(root);
        }

        static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node current;
                if (data <= root.data)
                {
                    current = insert(root.left, data);
                    root.left = current;
                }
                else
                {
                    current = insert(root.right, data);
                    root.right = current;
                }
                return root;
            }
        }

        /*
          A level-order traversal of tree  is a recursive algorithm that processes the root, followed by the children of the root (from left to right), 
          followed by the grandchildren of the root (from left to right), etc. 
          The basic algorithm shown below uses a queue of references to binary trees to keep track of the subtrees at each level:
          This type of search is also referred to as a breadth-first-search.
          */

        static void levelOrder(Node root)
        {
            Queue<Node> queue = new Queue<Node>();

            Node now;

            if (root != null)
            {
                queue.Enqueue(root);
            }

            while (queue.Count > 0)
            {
                now = queue.Dequeue();
                Console.Write(now.data + " ");

                if (now.left != null)
                {
                    queue.Enqueue(now.left);
                }

                if (now.right != null)
                {
                    queue.Enqueue(now.right);
                }
            }
        }
    }
}



