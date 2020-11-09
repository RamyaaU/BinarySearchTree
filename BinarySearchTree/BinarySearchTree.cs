﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BinarySearchTree<T> where T : IComparable
    {
        // Defining a generic Node root
        public Node<T> root;

        /// <summary>
        /// Initializes a new instance of the <see cref="BinarySearchTree{T}"/> class.
        /// </summary>
        // Default Constructor for the class BinarySearchTree     
        public BinarySearchTree()
        {
            this.root = null;
        }

        /// <summary>
        /// Inserts the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        //Insert the element in the specified node depending upon the value passed by user as data 
        public void Insert(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                // Defining the current node as root
                Node<T> current = root;
                // Defining the parent node
                Node<T> parent;
                while (true)
                {
                    parent = current;
                    // If Data is less than root data then passing it to left node
                    if (data.CompareTo(current.data) < 0)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    //If Data is Greater than root data then passing it to right node
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Displays the BST.
        /// </summary>
        /// <param name="parent">The parent.</param>
        // Displaying the Binary tree In the default in Order from left branch to node to right branch   
        public void DisplayBST(Node<T> parent)
        {
            Console.WriteLine("Parent : {0}", parent.data);
            if (parent.Left != null)
            {
                Console.WriteLine("Left :" + parent.Left.data);
            }
            if (parent.Right != null)
            {
                Console.WriteLine("Right :" + parent.Right.data);
            }
            if (parent.Left != null)
            {
                DisplayBST(parent.Left);
            }
            if (parent.Right != null)
            {
                DisplayBST(parent.Right);
            }
        }

        /// <summary>
        /// Sizes the specified node.
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns></returns>
        // Method to Get the size of the Binary Search Tree        
        public int Size(Node<T> node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                // Adding the all the left node, all the right nodes and the root node 
                return (Size(node.Left) + 1 + Size(node.Right));
            }
        }
    }
}
