namespace DeTreeNode
{
    internal class Program
    {
        public class DTreeNode // Класс «Узел дихотомического дерева» 
        {
            private char info; // информационное поле 
            private int key; // поле ключа 
            private DTreeNode left; // ссылка на левое поддерево
            private DTreeNode right; // ссылка на правое поддерево
            public char Info 
            {
                get { return info; }
                set { info = value; }
            }                                        // свойства 
            public int Key 
            {
                get { return key; }
                set { key = value; }
            }
            public DTreeNode Left 
            {
                get { return left; }
                set { left = value; }
            }
            public DTreeNode Right 
            {
                get { return right; }
                set { right = value; }
            }
            public DTreeNode() { }                   // конструкторы 
            public DTreeNode(char info, int key)
            {
                Info = info; Key = key;
            }
            public DTreeNode(char info, int key, DTreeNode left, DTreeNode right)
            {
                Info = info; Key = key; Left = left; Right = right;
            }
        }
        public class DichotomyTree // класс «Дихотомическое дерево» 
        {
            private DTreeNode root; // ссылка на корень дихотомического дерева 
            public DTreeNode Root // свойство, открывающее доступ к корню дерева
            {
                get { return root; }
                set { root = value; }
            }
            public DichotomyTree() // инициалиазция пустого дерева 
            {
                root = null;
            }

            public DTreeNode Find(DTreeNode root, int key)
            {
                DTreeNode T;
                if (root == null)
                {
                    T = null;
                }
                else
                {
                    if (key < root.Key) T = Find(root.Right, key);
                    else if (key > root.Key) T = Find(root.Right, key);
                    else T = root;
                }
                return T;
            }
            public DTreeNode Insert(DTreeNode root, int key)
            {
                char ch = Char.Parse(Console.ReadLine());
                DTreeNode T;
                if (root == null)
                {
                    root = new DTreeNode(ch, key, null, null);
                }
                else
                {
                    if (key < root.Key) Insert(root.Left, key);
                    else
                    {
                        if (key > root.Key) Insert(root.Right, key);
                    }
                }
                return root;
            }
        }

        static void Main(string[] args)
        {
            DichotomyTree T1 = new DichotomyTree();
            T1.Root = T1.Insert(T1.Root, 100);
            DTreeNode p = T1.Find(T1.Root, 10);

        }
    }
}
