/*
 * C# Program to Implement Binary Search Tree using Linked List
 */
using System;
using System.Collections.Generic;
using System.Text;
namespace TreeSort
{
    public class BinarySearchTree
    {

        /* Class containing left and right child of current node and key value*/
        public class Node
        {
            public int key;
            public Node left, right;

            public Node(int item)
            {
                key = item;
                left = right = null;
            }
        }

        // Root of BST
        Node root;

        // Constructor
        public BinarySearchTree()
        {
            root = null;
        }

        // This method mainly calls insertRec()
        internal void Insert(int key)
        {
            root = insertRec(root, key);
        }

        /* A recursive function to insert a new key in BST */
        Node insertRec(Node root, int key)
        {

            /* If the tree is empty, return a new node */
            if (root == null)
            {
                root = new Node(key);
                return root;
            }

            /* Otherwise, recur down the tree */
            if (key < root.key)
                root.left = insertRec(root.left, key);
            else if (key > root.key)
                root.right = insertRec(root.right, key);

            /* return the (unchanged) node pointer */
            return root;
        }


        internal void Preorder(Node Root)
        {
            if (Root != null)
            {
                Console.Write(Root.key + " ");
                Preorder(Root.left);
                Preorder(Root.right);
            }
        }

        // A utility function to do inorder traversal of BST
        internal void inorder(Node root)
        {
            if (root != null)
            {
                inorder(root.left);
                Console.Write(root.key + " ");
                inorder(root.right);
            }
        }

        internal void Postorder(Node Root)
        {
            if (Root != null)
            {
                Postorder(Root.left);
                Postorder(Root.right);
                Console.Write(Root.key + " ");
            }
        }

        internal Node ReturnRoot()
        {
            return this.root;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree theTree = new BinarySearchTree();
            theTree.Insert(20);
            theTree.Insert(25);
            theTree.Insert(45);
            theTree.Insert(15);
            theTree.Insert(67);
            theTree.Insert(43);
            theTree.Insert(80);
            theTree.Insert(33);
            theTree.Insert(67);
            theTree.Insert(99);
            theTree.Insert(91);
            Console.WriteLine("Inorder Traversal : ");
            theTree.inorder(theTree.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();
            Console.WriteLine("Preorder Traversal : ");
            theTree.Preorder(theTree.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();
            Console.WriteLine("Postorder Traversal : ");
            theTree.Postorder(theTree.ReturnRoot());
            Console.WriteLine(" ");
        }
    }
}