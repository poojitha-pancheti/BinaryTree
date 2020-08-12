using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeProject
{
    class BinaryTree
    {
        private Node root;
        public BinaryTree()
        {
            root = null;
        }
        public void Display()
        {
            Display(root, 0);
            Console.WriteLine();
        }
        private void Display(Node p,int level)
        {
            int i;
            if (p == null)
                return;
            Display(p.rchild, level + 1);
            Console.WriteLine();
            for (i = 0; i < level; i++)
                Console.Write(" ");
            Console.Write(p.info);
            Display(p.lchild, level + 1);

        }
        public void PreOrder()
        {
            PreOrder(root);
            Console.WriteLine();
        }
        private void PreOrder(Node p)
        {
            if (p == null)
                return;
            Console.WriteLine(p.info + " ");
            PreOrder(p.lchild);
            PreOrder(p.rchild);
        }
        public void InOrder()
        {
            InOrder(root);
            Console.WriteLine();
        }
        private void InOrder(Node p)
        {
            if (p == null)
                return;
            InOrder(p.lchild);
            Console.WriteLine(p.info + " ");
            InOrder(p.rchild);
        }
        public void PostOrder()
        {
            PostOrder(root);
            Console.WriteLine();
        }
        private void PostOrder(Node p)
        {
            if (p == null)
                return;
            PostOrder(p.lchild);
            PostOrder(p.rchild);
            Console.WriteLine(p.info + " ");
        }
        public void LevelOrder()
        {
            if (root == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            Queue<Node> qu = new Queue<Node>();
            qu.Enqueue(root);
            Node p;
            while (qu.Count != 0)
            {
                p = qu.Dequeue();
                Console.WriteLine(p.info + " ");
                if (p.lchild != null)
                    qu.Enqueue(p.lchild);
                if (p.rchild != null)
                    qu.Enqueue(p.rchild);
            }
            Console.WriteLine();
        }
        public int Height()
        {
            return Height(root);
        }
        private int Height(Node p)
        {
            if (p == null)
                return 0;
            int hL = Height(p.lchild);
            int hR = Height(p.rchild);
            if (hL > hR)
                return hL + 1;
            else
                return hR + 1;


        }
        public void CreateTree()
        {
            root = new Node('P');
            root.lchild = new Node('Q');
            root.rchild = new Node('R');
            root.lchild.lchild = new Node('A');
            root.lchild.rchild = new Node('B');
            root.rchild.lchild = new Node('X');
        }
    }
}
