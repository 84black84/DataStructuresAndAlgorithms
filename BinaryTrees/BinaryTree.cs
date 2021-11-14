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

        /// <summary>
        /// The result should be ->
        /// 20 33 30 30 40 60 60 70 125 90
        /// </summary>
        public void StartInOrderTraversal() { 
            this.InOrderTraversal(this.Root);
        }

        /// <summary>
        /// The result should be ->
        /// 60 30 33 20 30 40 125 70 60 90
        /// </summary>
        public void StartPreOrderTraversal()
        {
            this.PreOrderTraversal(this.Root);
        }


        /// <summary>
        /// The result should be ->
        /// 20 30 33 40 30 60 70 90 125 60
        /// </summary>
        public void StartPostOrderTraversal()
        {
            this.PostOrderTraversal(this.Root);
        }

        //           60
        //         /    \
        //        30     125
        //       /  \     / \
        //      33  40   70  90
        //     / \      /
        //    20   30  60
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

        private void PreOrderTraversal(Node root)
        {
            if (root == null)
            {
                return;
            }

            Console.Write(root.Value + " ");
            this.PreOrderTraversal(root.LeftChild);
            this.PreOrderTraversal(root.RightChild);
        }

        private void PostOrderTraversal(Node root)
        {
            if (root == null)
            {
                return;
            }

            
            this.PostOrderTraversal(root.LeftChild);
            this.PostOrderTraversal(root.RightChild);
            Console.Write(root.Value + " ");
        }
    }
}
