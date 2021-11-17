namespace DataStructuresAndAlgorithms
{
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
            int matched = 0;
            int startPosition = 0;

            foreach (string item in codeList)
            {
                string[] listOfCodesItem = item.Split(" ");
                int listOfCodesItemLength = listOfCodesItem.Length;
                int anythingPosition = GetAnythingPosition(listOfCodesItem, listOfCodesItemLength);
                int codeListItemLength = listOfCodesItem.Length;
                bool found = false;
                int finishPosition = startPosition + codeListItemLength - 1;
                while (!found && finishPosition < shoppingCart.Count)
                {
                    // Recursive solution might be more efficient
                    string shoppingCartCurrentSelection = GetShoppingCartSelection(shoppingCart.ToArray(), startPosition, finishPosition, startPosition + anythingPosition);
                    if (shoppingCartCurrentSelection.ToLower() != item.ToLower())
                    {
                        startPosition++;
                        finishPosition++;
                        continue;
                    }

                    matched++;
                    if (matched == codeList.Count)
                    {
                        return 1; // winner
                    }

                    found = true;
                    startPosition = finishPosition + 1;
                }
            }

            return 0; // not a winner
        }

        private static int GetAnythingPosition(string[] listOfCodesItem, int listOfCodesItemLength)
        {
            int anythingPosition = -1;
            for (int i = 0; i < listOfCodesItemLength; i++)
            {
                if (listOfCodesItem[i] == "anything")
                {
                    return i;
                }
            }

            return anythingPosition;
        }

        private static string GetShoppingCartSelection(string[] shoppingCart, int startPosition, int finishPosition, int anythingPosition)
        { 
            string shoppingCartSelection = "";
            for (int i = startPosition; i <= finishPosition; i++)
            {
                if (i == finishPosition)
                {
                    shoppingCartSelection += anythingPosition == i ?  "anything" : shoppingCart[i];
                }
                else
                {
                    shoppingCartSelection += (anythingPosition == i ? "anything" : shoppingCart[i]) + " ";
                }   
            }

            return shoppingCartSelection;
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


            //int codeListCount = Convert.ToInt32(Console.ReadLine()?.Trim());
            //List<string> codeList= new List<string> ();
            //for (int i = 0; i < codeListCount; i++)
            //{
            //    string codeListItem = Console.ReadLine();
            //    codeList.Add(codeListItem);
            //}

            //int shoppingCartCount = Convert.ToInt32(Console.ReadLine()?.Trim());
            //List<string> shoppingCart = new List<string>();
            //for (int i = 0; i < shoppingCartCount; i++)
            //{
            //    string shoppingCartItem = Console.ReadLine();
            //    shoppingCart.Add(shoppingCartItem);
            //}

            List<string> codeList = new List<string> { "apple apple", "banana anything banana" };
            List<string> shoppingCart = new List<string> { "orange", "apple", "apple", "banana", "orange", "banana" };
            int result = Result.Foo(codeList, shoppingCart);

            TextWriter textWriter = new StreamWriter("C:\\Tempo\\note.txt", true);
            textWriter.WriteLine(result);
            textWriter.Flush();
            textWriter.Close();
        }
    }
}
