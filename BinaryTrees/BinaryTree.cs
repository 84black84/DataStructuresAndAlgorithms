namespace DataStructuresAndAlgorithms.BinaryTrees
{
    using System;

    public class BinaryTree
    {
        public Node root;

        public BinaryTree()
        {
            this.root = null;
        }

        public void InOrderTraversal(Node node)
        {
            if (node == null)
            {
                return;
            }

            this.InOrderTraversal(node.leftChild);
            Console.Write(node.value + " ");
            this.InOrderTraversal(node.rightChild);
        }

        public void InOrderTraversal() { 
            this.InOrderTraversal(root);
        }

        public static void RunInOrderTraversal()
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.root = new Node(60)
            {
                leftChild = new Node(30),
                rightChild = new Node(125)
            };

            binaryTree.root.leftChild.leftChild = new Node(33);
            binaryTree.root.leftChild.rightChild = new Node(40);

            binaryTree.root.rightChild.leftChild = new Node(70);
            binaryTree.root.rightChild.rightChild = new Node(90);

            binaryTree.root.leftChild.leftChild.leftChild = new Node(20);
            binaryTree.root.leftChild.leftChild.rightChild = new Node(30);

            binaryTree.root.rightChild.leftChild.leftChild = new Node(60);

            binaryTree.InOrderTraversal();
        }
    }
}
