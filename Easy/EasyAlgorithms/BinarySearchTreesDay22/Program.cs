using System;

namespace BinarySearchTreesDay22
{
    class Node
    {
        public Node left, right;
        public int data;
        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
    }

    class Program
    {
        static int getHeight(Node root)
        {
            int height = 0;
            int leftHeight = 0;
            int rightHeight = 0;

            if (root.left != null)
            {
                leftHeight = getHeight(root.left) + 1;
            }
            if (root.right != null)
            {
                rightHeight = getHeight(root.right) + 1;
            }

            if (leftHeight > rightHeight)
            {
                height = leftHeight;
            }
            else
            {
                height = rightHeight;
            }

            return height;
        }

        static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }

        static void Main(String[] args)
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            int height = getHeight(root);
            Console.WriteLine(height);

        }
    }
}
