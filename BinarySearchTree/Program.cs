using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE BINARY SEARCH TREE PROBLEM!");
            Tree<int> bst = new Tree<int>(56);
            bst.insert(30);
            bst.insert(70);
            bst.display();
        }
    }
}
