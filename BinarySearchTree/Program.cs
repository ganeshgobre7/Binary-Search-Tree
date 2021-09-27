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
            bst.insert(22);
            bst.insert(40);
            bst.insert(60);
            bst.insert(95);
            bst.insert(11);
            bst.insert(65);
            bst.insert(3);
            bst.insert(16);
            bst.insert(63);
            bst.insert(67);
            bst.display();
            Console.WriteLine("Searching 63 in Tree");
            bool result = bst.find(63, bst);
            Console.WriteLine(result);
        }
    }
}
