using System;
using System.Collections.Generic;
using System.Text;

namespace Task01
{
    class BTnode<T>
        where T : struct, IComparable
    {
        public T Value { get; set; }
        private int count;
        private int countLeft;
        BTnode<T> left;
        BTnode<T> right;
        public bool IsLeave
        {
            get { return left == null && right == null; }
        }

        public BTnode(T val)
        {
            this.Value = val;
            count = 1;
            left = null;
            right = null;
            countLeft = 0;
        }

        public void InsertValue(T value)
        {
            if (Value.CompareTo(value) == 0)
            {
                count++;
            }
            else if (Value.CompareTo(value) < 0)
            {
                if (right != null)
                {
                    right.InsertValue(value);
                }
                else
                {
                    right = new BTnode<T>(value);
                }
            }
            else
            {
                if (left != null)
                {
                    left.InsertValue(value);
                }
                else
                {
                    left = new BTnode<T>(value);
                }
                countLeft = left.countLeft + 1;
            }
        }

        public void PrintBFS()
        {
            Queue<BTnode<T>> queue = new Queue<BTnode<T>>();
            queue.Enqueue(this);
            while (queue.Count != 0)
            {
                var cur = queue.Dequeue();
                Console.WriteLine($"Value: {cur.Value}, count: {cur.count}");
                if (cur.right != null)
                {
                    queue.Enqueue(cur.right);
                }
                if (cur.left != null)
                {
                    queue.Enqueue(cur.left);
                }
            }
        }

        public void PrintDFS(BTnode<T> cur)
        {
            Console.WriteLine($"Value: {cur.Value}, count: {cur.count}");
            if (cur.left != null)
            {
                PrintDFS(cur.left);
            }
            if (cur.right != null)
            {
                PrintDFS(cur.right);
            }
        }

       
        public void Delete(T value)
        {
            if (Value.CompareTo(value) == 0)
            {
                if (left == null)
                    right = right.right;
                else
                    left = left.left;
            }
            else if (Value.CompareTo(value) > 0)
            {
                if (left == null)
                    throw new ArgumentException("Такого элемента нет");
                if (left.IsLeave)
                    left = null;
                else
                    left.Delete(value);
            }
            else
            {
                if (right == null)
                    throw new ArgumentException("Такого элемента нет");
                if (right.IsLeave)
                    right = null;
                else
                    right.Delete(value);
            }
        }

        public bool Find(T value)
        {
            if (Value.CompareTo(value) == 0)
                return true;
            else if (Value.CompareTo(value) < 0)
            {
                if (right != null)
                    return right.Find(value);
            }
            else
            {
                if (left != null)
                    return left.Find(value);
            }
            return false;
        }

        public void Postorder()
        {
            Queue<(BTnode<T>, int, int)> queue = new Queue<(BTnode<T>, int, int)>();
            List<StringBuilder> ans = new List<StringBuilder>();
            queue.Enqueue((this, 0, countLeft));
            while (queue.Count != 0)
            {
                (BTnode<T> step, int depht, int stride) = queue.Dequeue();
                bool isLeft = false;
                if (depht == ans.Count)
                {
                    if (depht != 0)
                        Console.WriteLine(ans[depht - 1]);
                    ans.Add(new StringBuilder());
                    isLeft = true;
                }
                for (int _ = 0; _ < (isLeft ? stride : 2); ++_)
                {
                    ans[depht].Append('\t');
                }
                ans[depht].Append(step.Value);
                if (step.left != null)
                {
                    queue.Enqueue((step.left, depht + 1, stride - 1));
                }
                if (step.right != null)
                {
                    queue.Enqueue((step.right, depht + 1, stride + 1));
                }
            }
        }
    }

    class BinaryTree<T>
        where T : struct, IComparable
    {
        BTnode<T> root;

        public bool IsEmpty
        {
            get
            {
                return root == null;
            }
        }
        public BinaryTree()
        {
            root = null;
        }
        public void Insert(T val)
        {
            if (IsEmpty)
            {
                root = new BTnode<T>(val);
            }
            else
            {
                root.InsertValue(val);
            }
        }

        public void Print() => root.PrintDFS(root);

        public void Delete(T val)
        {
            if (IsEmpty)
            {
                throw new ArgumentException("Такого элемента нет");
            }
            else
            {
                root.Delete(val);
            }
        }

        public bool Find(T value) => root.Find(value);

        public void Preorder(BTnode<T> node)
        {
            if (Find(node.Value))
            {
                root.PrintDFS(node);
            }
        }

        public void Clear()
        {
            root = null;
        }

        public void Inorder() => root.PrintBFS();

        public void Postorder() => root.Postorder();

    }

    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            BinaryTree<int> sample = new BinaryTree<int>();
            for (int i = 0; i < 15; i++)
            {
                sample.Insert(rnd.Next(10));
            }
            sample.Print();
        }
    }
}