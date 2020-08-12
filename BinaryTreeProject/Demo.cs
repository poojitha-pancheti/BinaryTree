using System;

namespace BinaryTreeProject
{
    class Demo
    {
        static void Main(string[] args)
        {
            BinaryTree bt = new BinaryTree();
            bt.CreateTree();
            bt.Display();
            Console.WriteLine("");
            Console.WriteLine("PreOrder:");
            bt.PreOrder();
            Console.WriteLine(" ");
            Console.WriteLine("InOrder:");
            bt.InOrder();
            Console.WriteLine(" ");
            Console.WriteLine("PostOrder:");
            bt.PostOrder();
            Console.WriteLine(" ");
            Console.WriteLine("LevelOrder:");
            bt.LevelOrder();
            Console.WriteLine(" ");
            Console.WriteLine("Height of the tree:" + bt.Height());
        }
    }
}
