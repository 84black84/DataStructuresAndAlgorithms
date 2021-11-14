namespace DataStructuresAndAlgorithms.BinaryTrees
{
    public class Node
    {
        public int Value;
        public Node LeftChild;
        public Node RightChild;

        public Node(int value)
        {
            this.Value = value;

            LeftChild = null;
            RightChild = null;
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
