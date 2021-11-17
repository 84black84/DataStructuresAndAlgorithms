namespace DataStructuresAndAlgorithms.DemoCodingAssessment
{
    using System.Collections.Generic;

    public class CodePromo
    {
        private const string JokerString = "anything";

        /// <summary>
        /// The function is expected to return an INTEGER.
        /// The function accepts following parameters:
        ///     1. STRING_ARRAY codeList
        ///     2. STRING_ARRAY shoppingCart
        /// </summary>
        /// <param name="codeList"></param>
        /// <param name="shoppingCart"></param>
        /// <returns></returns>
        public int WeHaveWinner(List<string> codeList, List<string> shoppingCart)
        {
            int matched = 0;
            int startPosition = 0;

            foreach (string item in codeList)
            {
                string[] listOfCodesItem = item.Split(" ");
                int listOfCodesItemLength = listOfCodesItem.Length;
                int jokerStringPosition = GetJokerStringPosition(listOfCodesItem, listOfCodesItemLength);
                int codeListItemLength = listOfCodesItem.Length;
                bool found = false;
                int finishPosition = startPosition + codeListItemLength - 1;
                while (!found && finishPosition<shoppingCart.Count)
                {
                    // Recursive solution might be more efficient
                    string shoppingCartCurrentSelection = GetShoppingCartSelection(shoppingCart.ToArray(), startPosition, finishPosition, startPosition + jokerStringPosition);
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

        private int GetJokerStringPosition(string[] listOfCodesItem, int listOfCodesItemLength)
        {
            var jokerStringPosition = -1;
            for (var i = 0; i < listOfCodesItemLength; i++)
            {
                if (listOfCodesItem[i] == JokerString)
                {
                    return i;
                }
            }

            return jokerStringPosition;
        }

        private string GetShoppingCartSelection(string[] shoppingCart, int startPosition, int finishPosition, int jokerStringPosition)
        {
            string shoppingCartSelection = "";
            for (int i = startPosition; i <= finishPosition; i++)
            {
                if (i == finishPosition)
                {
                    shoppingCartSelection += jokerStringPosition == i ? JokerString : shoppingCart[i];
                }
                else
                {
                    shoppingCartSelection += (jokerStringPosition == i ? JokerString : shoppingCart[i]) + " ";
                }
            }

            return shoppingCartSelection;
        }
    }
}
