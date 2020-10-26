using System;

namespace BSTOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!! Welcome to Binary Search Tree");
            BST<int> bst = new BST<int>();
            int[] arr = { 56, 30, 70, 22, 60, 40, 95, 16, 63, 67, 4, 11, 65 };
            for (int i = 0; i < arr.Length; i++)
            {
                bst.Insert(arr[i]);
            }
            bst.DisplayBST(bst.root);
            Console.WriteLine("\n\nSize of BST: " + bst.Size(bst.root));

            bst.Search(60);
            bst.Search(20);
        }
    }
}