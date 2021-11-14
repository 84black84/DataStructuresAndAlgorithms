namespace DataStructuresAndAlgorithms.BinaryTrees
{
    public class Node
    {
        public int value;
        public Node leftChild;
        public Node rightChild;

        public Node(int value)
        {
            this.value = value;

            leftChild = null;
            rightChild = null;
        }

        public override string ToString()
        {
            return this.value.ToString();
        }
    }
}
