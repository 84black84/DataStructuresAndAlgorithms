namespace DataStructuresAndAlgorithms
{
    using BinaryTrees;

    class Program
    {
        static void Main()
        {
            BinaryTree binaryTree = BinaryTree.PrepareBinaryTree();
            binaryTree.StartOrderTraversal();
        }
    }
}
