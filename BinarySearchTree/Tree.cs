using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class Tree<Gtype> where Gtype:IComparable<Gtype>
    {
        public Gtype Data { get; set; }
        public Tree<Gtype> Left { get; set; }
        public Tree<Gtype> Right { get; set; }

        public Tree(Gtype data)
        {
            this.Data = data;
            this.Right = null;
            this.Left = null;
        }

        public void insert(Gtype data)
        {
            Gtype currentNode = this.Data;
            if((currentNode.CompareTo(data))>0)
            {
                if (this.Left == null)
                    this.Left = new Tree<Gtype>(data);
                else
                    this.Left.insert(data);
            }
            else
            {
                if (this.Right == null)
                    this.Right = new Tree<Gtype>(data);
                else
                    this.Right.insert(data);
            }
        }
        private int l_Count = 0;
        private int r_Count = 0;

        public void display()
        {
            if(this.Left!=null)
            {
                this.l_Count++;
                this.Left.display();
            }
            Console.WriteLine(this.Data.ToString());
            if(this.Right!=null)
            {
                this.r_Count++;
                this.Right.display();
            }
        }
        public bool find(Gtype element,Tree<Gtype> node)
        {
            if (node == null)
                return false;
            if(node.Data.Equals(element))
            {
                Console.WriteLine("Element is Found :" + " " + node.Data);
                return true;
            }
            else
            {
                Console.WriteLine("Current Element {0} in Binary Tree", node.Data);
                if (element.CompareTo(node.Data) < 0)
                    find(element, node.Left);
                if (element.CompareTo(node.Data) > 0)
                    find(element, node.Right);
                return true;
            }
        }
    }
}
