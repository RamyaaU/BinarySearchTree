using System;

namespace BinarySearchTree
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Binary Search Tree!");
            //Creating an object of bst
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Insert(56);
            bst.Insert(30);
            bst.Insert(70);
            bst.DisplayBST(bst.root);
        }
    }
}
