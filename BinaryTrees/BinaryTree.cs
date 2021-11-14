namespace DataStructuresAndAlgorithms.BinaryTrees
{
    using System;

    public class BinaryTree
    {
        public Node Root;

        public BinaryTree()
        {
            this.Root = null;
        }

        private void InOrderTraversal(Node node)
        {
            if (node == null)
            {
                return;
            }

            this.InOrderTraversal(node.LeftChild);
            Console.Write(node.Value + " ");
            this.InOrderTraversal(node.RightChild);
        }

        /// <summary>
        /// The result should be ->
        /// 20 33 30 30 40 60 60 70 125 90
        /// </summary>
        public void StartOrderTraversal() { 
            this.InOrderTraversal(this.Root);
        }

        public static BinaryTree PrepareBinaryTree()
        {
            BinaryTree binaryTree = new BinaryTree
            {
                Root = new Node(60)
                {
                    LeftChild = new Node(30),
                    RightChild = new Node(125)
                }
            };

            binaryTree.Root.LeftChild.LeftChild = new Node(33);
            binaryTree.Root.LeftChild.RightChild = new Node(40);

            binaryTree.Root.RightChild.LeftChild = new Node(70);
            binaryTree.Root.RightChild.RightChild = new Node(90);

            binaryTree.Root.LeftChild.LeftChild.LeftChild = new Node(20);
            binaryTree.Root.LeftChild.LeftChild.RightChild = new Node(30);

            binaryTree.Root.RightChild.LeftChild.LeftChild = new Node(60);
            return binaryTree;
        }
    }
}
