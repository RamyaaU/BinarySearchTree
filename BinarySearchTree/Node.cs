using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class Node<T> where T : IComparable
    {
        // Node Value in Binary Tree
        public T data { get; set; }
        // Left Order Tree storing the element less than the node data
        public Node<T> Left { get; set; }
        // Right Order Tree storing the element greater than the node data
        public Node<T> Right { get; set; }
        //Creating a Primary Parameterised Constructor to mark the formation of a new binary tree        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Node{T}"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public Node(T data)
        {
            this.data = data;
            Left = null;
            Right = null;
        }
    }
}