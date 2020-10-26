using System;

namespace BSTOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!! Welcome to Binary Search Tree");
            BST<int> bst = new BST<int>();
            bst.Insert(56);
            bst.Insert(30);
            bst.Insert(70);
            bst.DisplayBST(bst.root);

        }
    }
}