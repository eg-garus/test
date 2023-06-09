﻿using System.Data;
using System.Xml.Linq;

namespace TreeSimple
{
    internal class Program
    {
        public class TreeNode // Класс «Узел бинарного дерева» 
        {
            private char info; // информационное поле 
            private TreeNode left; // ссылка на левое поддерево
            private TreeNode right; // ссылка на правое поддерево
            public char Info
            {
                get { return info; }
                set { info = value; }
            }                               // свойства 
            public TreeNode Left
            {
                get { return left; }
                set { left = value; }
            }
            public TreeNode Right
            {
                get { return right; }
                set { right = value; }
            }
            public TreeNode() { } // конструкторы 
            public TreeNode(char info)
            {
                Info = info;
            }
            public TreeNode(char info, TreeNode left, TreeNode right)
            {
                Info = info; Left = left; Right = right;
            }
        }
        public class BinaryTree // Класс «Бинарное дерево произвольного вида» 
        {
            private TreeNode root; // ссылка на корень дерева 
            public TreeNode Root // свойство, открывающее доступ к корню дерева
            {
                get { return root; }
                set { root = value; }
            }
            public BinaryTree() // инициализация пустого дерева 
            {
                root = null;
            }

        
        public void KLP(TreeNode root)
        {                                                       // root – ссылка на корень дерева и любого из поддеревьев             
            if (root != null)                                // дерево не пусто? 
            {                                                // распечатать информ. поле корневого узла 
                Console.WriteLine(root.Info);
                KLP(root.Left);                             // обойти левое поддерево в нисходящем порядке 
                KLP(root.Right);                            // обойти правое поддерево в нисходящем порядке 
            }
        }
        public void LKP(TreeNode root)
        {
            if (root != null)
            {
                LKP(root.Left);
                Console.WriteLine(root.Info);
                LKP(root.Right);
            }
        }
        public void LPK(TreeNode root)
        {
            if (root != null)
            {
                LPK(root.Left);
                LPK(root.Right);
                Console.WriteLine(root.Info);
            }
        }
        public int CurentRoot(TreeNode root)
        {
            int n;
            if (root == null)
            {
                n = 0;
            }
            else
            {
                n = 1 + CurentRoot(root.Left) + CurentRoot(root.Right);
            }
            return n;
        }
        public TreeNode CreateRecursive(int n)
        {
            char x; TreeNode root;
            if (n == 0) root = null;
            else
            {

                Console.Write("Введите инф поле = ");
                while ((!Char.TryParse(Console.ReadLine(), out x)))
                {
                    Console.Write("Вы ввели не число ^char^! Введите число: ");
                }
                root = new TreeNode(x);
                root.Left = CreateRecursive(n / 2);
                root.Right = CreateRecursive(n - n / 2 - 1);
            }
            return root;
        }
    }
        static void Main(string[] args)
        {
            BinaryTree T = new BinaryTree();
            T.Root = T.CreateRecursive(7);
            T.KLP(T.Root);
            T.LKP(T.Root);
            Console.WriteLine(T.CurentRoot(T.Root));
        }
    }
}