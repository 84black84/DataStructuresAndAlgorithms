namespace DataStructuresAndAlgorithms
{
    using AmazonCodingAssessment;

    class Program
    {
        static void Main()
        {
            //BinaryTree binaryTree = BinaryTree.PrepareBinaryTree();
            //binaryTree.StartPostOrderTraversal();

            CustomerReviews customerReviews = new CustomerReviews();
            customerReviews.GetSuggestions();
        }
    }
}
