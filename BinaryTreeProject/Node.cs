using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BinaryTreeProject
{
    class Node
    {
        public Node lchild;
        public char info;
        public Node rchild;
        public Node(char ch)
        {
            info = ch;
            lchild = null;
            rchild = null;
        }
    }
}
