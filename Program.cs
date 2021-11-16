using System.Linq;

namespace DataStructuresAndAlgorithms
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class Result
    {
        /// <summary>
        /// Complete the 'Foo' function below.
        ///
        /// The function is expected to return an INTEGER.
        /// The function accepts following parameters:
        ///     1. STRING_ARRAY codeList
        ///     2. STRING_ARRAY shoppingCart
        /// </summary>
        /// <param name="codeList"></param>
        /// <param name="shoppingCart"></param>
        /// <returns></returns>
        public static int Foo(List<string> codeList, List<string> shoppingCart)
        {

            foreach (string item in codeList)
            {
                var res = item.Split(" ").ToList();

            }


            return 0;
        }
    }

    class Program
    {
        static void Main()
        {
            //BinaryTree binaryTree = BinaryTree.PrepareBinaryTree();
            //binaryTree.StartPostOrderTraversal();

            //CustomerReviews customerReviews = new CustomerReviews();
            //customerReviews.GetSuggestions();

            TextWriter textWriter = new StreamWriter("C:\\Tempo\\note.txt", true);

            int codeListCount = Convert.ToInt32(Console.ReadLine()?.Trim());
            List<string> codeList= new List<string> ();
            for (int i = 0; i < codeListCount; i++)
            {
                string codeListItem = Console.ReadLine();
                codeList.Add(codeListItem);
            }

            int shoppingCartCount = Convert.ToInt32(Console.ReadLine()?.Trim());
            List<string> shoppingCart = new List<string>();
            for (int i = 0; i < shoppingCartCount; i++)
            {
                string shoppingCartItem = Console.ReadLine();
                shoppingCart.Add(shoppingCartItem);
            }

            int result = Result.Foo(codeList, shoppingCart);

            textWriter.WriteLine(result);
            textWriter.Flush();
            textWriter.Close();
        }
    }
}
